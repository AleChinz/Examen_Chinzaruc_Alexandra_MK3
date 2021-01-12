using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen_Chinzaruc_Alexandra_MK3.Data;
using Examen_Chinzaruc_Alexandra_MK3.Models;

namespace Examen_Chinzaruc_Alexandra_MK3.Pages.Exhibits
{
    public class DeleteModel : PageModel
    {
        private readonly Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context _context;

        public DeleteModel(Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exhibit = await _context.Exhibit.FindAsync(id);

            if (Exhibit != null)
            {
                _context.Exhibit.Remove(Exhibit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
