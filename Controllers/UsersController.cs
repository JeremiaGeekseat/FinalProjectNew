using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.DomainData;
using FinalProject.DomainRepository;

namespace FinalProject.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<User> Register([FromBody] User user)
        {
            return await _repository.Insert(user);
        }
    }
}