using FinalProject.DomainData;
using FinalProject.DomainRepository;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public interface IFavoriteService : IRepository<Favorite>
    {
    }
}
