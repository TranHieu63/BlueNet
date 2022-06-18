using BlueNet.Api.Data;
using BlueNet.Api.Entities;
using BlueNet.Api.Repositoties;
using BlueNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlueNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViolationController : Controller
    {
        private readonly IViolationRepository _violationRepository;

        private readonly BlueNetDbContext _context;

        // private readonly BlueNetDbContext _context;
        public ViolationController(IViolationRepository violationRepository, BlueNetDbContext context)
        {
            _violationRepository = violationRepository;
            _context = context;
        }

        /// <summary>
        /// Get All Violation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllViolation()
        {
            var violations = await _violationRepository.GetViolationList();

            var violationDtos = violations.Select(x => new ViolationParameter()
            {
               ViolationId = x.ViolationId,
               Url = x.Url,
               ComputerName = x.ComputerName,
               HandwareId = x.HandwareId,
               IpLocal = x.IpLocal,
               UserId = x.UserId,
               TimeStamp = x.TimeStamp
            });

            return Ok(violationDtos);
        }

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> GetById([FromRoute] Guid id)
        //{
        //    var violations = await _violationRepository.GetById(id);

        //    if (violations == null)
        //    {
        //        return NotFound($"{id} is not found");
        //    }
        //    return Ok(new ViolationParameter()
        //    {
        //        Url = violations.Url,
        //        ComputerName = violations.ComputerName,
        //        HandwareId = violations.HandwareId,
        //        TimeStamp = violations.TimeStamp,
        //        IpLocal = violations.IpLocal,
        //        UserId = violations.UserId
        //    });
        //}



        //API Client đẩy lên phát hiện url vi phạm


        /// <summary>
        /// đầu vào object violation (Hàm api cần lưu thông tin đó vào database bảng violation)
        /// Trả về true/false tức là lưu thành công hoặc không thành công
        /// 
        /// các thông tin Client gửi lên (ViolationId, url, ComputerName, timestamp,handwareId,Iplocal, userId )
        /// </summary>
        /// <param name="violation"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("SaveViolation")]
        public async Task<bool> SaveViolation([FromBody] Violation violation)
        {
            await _context.Violations.AddAsync(violation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
