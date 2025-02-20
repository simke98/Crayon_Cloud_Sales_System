using Crayon.CSS.Domain.Common;

namespace Crayon.CSS.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<Account>? Accounts { get; set; }  
    }
}
