using FinalProject.DomainData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
