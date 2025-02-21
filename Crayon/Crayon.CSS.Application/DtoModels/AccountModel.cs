namespace Crayon.CSS.Application.DtoModels;
public record AccountModel
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    public ICollection<SoftwareLicenseModel> SoftwareLicenses { get; init; }
}
