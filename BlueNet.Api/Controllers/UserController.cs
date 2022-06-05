using BlueNet.Api.Repositoties;
using BlueNet.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlueNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userListRepository;
        public UserController(IUserRepository userRepository)
        {
            _userListRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userListRepository.GetUserList();
            var userDtos = users.Select(x => new UserDto()
            {
                Id = x.Id,
                UserName = x.UserName,
                FullName = x.FirstName + " " + x.LastName,
                Email = x.Email,
                
            });
            return Ok(userDtos);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var users = await _userListRepository.GetById(id);

            if (users == null)
            {
                return NotFound($"{id} is not found");
            }
            return Ok(new UserDto()
            {
               UserName = users.UserName,
               Email = users.Email,
            });
        }


        [HttpPost]
        public async Task<IActionResult> Create(UserCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userListRepository.Create(new Entities.User()
            {
               FirstName = request.FirstName,
               LastName = request.LastName,
               UserName = request.UserName,
               NormalizedUserName = request.NormalizedUserName,
               Email = request.Email,
               NormalizedEmail = request.NormalizedEmail,
               SecurityStamp = request.SecurityStamp
            });
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var user = await _userListRepository.GetById(id);
            if (user == null) return NotFound($"{id} is not found");

            await _userListRepository.Delete(user);
            return Ok(new UserDto()
            {
                FullName = user.FirstName + " " + user.LastName,
                UserName = user.UserName,
                Email = user.Email
            });
        }
    }
}
