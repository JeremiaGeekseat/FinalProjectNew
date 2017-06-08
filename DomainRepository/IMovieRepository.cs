using FinalProject.DomainData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DomainRepository
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<Rate> GetRate(int id);
        Task<Category> GetMovieCategory(int id);
    }
}
