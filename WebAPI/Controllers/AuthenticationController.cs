using Chillhop_Store.Models.Models;
using ChillhopStore.API.Public_API;
using ChillhopStore.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChillhopStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepository _userRepository; 

        public AuthenticationController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public ActionResult Post([FromBody] AuthenticationRequest request)
        {
            if (_userRepository.UserAuthentication(request))
            {
               return Ok("You have Succefully Loggen In!");
            }

              return  NotFound(StatusCode(401, "You Shall Not Pass!"));
            
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
