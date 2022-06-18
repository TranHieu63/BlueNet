using Blazored.Toast.Services;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class UserCreate
    {
        [Inject] private IUserApiClient UserApiClient { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private IToastService ToastService { get; set; }

        private UserCreateRequest UserRequestCreate = new UserCreateRequest();

        private List<RoleDto> _ListRoleDto = new List<RoleDto>();

        private async Task SubmitCreateUser(EditContext context)
        {
            var result = await UserApiClient.CreateUser(UserRequestCreate);
            if (result)
            {
                ToastService.ShowSuccess($"{UserRequestCreate.UserName} has been created successfully.", "Success");
                NavigationManager.NavigateTo("/users");
            }
            else
            {
                ToastService.ShowError($"An error occurred in progress. Please contact to administrator.", "Error");
            }
        }

        protected async override Task OnInitializedAsync()
        {
            //Lấy danh sách role dựa vào userApiClient
            _ListRoleDto = await UserApiClient.GetRole();
            
        }
    }
}
