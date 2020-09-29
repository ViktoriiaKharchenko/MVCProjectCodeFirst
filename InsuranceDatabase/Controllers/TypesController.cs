﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceDatabase;
using Microsoft.AspNetCore.Authorization;
using System.Data.SqlClient;

namespace InsuranceDatabase.Controllers
{

    public class TypesController : Controller
    {
        private readonly InsuranceContext _context;

        public TypesController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: Types
        public async Task<IActionResult> Index(int? id, string? category)
        {
            if (id == null) return RedirectToAction("Categories", "Index");

            ViewBag.CategoryId = id;
            ViewBag.CategoryName = category;

            var typesByCategory = _context.Set<Types>().FromSqlRaw(@"SELECT t.* FROM Types t INNER JOIN  Categories c ON t.CategoryId = c.Id WHERE c.Category LIKE {0}", category).Include(b => b.Category);

            return View(await typesByCategory.ToListAsync());
            //return View(await _context.Types.ToListAsync());

        }

        // GET: Types/Details/5
        public async Task<IActionResult> Details(int? categoryId, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.CategoryId = categoryId;
            ViewBag.CategoryName = _context.Categories.Find(categoryId).Category;
            ViewBag.TypeName = _context.Types.Find(id).Type;
            var types = await _context.Types
                .Include(t => t.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (types == null)
            {
                return NotFound();
            }

            return View(types);
        }

        // GET: Types/Create
        [Authorize(Roles = "admin,broker")]
        public IActionResult Create(int categoryId)
        {

            ViewBag.CategoryId = categoryId;
            ViewBag.CategoryName = _context.Categories.Where(c => c.Id == categoryId).FirstOrDefault().Category;
            return View();
        }

        // POST: Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int categoryId, [Bind("Id,Type,CategoryId,Info")] Types types)
        {
            types.CategoryId = categoryId;
            if (ModelState.IsValid)
            {
                _context.Add(types);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Types", new { id = categoryId, category = _context.Categories.Where(c => c.Id == categoryId).FirstOrDefault().Category });
            }

            return RedirectToAction("Index", "Types", new { id = categoryId, category = _context.Categories.Where(c => c.Id == categoryId).FirstOrDefault().Category });
        }

        // GET: Types/Edit/5
        [Authorize(Roles = "admin,broker")]
        public async Task<IActionResult> Edit(int? categoryId, int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var types = await _context.Types.FindAsync(id);
            if (types == null)
            {
                return NotFound();
            }
            ViewBag.CategoryId = categoryId;
            ViewBag.CategoryName = _context.Categories.Find(categoryId).Category;
            return View(types);
        }

        // POST: Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int categoryId, int id, [Bind("Id,Type,CategoryId,Info")] Types types)
        {
            if (id != types.Id)
            {
                return NotFound();
            }
            types.CategoryId = categoryId;
            ViewBag.CategoryName = _context.Categories.Find(categoryId).Category;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(types);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypesExists(types.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Index", "Types", new { id = categoryId, category = _context.Categories.Where(d => d.Id == categoryId).FirstOrDefault().Category });
            }


            return RedirectToAction("Index", "Types", new { id = categoryId, category = _context.Categories.Where(d => d.Id == categoryId).FirstOrDefault().Category });

        }

        // GET: Types/Delete/5
       [Authorize(Roles = "admin,broker")]
        public async Task<IActionResult> Delete(int? categoryId, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.CategoryId = categoryId;
            ViewBag.CategoryName = _context.Categories.Find(categoryId).Category;
            ViewBag.TypeName = _context.Types.Find(id).Type;
            var types = await _context.Types
                .Include(t => t.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (types == null)
            {
                return NotFound();
            }

            return View(types);
        }

        // POST: Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int categoryId, int id)
        {
            ViewBag.CategoryId = categoryId;
            var types = await _context.Types.FindAsync(id);
            var docs = _context.Documents.Where(b => b.TypeId == id).ToList();
            foreach (var doc in docs)
            {
                _context.Documents.Remove(doc);
            }
            _context.Types.Remove(types);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Types", new { id = categoryId, category = _context.Categories.Where(d => d.Id == categoryId).FirstOrDefault().Category });
        }
        public async Task<IActionResult> TypesDocuments(int? id, string type)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ClientId = id;
            ViewBag.ClientId = id;

            return RedirectToAction("Index", "Documents", new { typeId = id, typeName = type });
        }
        public IActionResult TypeValid(string Type, int? Id)
        {
            if (Type.Length < 2) return Json(data: "Назва типу занадто коротка");
            var type = _context.Types.Where(b => b.Type == Type).Where(b => b.Id != Id);
            if (type.Count() > 0)
            {
                return Json(data: "Така послуга вже є в базі");
            }
            return Json(data: true);
        }
        private bool TypesExists(int id)
        {
            return _context.Types.Any(e => e.Id == id);
        }
        // GET: Types/Brokers/5
        public async Task<IActionResult> Brokers(int? categoryId, string category)
        {
            if (categoryId == null)
            {
                return NotFound();
            }
            ViewBag.CategoryId = categoryId;


            return RedirectToAction("Index", "BrokersCategories", new { id = categoryId });
        }
    }
}
