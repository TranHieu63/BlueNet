using BlueNet.Api.Entities;  
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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userListRepository;
        public UserController(IUserRepository userRepository)
        {
            _userListRepository = userRepository;
        }

        /// <summary>
        /// Get All User
        /// </summary>
        /// <returns></returns>
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
            }).ToList();

            //Lấy ra userRole
            var userRoles = await _userListRepository.GetUserRole();
            var UserRoleDtos = userRoles.Select(x => new UserRole()
            {
                UserId = x.UserId,
                RoleId = x.RoleId
            }).ToList();
           
            //lấy ra role
            var roles = await _userListRepository.GetRole();
            var roleDtos = roles.Select(x => new Role()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                NormalizedName = x.NormalizedName,
                ConcurrencyStamp = x.ConcurrencyStamp
            }).ToList();

            //Duyệt danh sách userDtos, userRole, để gán giá trị RoleId cho các phần tử trong danh sách userDtos
            for (int i = 0; i < userDtos.Count; i++)
            {
                //lấy ra phân tử thứ i 
                var x = userDtos[i];

                //Lấy ra Id của phần tử thứ i
                var userId = x.Id;

                //tìm trong danh sách userRole xem dòng nào có userId = id của x
                //thi lấy ra dòng đấy
                for (int j = 0; j < userRoles.Count; j++)
                {
                    var y = userRoles[j];

                    var userRoleId = y.UserId;
                    if(userId == userRoleId)
                    {
                        x.RoleId = y.RoleId;

                        for (int k = 0; k < roles.Count; k++)
                        {
                            var z = roles[k];
                            var roleId = z.Id;
                            if(roleId == x.RoleId)
                            {
                                x.RoleName = z.Name;
                            }
                        }
                    }
                }
            }

            return Ok(userDtos);
        }

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
               FullName = users.FirstName + " " + users.LastName,
            });
        }

        /// <summary>
        /// Get By UserName
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UserName/{userName}")]
        public async Task<IActionResult> GetByUserName([FromRoute] string userName)
        {
            var user = await _userListRepository.GetByUserName(userName);

            if (user == null)
            {
                return NotFound($"{userName} is not found");
            }

            var x = new UserDto()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
            };


            //lấy userRole
            var userRoles = await _userListRepository.GetUserRole();
            var UserRoleDtos = userRoles.Select(x => new UserRole()
            {
                UserId = x.UserId,
                RoleId = x.RoleId
            }).ToList();

            //lấy role
            var roles = await _userListRepository.GetRole();
            var roleDtos = roles.Select(x => new Role()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                NormalizedName = x.NormalizedName,
                ConcurrencyStamp = x.ConcurrencyStamp
            }).ToList();

            for (int i = 0; i < userRoles.Count; i++)
            {
                var y = userRoles[i];
                var userId = y.UserId;
                if(userId == x.Id)
                {
                    x.RoleId = y.RoleId;

                    for (int j = 0; j < roles.Count; j++)
                    {
                        var z = roles[j];
                        //var roleId = z.Id;
                        if(z.Id == x.RoleId)
                        {
                            x.RoleName = z.Name;
                        }
                    }

                }
            }
            
            return Ok(x);
        }

        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(UserCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //Thêm user
            var user = await _userListRepository.Create(new Entities.User()
            {
               Id = Guid.NewGuid(),
               FirstName = request.FirstName,
               LastName = request.LastName,
               UserName = request.UserName,
               NormalizedUserName = request.NormalizedUserName,
               Email = request.Email,
               NormalizedEmail = request.NormalizedEmail,
               SecurityStamp = request.SecurityStamp,
               PasswordHash = request.Password
            });


            //Thêm phân quyền
            int result = await _userListRepository.CreateUserRole(new Entities.UserRole()
            {
                RoleId = request.RoleId,
                UserId= user.Id
            });

            if (result != 1)
            {
                //Delete user
                await _userListRepository.Delete(user);

            }

            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userFromDb = await _userListRepository.GetById(id);

            if (userFromDb == null)
            {
                return NotFound($"{id} is not found");
            }

            userFromDb.UserName = request.UserName;
            userFromDb.Email = request.Email;

            var userResult = await _userListRepository.Update(userFromDb);

            return Ok(new UserDto()
            {
                UserName = userResult.UserName,
                Email = userResult.Email,

            });
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get role
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("role")]
        public async Task<IActionResult> GetRole()
        {
            var roles = await _userListRepository.GetRole();
            var roleDtos = roles.Select(x => new Role()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                NormalizedName = x.NormalizedName,
                ConcurrencyStamp = x.ConcurrencyStamp
            });
            return Ok(roleDtos);
        }

        /// <summary>
        /// Get user role
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("userRole")]
        public async Task<IActionResult> GetUserRole()
        {
            var userRoles = await _userListRepository.GetUserRole();
            var UserRoleDtos = userRoles.Select(x => new UserRole()
            {
                UserId = x.UserId,
                RoleId = x.RoleId
            });
            return Ok(UserRoleDtos);
        }

    }
}
