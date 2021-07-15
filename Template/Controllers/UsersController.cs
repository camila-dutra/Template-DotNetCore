using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Template.Infrastructure.Auth;
using Template.Service.DTOs;
using Template.Service.Interfaces;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService) //Dependency Injection
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.userService.Get());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(UserDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(this.userService.Post(user));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(this.userService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(UserDTO user)
        {
            return Ok(this.userService.Put(user));
        }

        [HttpDelete]
        public IActionResult Put(string id)
        {
            // caso nao queira fazer a autenticação:
            //[HttpDelete("{id}")] passar o id pela url
            //return Ok(this.userService.Delete(id));


            //para passar o id da autenticação ao inves do id da url, exemplo para poder deletar os pedidos só dele
            string userId = TokenService.GetValueFromClaim(HttpContext.User.Identity, ClaimTypes.NameIdentifier);

            return Ok(this.userService.Delete(userId));
        }

        [HttpPost("authenticate"), AllowAnonymous]
        public IActionResult Authenticate(UserAuthenticateRequestDTO user)
        {
            return Ok(this.userService.Authenticate(user));
        }
    }
}
