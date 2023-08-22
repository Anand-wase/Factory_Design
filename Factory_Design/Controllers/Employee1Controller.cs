using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Factory_Design.Data;
using Factory_Design.Models;

namespace Simple_Factory_Pattern.Models.Controllers
{
    public class Employee1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Employee1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Employees.Include(e => e.EmployeeType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Employee1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.EmployeeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee1/Create
        public IActionResult Create()
        {
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeTypes, "Id", "Employee_Type");
            return View();
        }

        // POST: Employee1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,JobDescription,Number,Department,HourlyPay,Bonus,HouseAllowance,MedicalAllowance,ComputerDetails,EmployeeTypeId")] Employee employee)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeTypes, "Id", "Id", employee.EmployeeTypeId);
            return View(employee);
        }

        // GET: Employee1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeTypes, "Id", "Employee_Type");
            return View(employee);
        }

        // POST: Employee1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,JobDescription,Number,Department,HourlyPay,Bonus,HouseAllowance,MedicalAllowance,ComputerDetails,EmployeeTypeId")] Employee model)
        {
            _context.Employees.Update(model);
            _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Employee1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.EmployeeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employees == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Employees'  is null.");
            }
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
          return (_context.Employees?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
