using Crayon.CSS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.CSS.Application.Services
{
    public interface ICCPService
    {

        ICollection<SoftwareService> GetAvailableService();
    }
}
