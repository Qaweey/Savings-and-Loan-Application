using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SavingandLoanProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CustomersProfile> CostumersProfiles { get; set; }
        public DbSet<SavingsProfile> SavingsProfiles { get; set; }
        public DbSet<LoansProfile> loanProfiles { get; set; }
        public DbSet<SavingsPlan> SavingsPlans { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
