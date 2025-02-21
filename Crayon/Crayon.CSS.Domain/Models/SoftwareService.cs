namespace Crayon.CSS.Domain.Models;

public class SoftwareService
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int Quantity { get; set; }
}
