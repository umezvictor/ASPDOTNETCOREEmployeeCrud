using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCOREEMPLOYEECRUD.Models;

namespace EFCOREEMPLOYEECRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;

        // constructor
        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

       

        // GET: Employee/AddOrEdit
        // rename the corresponding view to AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            // return view to insert new record if id = 0,
            if(id == 0)
            return View(new Employee());
            // return view to update record if id is not 0
            // will return corresponding employee details 
            else
                return View(_context.Employees.Find(id));

        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("EmployeeId,FullName,EmpCode,Position,OfficeLocation")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                // this method handles inseert and update
                // insert if employeeid = 0, update otherwise
                if(employee.EmployeeId == 0)
                _context.Add(employee);
                //update if not 0
                else
                    _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

     


        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            // find employee with id
            var employee = await _context.Employees.FindAsync(id);
            // remove employee from db
            _context.Employees.Remove(employee);
            // save changes
            await _context.SaveChangesAsync();
            // redirect to index poage
            return RedirectToAction(nameof(Index));
            
        }

        
    }
}
