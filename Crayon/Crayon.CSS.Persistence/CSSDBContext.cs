using Crayon.CSS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Persistence
{
    public class CSSDBContext : DbContext
    {
        public CSSDBContext(DbContextOptions<CSSDBContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
