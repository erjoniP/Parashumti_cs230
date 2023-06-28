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
    public class IndexModel : PageModel
    {
        private readonly Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext _context;

        public IndexModel(Parashumti_hw5_RazorPagesAndAzure.Data.Parashumti_hw5_RazorPagesAndAzureContext context)
        {
            _context = context;
        }

        public IList<PersonModel> PersonModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PersonModel != null)
            {
                PersonModel = await _context.PersonModel.ToListAsync();
            }
        }
    }
}
