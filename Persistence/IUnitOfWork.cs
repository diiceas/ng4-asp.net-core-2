using System.Threading.Tasks;

namespace ng4_asp.net_core_2.Persistence
{

    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}