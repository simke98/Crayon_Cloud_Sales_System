using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Domain.Entities;

namespace Crayon.CSS.Persistence.Repositories;

public class SoftwareLicenseRepository : RepositoryBase<SoftwareLicense>, ISoftwareLicenseRepository
{
    public SoftwareLicenseRepository(CSSDBContext context) : base(context) { }
}
