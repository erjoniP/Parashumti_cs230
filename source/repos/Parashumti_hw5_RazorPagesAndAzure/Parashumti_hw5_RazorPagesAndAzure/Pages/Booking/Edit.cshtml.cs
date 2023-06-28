using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parashumti_hw5_RazorPagesAndAzure.Data;
using Parashumti_hw5_RazorPagesAndAzure.Models;

namespace Parashumti_hw5_RazorPagesAndAzure.Pages.Booking
{
    public class EditModel : PageModel
    {
        private readonly Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext _context;

        public EditModel(Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PersonModel PersonModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PersonModel == null)
            {
                return NotFound();
            }

            var personmodel =  await _context.PersonModel.FirstOrDefaultAsync(m => m.ID == id);
            if (personmodel == null)
            {
                return NotFound();
            }
            PersonModel = personmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PersonModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonModelExists(PersonModel.ID))
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

        private bool PersonModelExists(int id)
        {
          return (_context.PersonModel?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
