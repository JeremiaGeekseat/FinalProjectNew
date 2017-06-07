using FinalProject.DomainData;
using FinalProject.DomainRepository;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public interface IMovieService : IRepository<Movie>
    {
    }
}
