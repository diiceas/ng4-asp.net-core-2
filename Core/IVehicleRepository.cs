using System.Collections.Generic;
using System.Threading.Tasks;
using ng4_asp.net_core_2.Core.Models;
using vega.Core.Models;

namespace vega.Core
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
         void Add(Vehicle vehicle);
         void Remove(Vehicle vehicle);
         Task<IEnumerable<Vehicle>> GetVehicles(Filter filter);
    }
}