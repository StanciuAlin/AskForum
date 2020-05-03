using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationLogic.DataModel;
using DataAccess;

namespace AskForum.Controllers
{
    public class ContactMesController : Controller
    {
        private readonly AskForumDbContext _context;

        public ContactMesController(AskForumDbContext context)
        {
            _context = context;
        }

        // GET: ContactMes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactMes.ToListAsync());
        }

        // GET: ContactMes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMe = await _context.ContactMes
                .FirstOrDefaultAsync(m => m.ContactMeId == id);
            if (contactMe == null)
            {
                return NotFound();
            }

            return View(contactMe);
        }

        // GET: ContactMes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactMes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactMeId,Name,Email,MessageContent,Date")] ContactMe contactMe)
        {
            if (ModelState.IsValid)
            {
                contactMe.ContactMeId = Guid.NewGuid();
                _context.Add(contactMe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactMe);
        }

        // GET: ContactMes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMe = await _context.ContactMes.FindAsync(id);
            if (contactMe == null)
            {
                return NotFound();
            }
            return View(contactMe);
        }

        // POST: ContactMes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ContactMeId,Name,Email,MessageContent,Date")] ContactMe contactMe)
        {
            if (id != contactMe.ContactMeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactMe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactMeExists(contactMe.ContactMeId))
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
            return View(contactMe);
        }

        // GET: ContactMes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMe = await _context.ContactMes
                .FirstOrDefaultAsync(m => m.ContactMeId == id);
            if (contactMe == null)
            {
                return NotFound();
            }

            return View(contactMe);
        }

        // POST: ContactMes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contactMe = await _context.ContactMes.FindAsync(id);
            _context.ContactMes.Remove(contactMe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactMeExists(Guid id)
        {
            return _context.ContactMes.Any(e => e.ContactMeId == id);
        }
    }
}
