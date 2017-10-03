using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab15Deployment.Models;
using Lab15Deployment.ViewModel;

namespace Lab15Deployment.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Lab15DeploymentContext _context;

        public RegisterController(Lab15DeploymentContext context)
        {
            _context = context;
        }

        // GET: Register
        public async Task<IActionResult> Index(string mutantClass, string searchString)
        {
            IQueryable<string> genreQuery = from m in _context.StudentModel
                                            orderby m.PowerClass
                                            select m.PowerClass;

            var students = from m in _context.StudentModel
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(m => m.Alias.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(mutantClass))
            {
                students = students.Where(g => g.PowerClass == mutantClass);
            }

            var PowerClassVm = new PowerClassViewModel();
            PowerClassVm.powerClasses = new SelectList(await genreQuery.Distinct().ToListAsync());
            PowerClassVm.mutants = await students.ToListAsync();

            return View(PowerClassVm);
        }

        // GET: Register/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.StudentModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
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
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Age,Alias,Mutation,Gender,PowerClass")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: Register/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.StudentModel.SingleOrDefaultAsync(m => m.ID == id);
            if (studentModel == null)
            {
                return NotFound();
            }
            return View(studentModel);
        }

        // POST: Register/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Age,Alias,Mutation,Gender,PowerClass")] StudentModel studentModel)
        {
            if (id != studentModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentModelExists(studentModel.ID))
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
            return View(studentModel);
        }

        // GET: Register/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.StudentModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentModel = await _context.StudentModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.StudentModel.Remove(studentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentModelExists(int id)
        {
            return _context.StudentModel.Any(e => e.ID == id);
        }
    }
}
