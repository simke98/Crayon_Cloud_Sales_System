using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Models;

namespace Crayon.CSS.Service.Services;

public class CCPService : ICCPService
{
    public ICollection<SoftwareService> GetAvailableService()
    {
        var services = new List<SoftwareService>
        {
            new SoftwareService
            {
                Id = Guid.NewGuid(),
                Name = "Azure DevOps",
                Description = "Cloud service for collaborating on code development and deploying applications."
            },
            new SoftwareService
            {
                Id = Guid.NewGuid(),
                Name = "Microsoft Teams",
                Description = "Collaboration platform that combines chat, video meetings, file storage, and application integration."
            },
            new SoftwareService
            {
                Id = Guid.NewGuid(),
                Name = "Microsoft Visual Studio",
                Description = "Integrated development environment (IDE) for building applications, websites, and services."
            }
        };
        return services;
    }

}
