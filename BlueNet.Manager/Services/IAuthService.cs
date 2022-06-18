using BlueNet.Models;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);

        Task Logout();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 2022.06.14: tthieu
        /// 2022.06.15: bổ sung cái gì đó
        Task<UserDto> GetCurrentLoginUser();
    }
}
