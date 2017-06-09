using Microsoft.AspNetCore.Mvc;
using FinalProject.DomainRepository;
using FinalProject.DomainData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _repository;

        public MoviesController(IMovieRepository repository)
        {
            _repository = repository;
        }

        // GET: Movie
        [HttpGet]
        public async Task<Movie> GetMovie(int id)
        {
            return await _repository.Get(id);
        }

        // GET: Movies
        [HttpGet]
        public async Task<List<Movie>> GetMovies()
        {
            return await _repository.GetAll();
        }

        // GET: Movie Category
        [HttpGet]
        public async Task<Category> GetMovieCategory(int id)
        {
            return await _repository.GetMovieCategory(id);
        }

        // GET: Movie Rate
        [HttpGet]
        public async Task<Rate> GetMovieRate(int id)
        {
            return await _repository.GetRate(id);
        }
    }
}