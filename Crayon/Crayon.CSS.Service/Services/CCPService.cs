using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Application.Services;
using Crayon.CSS.Domain.Models;
using Microsoft.Identity.Client;

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
                Description = "Cloud service for collaborating on code development and deploying applications.",
                Quantity = 10
            },
            new SoftwareService
            {
                Id = Guid.NewGuid(),
                Name = "Microsoft Teams",
                Description = "Collaboration platform that combines chat, video meetings, file storage, and application integration.",
                Quantity = 10
            },
            new SoftwareService
            {
                Id = Guid.NewGuid(),
                Name = "Microsoft Visual Studio",
                Description = "Integrated development environment (IDE) for building applications, websites, and services.",
                Quantity = 400
            }
        };
        return services;
    }

    public bool IsAvailable(string name, int quantity)
    {
        var service = GetAvailableService();

        var selectedService = service.FirstOrDefault(s => s.Name.Equals(name));

        if (selectedService == null)
        {
            throw new NotFoundException("ccp/is-available", $"Software with name={name} was not found");
        }

        if(selectedService.Quantity > quantity)
        {
            return true;
        }

        return false;
    }
}
