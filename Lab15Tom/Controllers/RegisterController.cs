using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab15Tom.Models;
using Lab15Tom.ViewModel;

namespace Lab15Tom.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Lab15TomContext _context;

        public RegisterController(Lab15TomContext context)
        {
            _context = context;
        }

        // GET: Register
        public async Task<IActionResult> Index(string classEnrolledin, string searchString)
        {
            IQueryable<string> classQuery = from c in _context.Register
                                            orderby c.ClassEnrolled
                                            select c.ClassEnrolled;



            var students = from s in _context.Register
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(classEnrolledin))
            {
                students = students.Where(c => c.ClassEnrolled == classEnrolledin);
            }

            var ClassEnrolledVm = new ClassEnrolledViewModel();
            ClassEnrolledVm.classes = new SelectList(await classQuery.Distinct().ToListAsync());
            ClassEnrolledVm.students = await students.ToListAsync();

            return View(ClassEnrolledVm);
        }

        // GET: Register/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var register = await _context.Register
                .SingleOrDefaultAsync(m => m.ID == id);
            if (register == null)
            {
                return NotFound();
            }

            return View(register);
        }

        // GET: Register/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Age,Quirk,Gender,Alias,HairColor,ClassEnrolled")] Register register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(register);
        }

        // GET: Register/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var register = await _context.Register.SingleOrDefaultAsync(m => m.ID == id);
            if (register == null)
            {
                return NotFound();
            }
            return View(register);
        }

        // POST: Register/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Age,Quirk,Gender,Alias,HairColor,ClassEnrolled")] Register register)
        {
            if (id != register.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(register);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisterExists(register.ID))
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
            return View(register);
        }

        // GET: Register/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var register = await _context.Register
                .SingleOrDefaultAsync(m => m.ID == id);
            if (register == null)
            {
                return NotFound();
            }

            return View(register);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var register = await _context.Register.SingleOrDefaultAsync(m => m.ID == id);
            _context.Register.Remove(register);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisterExists(int id)
        {
            return _context.Register.Any(e => e.ID == id);
        }
    }
}
