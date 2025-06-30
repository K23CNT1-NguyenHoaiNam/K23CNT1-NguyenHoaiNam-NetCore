using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenHoaiNam_2310900073.Models;

namespace NguyenHoaiNam_2310900073.Controllers
{
    public class NhnEmployeesController : Controller
    {
        private readonly NguyenHoaiNam2310900073Context _context;

        public NhnEmployeesController(NguyenHoaiNam2310900073Context context)
        {
            _context = context;
        }

        // GET: NhnEmployees
        public async Task<IActionResult> NhnIndex()
        {
            return View(await _context.NhnEmployees.ToListAsync());
        }

        // GET: NhnEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhnEmployee = await _context.NhnEmployees
                .FirstOrDefaultAsync(m => m.NhnEmpId == id);
            if (nhnEmployee == null)
            {
                return NotFound();
            }

            return View(nhnEmployee);
        }

        // GET: NhnEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhnEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NhnEmpId,NhnEmpName,NhnEmpLevel,NhnEmpStartDate,NhnEmpStatus")] NhnEmployee nhnEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhnEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhnEmployee);
        }

        // GET: NhnEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhnEmployee = await _context.NhnEmployees.FindAsync(id);
            if (nhnEmployee == null)
            {
                return NotFound();
            }
            return View(nhnEmployee);
        }

        // POST: NhnEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NhnEmpId,NhnEmpName,NhnEmpLevel,NhnEmpStartDate,NhnEmpStatus")] NhnEmployee nhnEmployee)
        {
            if (id != nhnEmployee.NhnEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhnEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhnEmployeeExists(nhnEmployee.NhnEmpId))
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
            return View(nhnEmployee);
        }

        // GET: NhnEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhnEmployee = await _context.NhnEmployees
                .FirstOrDefaultAsync(m => m.NhnEmpId == id);
            if (nhnEmployee == null)
            {
                return NotFound();
            }

            return View(nhnEmployee);
        }

        // POST: NhnEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhnEmployee = await _context.NhnEmployees.FindAsync(id);
            if (nhnEmployee != null)
            {
                _context.NhnEmployees.Remove(nhnEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhnEmployeeExists(int id)
        {
            return _context.NhnEmployees.Any(e => e.NhnEmpId == id);
        }
    }
}
