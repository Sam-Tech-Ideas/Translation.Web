using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Translation.Web.Models.Entities;


namespace Translation.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        DbSet<TranslationRequest> TranslationRequests {get; set;}

        DbSet<TranslationResult> TranslationResults {get; set;}



    }
}
