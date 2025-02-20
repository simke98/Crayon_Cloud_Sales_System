using Crayon.CSS.Domain.Common;

namespace Crayon.CSS.Domain.Entities;

public class Account : BaseEntity
{
    public required string Name { get; set; }
    public required Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    public ICollection<SoftwareLicense>? SoftwareLicenses { get; set; }
}
