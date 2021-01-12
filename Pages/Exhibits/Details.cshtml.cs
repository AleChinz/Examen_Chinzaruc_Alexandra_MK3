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
    public class DetailsModel : PageModel
    {
        private readonly Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context _context;

        public DetailsModel(Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context context)
        {
            _context = context;
        }

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
    }
}
