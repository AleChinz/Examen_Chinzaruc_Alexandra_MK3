using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Examen_Chinzaruc_Alexandra_MK3.Data;
using Examen_Chinzaruc_Alexandra_MK3.Models;

namespace Examen_Chinzaruc_Alexandra_MK3.Pages.Exhibits
{
    public class EditModel : PageModel
    {
        private readonly Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context _context;

        public EditModel(Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Exhibit Exhibit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exhibit = await _context.Exhibit.FirstOrDefaultAsync(m => m.ID == id);

            if (Exhibit == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Exhibit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExhibitExists(Exhibit.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExhibitExists(int id)
        {
            return _context.Exhibit.Any(e => e.ID == id);
        }
    }
}
