using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceDatabase;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace InsuranceDatabase.Controllers
{
    [Authorize(Roles = "admin,broker")] 
    public class DocumentsController : Controller
    {
        private readonly InsuranceContext _context;

        public DocumentsController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: Documents
        public async Task<IActionResult> Index(int? brokerId, int? clientId, string? error, int? typeId, int? categoryId, string? searchString, string? brokerName, string? clientName)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (searchString != null)
            {
                var documents = _context.Documents.Where(b => b.Number.Contains(searchString)).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();
                return View(documents);
            }
            if (categoryId != null)
            {
                var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Types t ON d.TypeId = t.Id
                    INNER JOIN Categories c ON t.CategoryId = c.Id
                    WHERE c.Id = {0}", categoryId)
                        .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                return View(documents);
            }
            if (brokerName != null || clientName != null)
            {
                if (brokerName != null && clientName != null)
                {
                    if (brokerName.Split(new char[] { ' ' }).Length > 1 && clientName.Split(new char[] { ' ' }).Length > 1)
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id
                    INNER JOIN Clients c ON d.ClientId = c.Id
                    WHERE (b.Name LIKE {0} AND b.Surname LIKE {1} OR b.Name LIKE {1} AND b.Surname LIKE {0}) 
                    AND (c.Name LIKE {2} AND c.Surname LIKE {3} OR c.Name LIKE {3} AND c.Surname LIKE {2})",
                    brokerName.Split(new char[] { ' ' })[0], brokerName.Split(new char[] { ' ' })[1], clientName.Split(new char[] { ' ' })[0], clientName.Split(new char[] { ' ' })[1])
                        .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                        return View(documents);
                    }
                    else if (brokerName.Split(new char[] { ' ' }).Length > 1)
                    {

                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id
                    INNER JOIN Clients c ON d.ClientId = c.Id
                    WHERE (b.Name LIKE {0} AND b.Surname LIKE {1} OR b.Name LIKE {1} AND b.Surname LIKE {0}) 
                    AND (c.Name LIKE {2} OR c.Surname LIKE {2} )",
                    brokerName.Split(new char[] { ' ' })[0], brokerName.Split(new char[] { ' ' })[1], clientName)
                        .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                        return View(documents);
                    }
                    else if (clientName.Split(new char[] { ' ' }).Length > 1)
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id
                    INNER JOIN Clients c ON d.ClientId = c.Id
                    WHERE (b.Name LIKE {0} OR b.Surname LIKE {0}) 
                    AND (c.Name LIKE {1} AND c.Surname LIKE {2} OR c.Name LIKE {2} AND c.Surname LIKE {1})",
                    brokerName, clientName.Split(new char[] { ' ' })[0], clientName.Split(new char[] { ' ' })[1])
                        .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                        return View(documents);
                    }
                    else
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id
                    INNER JOIN Clients c ON d.ClientId = c.Id
                    WHERE (b.Name LIKE {0} OR b.Surname LIKE {0}) 
                    AND (c.Name LIKE {1} OR c.Surname LIKE {1} )",
                    brokerName, clientName)
                        .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                        return View(documents);
                    }
                }
                else if (clientName == null)
                {
                    if (brokerName.Split(new char[] { ' ' }).Length > 1)
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id 
                    WHERE b.Name LIKE {0} AND b.Surname LIKE {1} OR b.Name LIKE {1} AND b.Surname LIKE {0}", brokerName.Split(new char[] { ' ' })[0], brokerName.Split(new char[] { ' ' })[1]).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                        return View(documents);
                    }
                    else
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id 
                    WHERE b.Name LIKE {0} OR b.Surname LIKE {0}", brokerName).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                        return View(documents);
                    }
                }
                else
                {
                    if (clientName.Split(new char[] { ' ' }).Length > 1)
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Clients c ON d.ClientId = c.Id 
                    WHERE c.Name LIKE {0} AND c.Surname LIKE {1} OR c.Name LIKE {1} AND c.Surname LIKE {0} ", clientName.Split(new char[] { ' ' })[0], clientName.Split(new char[] { ' ' })[1]).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();
                        return View(documents);

                    }
                    else
                    {
                        var documents = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Clients c ON d.ClientId = c.Id 
                    WHERE c.Name LIKE {0} OR c.Surname LIKE {0}", clientName).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();
                        return View(documents);
                    }
                }
            }
            if (brokerId > 0)
            {
                brokerName = _context.Brokers.Find(brokerId).FullName;
                ViewBag.ClientDocId = -1;
                ViewBag.TypeDocId = -1;
                ViewBag.BrokerDocId = brokerId;
                var brokersDocuments = _context.Documents.Where(b => b.BrokerId == brokerId).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                // var brokersDocuments = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Brokers b ON d.BrokerId = b.Id WHERE b.FullName LIKE {0}", brokerName)
                //   .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                return View(brokersDocuments);
            }
            else if (clientId > 0)
            {
                clientName = _context.Clients.Find(clientId).FullName;
                ViewBag.BrokerDocId = -1;
                ViewBag.TypeDocId = -1;
                ViewBag.ClientDocId = clientId;
                var clientsDocuments = _context.Documents.Where(b => b.ClientId == clientId).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                //var clientsDocuments = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Clients c ON d.ClientId = c.Id WHERE c.FullName LIKE {0}", clientName)
                //  .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();
                return View(clientsDocuments);
            }
            else if (typeId > 0)
            {
                string typeName = _context.Types.Find(typeId).Type;
                ViewBag.BrokerDocId = -1;
                ViewBag.TypeDocId = typeId;
                ViewBag.ClientDocId = -1;
                var typesDocuments = _context.Documents.Where(b => b.TypeId == typeId).Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();

                //var typesDocuments = _context.Set<Documents>().FromSqlRaw(@"SELECT d.* FROM Documents d INNER JOIN  Types t ON d.TypeId = t.Id WHERE t.Type LIKE {0}", typeName)
                //  .Include(b => b.Client).Include(b => b.Broker).Include(b => b.Type).ToList();
                return View(typesDocuments);
            }
            else
            {
                ViewBag.ErrorMes = error;
                ViewBag.BrokerDocId = -1;
                ViewBag.ClientDocId = -1;
                ViewBag.TypeDocId = -1;
                var insuranceContext = _context.Documents.Include(d => d.Broker).Include(d => d.Client).Include(d => d.Type);
                return View(await insuranceContext.ToListAsync());
            }
        }

        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id, int? brokerId, int clientId, int typeId)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.BrokerDocId = brokerId;
            ViewBag.ClientDocId = clientId;
            ViewBag.TypeDocId = typeId;

            var documents = await _context.Documents
                .Include(d => d.Broker)
                .Include(d => d.Client)
                .Include(d => d.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documents == null)
            {
                return NotFound();
            }

            return View(documents);
        }

        // GET: Documents/Create
        public IActionResult Create(int? bbrokerId, int? cclientId, int ttypeId)
        {
            ViewBag.BrokerDocId = bbrokerId;
            ViewBag.ClientDocId = cclientId;
            ViewBag.TypeDocId = ttypeId;
            if (bbrokerId > 0)
            {
                ViewData["BrokersId"] = new SelectList(_context.Brokers.Where(b => b.Id == bbrokerId), "Id", "FullName");
                ViewData["ClientsId"] = new SelectList(_context.Clients, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Type");
            }
            else if (cclientId > 0)
            {
                ViewData["ClientsId"] = new SelectList(_context.Clients.Where(b => b.Id == cclientId), "Id", "FullName");
                ViewData["BrokersId"] = new SelectList(_context.Brokers, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Type");
            }
            else if (ttypeId > 0)
            {
                ViewData["TypesId"] = new SelectList(_context.Types.Where(b => b.Id == ttypeId), "Id", "Type");
                ViewData["ClientsId"] = new SelectList(_context.Clients, "Id", "FullName");
                ViewData["BrokersId"] = new SelectList(_context.Brokers, "Id", "FullName");
            }
            else
            {
                ViewData["BrokersId"] = new SelectList(_context.Brokers, "Id", "FullName");
                ViewData["ClientsId"] = new SelectList(_context.Clients, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Type");
            }


            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int bbrokerId, int cclientId, int ttypeId, [Bind("Id,Number,Date,Sum,TypeId,ClientId,BrokerId")] Documents documents)
        {
            ViewBag.ClientDocId = cclientId;
            ViewBag.BrokerDocId = bbrokerId;
            ViewBag.TypeId = ttypeId;
            if (ModelState.IsValid)
            {
                _context.Add(documents);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Documents", new { brokerId = bbrokerId, clientId = cclientId, typeId = ttypeId });
            }

            return RedirectToAction("Index", "Documents", new { brokerId = bbrokerId, clientId = cclientId, typeId = ttypeId });
        }

        // GET: Documents/Edit/5
        public async Task<IActionResult> Edit(int? id, int? bDocId, int? clDocId, int tDocId)
        {
            ViewBag.ClientDocId = clDocId;
            ViewBag.BrokerDocId = bDocId;
            ViewBag.TypeDocId = tDocId;

            if (id == null)
            {
                return NotFound();
            }
            var documents = await _context.Documents.FindAsync(id);
            if (bDocId > 0)
            {
                ViewData["BrokersId"] = new SelectList(_context.Brokers.Where(b => b.Id == bDocId), "Id", "FullName");
                ViewData["ClientsId"] = new SelectList(_context.Clients, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Type", documents.TypeId);
            }
            else if (clDocId > 0)
            {
                ViewData["ClientsId"] = new SelectList(_context.Clients.Where(b => b.Id == clDocId), "Id", "FullName");
                ViewData["BrokersId"] = new SelectList(_context.Brokers, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Type", documents.TypeId);
            }
            else if (tDocId > 0)
            {
                ViewData["ClientsId"] = new SelectList(_context.Clients, "Id", "FullName");
                ViewData["BrokersId"] = new SelectList(_context.Brokers, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types.Where(b => b.Id == tDocId), "Id", "Type");
            }
            else
            {
                ViewData["BrokersId"] = new SelectList(_context.Brokers, "Id", "FullName");
                ViewData["ClientsId"] = new SelectList(_context.Clients, "Id", "FullName");
                ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Type", documents.TypeId);
            }


            if (documents == null)
            {
                return NotFound();
            }

            return View(documents);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int bDocId, int clDocId, int tDocId, [Bind("Id,Number,Date,Sum,TypeId,ClientId,BrokerId")] Documents documents)
        {
            ViewBag.ClientDocId = clDocId;
            ViewBag.BrokerDocId = bDocId;
            ViewBag.TypeDocId = tDocId;
            if (id != documents.Id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {

                try
                {
                    _context.Update(documents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentsExists(documents.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Documents", new { brokerId = bDocId, clientId = clDocId, typeId = tDocId });
            }

            return RedirectToAction("Index", "Documents", new { brokerId = bDocId, clientId = clDocId, typeId = tDocId });
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id, int? brokerId, int? clientId, int typeId)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.ClientDocId = clientId;
            ViewBag.BrokerDocId = brokerId;
            ViewBag.TypeDocId = typeId;
            var documents = await _context.Documents
                .Include(d => d.Broker)
                .Include(d => d.Client)
                .Include(d => d.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documents == null)
            {
                return NotFound();
            }

            return View(documents);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, int brokerId, int clientId, int typeId)
        {
            ViewBag.ClientDocId = clientId;
            ViewBag.BrokerDocId = brokerId;
            ViewBag.TypeDocId = typeId;
            var documents = await _context.Documents.FindAsync(id);
            _context.Documents.Remove(documents);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Documents", new { brokerId = brokerId, clientId = clientId, typeId = typeId });
        }

        public IActionResult NumValid(String? Number, int? Id)
        {
            var documents = _context.Documents.Where(d => d.Number.Equals(Number) && d.Id != Id).ToList();
            if (documents.Count() != 0) { return Json(data: "Такий номер документа вже є в базі"); }
            if (Number.Length != 10) return Json(data: "Номер документа занадто которкий");

            for (int i = 0; i < Number.Length; i++)
            {
                if (Number[i] < '0' || Number[i] > '9')
                {
                    return Json(data: "Невірний формат данних");
                }
            }
            return Json(data: true);
        }
        public IActionResult TypeValid(int? TypeId, int? BrokerId)
        {
            var brokers = _context.Set<Brokers>().FromSqlRaw(@"SELECT b.* FROM Brokers b INNER JOIN  BrokersCategories bc ON b.Id = bc.BrokerId 
                INNER JOIN Categories c ON c.Id = bc.CategoryId INNER JOIN Types t ON t.CategoryId = c.Id
                    WHERE t.Id = {0}", TypeId).ToList();

            var broker = brokers.Where(b => b.Id == BrokerId).ToList();
            if (broker.Count() == 0)
            {
                return Json(data: "Обраний брокер не працює в даній категорії");
            }


            return Json(data: true);
        }



        public IActionResult DateValid(DateTime? Date)
        {
            char[] param = { '.', '/', ':', ' ' };
            string birthDate = Date.ToString();
            int year, day, month;
            try
            {
                year = Convert.ToInt32(birthDate.Split(param)[2]);
                month = Convert.ToInt32(birthDate.Split(param)[0]);
                day = Convert.ToInt32(birthDate.Split(param)[1]);
            }
            catch (Exception e) { return Json(data: "Невірний формат данних"); }
            if (birthDate != null)
            {
                if (year < 2018 || year > DateTime.Today.Year || (year == DateTime.Today.Year
                    && month > DateTime.Today.Month) || (year == DateTime.Today.Year && month == DateTime.Today.Month
                    && day > DateTime.Today.Day))
                {
                    return Json(data: "Невірна дата");
                }
            }
            return Json(data: true);

        }




        private bool DocumentsExists(int id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }
    }
}
