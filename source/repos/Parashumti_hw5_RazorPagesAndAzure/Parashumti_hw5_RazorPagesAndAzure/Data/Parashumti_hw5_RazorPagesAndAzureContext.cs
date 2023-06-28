using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parashumti_hw5_RazorPagesAndAzure.Models;

namespace Parashumti_hw5_RazorPagesAndAzure.Data
{
    public class Parashumti_hw5_RazorPagesAndAzureContext : DbContext
    {
        public Parashumti_hw5_RazorPagesAndAzureContext (DbContextOptions<Parashumti_hw5_RazorPagesAndAzureContext> options)
            : base(options)
        {
        }

        public DbSet<Parashumti_hw5_RazorPagesAndAzure.Models.PersonModel> PersonModel { get; set; } = default!;
    }
}
