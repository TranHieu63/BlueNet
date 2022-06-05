using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;


namespace BlueNet.Manager.Pages
{
    public partial class UserDetails
    {
        [Parameter]
        public string userId { get; set; }

        [Inject] private IUserApiClient _userApiClient { get; set; }

        private UserDto userDto { get; set; }

        protected async override Task OnInitializedAsync()
        {
            userDto = await _userApiClient.GetUserDetail(userId);
        }
    }
}
