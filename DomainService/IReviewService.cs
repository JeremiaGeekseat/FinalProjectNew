using FinalProject.DomainData;
using FinalProject.DomainRepository;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    public interface IReviewService : IRepository<Review>
    {
    }
}
