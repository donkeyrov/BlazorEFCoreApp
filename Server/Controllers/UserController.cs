using BlazorEFCoreApp.Server.Repository;
using BlazorEFCoreApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorEFCoreApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            UserRepository repo = new UserRepository();
            return repo.GetUsers().ToArray();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            UserRepository repo = new UserRepository();
            return repo.GetUser(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            UserRepository repo = new UserRepository();
            repo.addUser(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            UserRepository repo = new UserRepository();
            repo.addUser(user);

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
