using Crayon.CSS.Domain.Enums;

namespace Crayon.CSS.Application.DtoModels;

public record SoftwareLicenseModel
{
    public Guid Id { get; init; }
    public Guid AccountId { get; init; }
    public required string AccountName { get; init; }
    public int Quantity { get; init; }
    public string SoftwareName { get; init; }
    public DateTime ExpirationDate { get; init; }
    public LicensesState State { get; init; }
}
