using FinalProject.DomainData;
using FinalProject.DomainRepository;
using System.Threading.Tasks;

namespace FinalProject.DomainService
{
    interface IContactService : IRepository<Contact>
    {
    }
}
