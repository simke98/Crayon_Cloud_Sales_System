namespace Crayon.CSS.Application.DtoModels;

public record SoftwareLicenseCreate
{
    public string SoftwareName { get; init; }
    public int Quantity { get; init; }
    public DateTime ExpirationDate { get; set; }
}
