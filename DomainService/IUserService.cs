using FinalProject.DomainData;
using FinalProject.DomainRepository;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    interface IUserService : IRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
