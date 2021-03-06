﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Examen_Chinzaruc_Alexandra_MK3.Data;
using Examen_Chinzaruc_Alexandra_MK3.Models;

namespace Examen_Chinzaruc_Alexandra_MK3.Pages.Exhibits
{
    public class CreateModel : PageModel
    {
        private readonly Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context _context;

        public CreateModel(Examen_Chinzaruc_Alexandra_MK3.Data.Examen_Chinzaruc_Alexandra_MK3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Exhibit Exhibit { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Exhibit.Add(Exhibit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
