using BlueNet.Api.Data;
using BlueNet.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlueNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViolationController : ControllerBase
    {
        public IConfiguration _configuration;
        public BlueNetDbContext _blueNetContext;

        public ViolationController(IConfiguration configuration, BlueNetDbContext blueNetContext)
        {
            _configuration = configuration;
            _blueNetContext = blueNetContext;
        }


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
        public async Task<bool> SaveViolation([FromBody] Violation data)
        {
            _blueNetContext.Violation.Add(data);
            await _blueNetContext.SaveChangesAsync();
            return true;
        }
    }
}
