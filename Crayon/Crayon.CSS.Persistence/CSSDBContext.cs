using Crayon.CSS.Domain.Entities;
using Crayon.CSS.Persistence.DbModelBuilder;
using Crayon.CSS.Persistence.TestData;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Persistence
{
    public class CSSDBContext : DbContext
    {
        public CSSDBContext(DbContextOptions<CSSDBContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SoftwareLicense> SoftwareLicenses { get; set; }
        public DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CssModelBuilder.ConfigureSoftwareLicense(modelBuilder);
            CssModelBuilder.ConfigureCustomer(modelBuilder);
            CssModelBuilder.ConfigureAccount(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(AddTestData.GetCustomer());
            modelBuilder.Entity<Account>().HasData(AddTestData.GetAccounts());
            modelBuilder.Entity<SoftwareLicense>().HasData(AddTestData.GetSoftwareLicenses());

        }
    }
}
