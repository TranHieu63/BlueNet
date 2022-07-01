using BlueNet.Models;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);

        Task Logout();

      
        Task<UserDto> GetCurrentLoginUser();
    }
}
