using Crayon.CSS.Domain.Models;

namespace Crayon.CSS.Application.Services;

public interface ICCPService
{
    ICollection<SoftwareService> GetAvailableService();
    bool IsAvailable(string name, int quantity);
}
