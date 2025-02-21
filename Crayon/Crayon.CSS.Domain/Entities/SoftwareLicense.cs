using Crayon.CSS.Domain.Common;
using Crayon.CSS.Domain.Enums;

namespace Crayon.CSS.Domain.Entities;

public class SoftwareLicense : BaseEntity
{
    public required Guid AccountId { get; set; }
    public Account Account { get; set; }
    public int Quantity { get; set; }   
    public string SoftwareName { get; set; }
    public required LicensesState State  { get; set; }
    public DateTime ExpirationDate { get; set; }
}
