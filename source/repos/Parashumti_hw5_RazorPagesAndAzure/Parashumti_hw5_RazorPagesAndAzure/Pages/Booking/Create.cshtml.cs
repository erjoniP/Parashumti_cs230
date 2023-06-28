using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parashumti_hw5_RazorPagesAndAzure.Data;
using Parashumti_hw5_RazorPagesAndAzure.Models;

namespace Parashumti_hw5_RazorPagesAndAzure.Pages.Booking
{
    public class CreateModel : PageModel
    {
        private readonly Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext _context;

        public CreateModel(Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PersonModel PersonModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.PersonModel == null || PersonModel == null)
            {
                return Page();
            }

            _context.PersonModel.Add(PersonModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
