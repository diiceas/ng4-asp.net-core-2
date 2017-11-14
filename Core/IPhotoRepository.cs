using System.Collections.Generic;
using System.Threading.Tasks;
using ng4_asp.net_core_2.Core.Models;

namespace ng4_asp.net_core_2.Core
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}