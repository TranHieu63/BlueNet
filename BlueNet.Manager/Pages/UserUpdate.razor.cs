using Blazored.Toast.Services;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class UserUpdate
    {
        [Inject] private IUserApiClient UserApiClient { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private IToastService ToastService { get; set; }

        [Parameter]
        public string userId { get; set; }

        private UserUpdateRequest userUpdateRequest;

        protected async override Task OnInitializedAsync()
        {
            var userDto = await UserApiClient.GetUserDetail(userId);

            userUpdateRequest = new UserUpdateRequest();
            userUpdateRequest.UserName = userDto.UserName;
            userUpdateRequest.Email = userDto.Email;
        }


        private async Task SubmitUpdateUser(EditContext context)
        {
            var result = await UserApiClient.UpdateUser(Guid.Parse(userId), userUpdateRequest);
            if (result)
            {
                ToastService.ShowSuccess($"{userUpdateRequest.UserName} has been update successfully.", "Success");
                NavigationManager.NavigateTo("/users");
            }
            else
            {
                ToastService.ShowError($"An error occurred in progress. Please contact to administrator.", "Error");
            }
        }
    }
}
