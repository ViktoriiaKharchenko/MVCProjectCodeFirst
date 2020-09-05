using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceDatabase.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace InsuranceDatabase.Controllers
{
    //[Authorize(Roles = "admin,broker")] 
    public class BrokersController : Controller
    {
        private readonly InsuranceContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public BrokersController(InsuranceContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Brokers
        public async Task<IActionResult> Index(int? categoryId, string? SearchString, int? brokerId)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (brokerId != null)
            {
                var brokers = _context.Set<Brokers>().FromSqlRaw(@"select bs.* from Brokers bs
                     where not exists
                     ((
                     Select c.Id From Categories c Inner Join BrokersCategories bc 
                     On c.Id = bc.CategoryId
                     where bc.BrokerId = {0}
                     )except 
                      (
                      Select c.Id From Categories c Inner Join BrokersCategories bc 
                     On c.Id = bc.CategoryId
                     where bc.BrokerId = bs.Id
                     ))", brokerId).ToList();
                return View(brokers);
            }
            if (SearchString != null)
            {
                var brokers = _context.Brokers.Where(b => b.Name.Contains(SearchString) || b.Surname.Contains(SearchString) || SearchString.Contains(b.Name) && SearchString.Contains(b.Surname)).ToList();
                return View(brokers);
            }
            if (categoryId != null)
            {
                var brokers = _context.Set<Brokers>().FromSqlRaw(@"SELECT b.* FROM Brokers b INNER JOIN BrokersCategories bc ON bc.BrokerId = b.Id
                    WHERE bc.CategoryId = {0}", categoryId).ToList();

                return View(brokers);
            }
            return View(await _context.Brokers.ToListAsync());
        }

        // GET: Brokers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.BrokerName = _context.Brokers.Find(id).FullName;
            var brokers = await _context.Brokers
                .FirstOrDefaultAsync(m => m.Id == id);

            if (brokers == null)
            {
                return NotFound();
            }

            var brokerId = id;
            ViewBag.BrokerId = id;
            ViewBag.Day = _context.Brokers.Find(id).BirthDate.Day;
            ViewBag.Month = _context.Brokers.Find(id).BirthDate.Month;
            ViewBag.Year = _context.Brokers.Find(id).BirthDate.Year;
            ViewBag.Count = _context.BrokersCategories.Where(b => b.BrokerId == brokerId).Include(b => b.Category).Count();
            ViewBag.CategoriesList = _context.BrokersCategories.Where(b => b.BrokerId == brokerId).Include(b => b.Category).ToList();
            return View(brokers);
        }

        // GET: Brokers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brokers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,BirthDate,PhoneNum,Passport,Email,Photo")] BrokerCreateEditModel brokerModel)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (brokerModel.Photo != null)
                {
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "brokerImages");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + brokerModel.Photo.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    brokerModel.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Brokers newBroker = new Brokers
                {
                    Name = brokerModel.Name,
                    Surname = brokerModel.Surname,
                    BirthDate = brokerModel.BirthDate,
                    PhoneNum = brokerModel.PhoneNum,
                    Passport = brokerModel.Passport,
                    Email = brokerModel.Email,
                    ImagePath = uniqueFileName
                };
                _context.Add(newBroker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brokerModel);
        }

        // GET: Brokers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var brokers = await _context.Brokers.FindAsync(id);
            if (brokers == null)
            {
                return NotFound();
            }
            return View(brokers);
        }

        // POST: Brokers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,BirthDate,PhoneNum,Passport,Email,Password")] Brokers brokers)
        {

            if (id != brokers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brokers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrokersExists(brokers.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(brokers);
        }

        // GET: Brokers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.BrokerName = _context.Brokers.Find(id).FullName;
            var brokers = await _context.Brokers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brokers == null)
            {
                return NotFound();
            }

            return View(brokers);
        }

        // POST: Brokers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brokers = await _context.Brokers.FindAsync(id);
            var docs = _context.Documents.Where(b => b.BrokerId == id).ToList();
            var brokersCategories = _context.BrokersCategories.Where(b => b.BrokerId == id).ToList();
            foreach (var doc in docs)
            {
                _context.Documents.Remove(doc);
            }
            foreach (var bc in brokersCategories)
            {
                _context.BrokersCategories.Remove(bc);
            }
            _context.Brokers.Remove(brokers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> BrokersDocuments(int? id, string broker)
        {
            if (id == null)
            {
                return NotFound();
            }


            var BrokerId = id;
            ViewBag.BrokerId = id;

            return RedirectToAction("Index", "Documents", new { brokerId = BrokerId });
        }


        public IActionResult PhoneValid(string? PhoneNum)
        {
            if (PhoneNum != null)
            {
                if (PhoneNum.Length != 10) return Json(data: "Номер телефону занадто которкий");
                for (int i = 0; i < PhoneNum.Length; i++)
                {
                    if (PhoneNum[0] != '0' || PhoneNum[i] < '0' || PhoneNum[i] > '9')
                    {
                        return Json(data: "Невірний формат данних");
                    }
                }
            }
            return Json(data: true);
        }
        public IActionResult PassportValid(string? Passport, int? Id)
        {
            if (Passport != null)
            {
                if (Passport.Length != 9) return Json(data: "Номер паспорту занадто которкий");
                for (int i = 0; i < Passport.Length; i++)
                {
                    if (Passport[i] < '0' || Passport[i] > '9')
                    {
                        return Json(data: "Невірний формат данних");
                    }
                }

                var pas = _context.Brokers.Where(b => b.Passport == Passport).Where(b => b.Id != Id);
                if (pas.Count() > 0) { return Json(data: "Людина з таким номером паспорта вже зареєстрована в базі"); }

            }

            return Json(data: true);

        }
        public IActionResult NameValid(string? Name)
        {
            if (Name != null)
            {
                if (Name.Length < 2) { return Json(data: "Невірний формат данних"); }
                for (int i = 0; i < Name.Length; i++)
                {
                    if ((Name[i] < 'А' || Name[i] > 'ї') && Name[i] != 'І') { return Json(data: "Невірний формат данних"); }
                }
            }
            return Json(data: true);
        }
        public IActionResult SurnameValid(string? Surname)
        {
            if (Surname != null)
            {
                if (Surname.Length < 2) { return Json(data: "Невірний формат данних"); }
                for (int i = 0; i < Surname.Length; i++)
                {
                    if ((Surname[i] < 'А' || Surname[i] > 'ї') && Surname[i] != 'І') { return Json(data: "Невірний формат данних"); }
                }
            }
            return Json(data: true);
        }

        public IActionResult DateValid(DateTime? BirthDate)
        {
            char[] param = { '.', '/', ':', ' ' };
            string birthDate = BirthDate.ToString();
            int year;
            try { year = Convert.ToInt32(birthDate.Split(param)[2]); }
            catch (Exception e) { return Json(data: "Невірний формат данних"); }
            if (birthDate != null)
            {
                if (year < DateTime.Today.Year - 65 || year > DateTime.Today.Year - 18)
                {
                    return Json(data: "Невірна дата");
                }
            }
            return Json(data: true);

        }

        private bool BrokersExists(int id)
        {
            return _context.Brokers.Any(e => e.Id == id);
        }
    }
}
