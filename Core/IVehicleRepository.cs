using System.Threading.Tasks;
using ng4_asp.net_core_2.Models;

namespace ng4_asp.net_core_2.Core
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
         void Add(Vehicle vehicle);
         void Remove(Vehicle vehicle);
    }
}