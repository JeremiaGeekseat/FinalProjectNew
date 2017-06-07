using Microsoft.AspNetCore.Mvc;
using FinalProject.DomainRepository;
using FinalProject.DomainData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    //[Route("api/movie")]
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _repository;

        public MoviesController(IMovieRepository repository)
        {
            _repository = repository;
        }

        // GET: Movies
        [HttpGet]
        public async Task<List<Movie>> GetMovies()
        {
            return await _repository.GetAll();
        }

        // GET: Movie Rate
        [HttpGet]
        public async Task<Rate> GetMovieRate(int id)
        {
            return await _repository.GetRate(id);
        }
    }
}