using System.Threading.Tasks;

namespace ng4_asp.net_core_2.Core
{

    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}