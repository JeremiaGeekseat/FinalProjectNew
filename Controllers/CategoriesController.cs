using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.DomainRepository;
using FinalProject.DomainData;

namespace FinalProject.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _repository;

        public CategoriesController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Category>> GetCategories()
        {
            return await _repository.GetAll();
        }
    }
}