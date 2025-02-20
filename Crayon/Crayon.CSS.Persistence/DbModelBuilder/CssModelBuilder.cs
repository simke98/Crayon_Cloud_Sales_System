using Crayon.CSS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Persistence.DbModelBuilder
{
    public abstract class CssModelBuilder
    {
        public static void ConfigureSoftwareLicense(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoftwareLicense>().HasKey(sl => sl.Id);
            modelBuilder.Entity<SoftwareLicense>().Property(sl => sl.State).HasConversion<string>();
            modelBuilder.Entity<SoftwareLicense>().HasOne(sl => sl.Account).WithMany(a => a.SoftwareLicenses).HasForeignKey(sl => sl.AccountId);
        }
        public static void ConfigureCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().HasMany(c => c.Accounts).WithOne(a => a.Customer).HasForeignKey(a => a.CustomerId);
        }
        public static void ConfigureAccount(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasKey(a => a.Id); 
            modelBuilder.Entity<Account>().HasMany(a => a.SoftwareLicenses).WithOne(sl => sl.Account).HasForeignKey(sl => sl.AccountId);
        }


    }
}
