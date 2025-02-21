using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.CSS.Application.DtoModels
{
    public record CustomerModel
    {
        public Guid Id { get; init; }
        public required string Name { get; init; }
    }
}
