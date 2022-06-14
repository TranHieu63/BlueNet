using BlueNet.Api.Entities;
using BlueNet.Api.Repositoties;
using BlueNet.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Api.Extensions;

namespace BlueNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BlackListController : ControllerBase
    {
        private readonly IBlackListRepository _blackListRepository;
        public BlackListController(IBlackListRepository blackListRepository)
        {
            _blackListRepository = blackListRepository;
        }

        //api/blackLists?url=
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] BlackListSearch blackListSearch)
        {
            var blackLists = await _blackListRepository.GetBlackList(blackListSearch);
            var blackListDtos = blackLists.Select(x => new BlackListDto()
            {
                BlackListId = x.BlackListId,
                Url = x.Url,
                UserId = x.UserId,
                CreatedDate = x.CreatedDate
            });
            return Ok(blackListDtos);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var blackLists = await _blackListRepository.GetById(id);

            if (blackLists == null)
            {
                return NotFound($"{id} is not found");
            }
            return Ok(new BlackListDto()
            {
                Url = blackLists.Url,
                UserId = blackLists.UserId,
                CreatedDate = blackLists.CreatedDate
            });
        }

        [HttpGet("me")]
        public async Task<IActionResult> GetByUserId([FromQuery] BlackListSearch blackListSearch)
        {
            var userId = User.GetUserId();
            var blackLists = await _blackListRepository.GetBlackListByUserId(Guid.Parse(userId), blackListSearch);
            var blackListDtos = blackLists.Select(x => new BlackListDto()
            {
                BlackListId = x.BlackListId,
                Url = x.Url,
                UserId = x.UserId,
                CreatedDate = x.CreatedDate
            });
            return Ok(blackListDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BlackListCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var blackList = await _blackListRepository.Create(new Entities.BlackList()
            {
                BlackListId = request.BlackListId,
                Url = request.Url,
                UserId = request.UserId,
                CreatedDate = DateTime.Now
            }); 
            return CreatedAtAction(nameof(GetById), new { id = blackList.BlackListId }, blackList);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] BlackListUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var blackListFromDb = await _blackListRepository.GetById(id);

            if (blackListFromDb == null)
            {
                return NotFound($"{id} is not found");
            }

            blackListFromDb.Url = request.Url;
            blackListFromDb.UserId = request.UserId;

            var blackListResult = await _blackListRepository.Update(blackListFromDb);

            return Ok(new BlackListDto()
            {
                Url = blackListResult.Url,
                UserId = blackListResult.UserId,
                CreatedDate = blackListResult.CreatedDate
            });
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var blackList = await _blackListRepository.GetById(id);
            if (blackList == null) return NotFound($"{id} is not found");

            await _blackListRepository.Delete(blackList);
            return Ok(new BlackListDto()
            {
                Url = blackList.Url,
                UserId = blackList.UserId,
                CreatedDate = blackList.CreatedDate
            });
        }

        [HttpPost]
        [Route("/CheckUrl")]
        public async Task<IActionResult> CheckUrl([FromBody] CheckUrlParameter checkUrl)
        {
            bool result = await _blackListRepository.CheckUrl(checkUrl);
            return Ok(result);
        }
    }
}
