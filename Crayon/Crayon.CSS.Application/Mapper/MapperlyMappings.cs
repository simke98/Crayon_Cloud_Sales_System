using Crayon.CSS.Application.DtoModels;
using Crayon.CSS.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace Crayon.CSS.Application.Mapper;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
public static partial class MapperlyMappings
{
    public static partial CustomerModel ToDtoModel(this Customer source);
}
