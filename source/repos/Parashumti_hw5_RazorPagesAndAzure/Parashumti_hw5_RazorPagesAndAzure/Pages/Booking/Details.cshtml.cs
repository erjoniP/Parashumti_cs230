using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Parashumti_hw5_RazorPagesAndAzure.Data;
using Parashumti_hw5_RazorPagesAndAzure.Models;

namespace Parashumti_hw5_RazorPagesAndAzure.Pages.Booking
{
    public class DetailsModel : PageModel
    {
        private readonly Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext _context;

        public DetailsModel(Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext context)
        {
            _context = context;
        }

      public PersonModel PersonModel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PersonModel == null)
            {
                return NotFound();
            }

            var personmodel = await _context.PersonModel.FirstOrDefaultAsync(m => m.ID == id);
            if (personmodel == null)
            {
                return NotFound();
            }
            else 
            {
                PersonModel = personmodel;
            }
            return Page();
        }
    }
}
