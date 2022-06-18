using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class BlackListCreate
    {
        [Inject] private IBlackListApiClient BlackListApiClient { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private IToastService ToastService { get; set; }
        [Inject] private ILocalStorageService _localStorage { get; set; }

        //[Inject] private IAuthService _AuthService { get; set; }

        //C1
        private string _userId { get; set; }

        //C2
        //private string _userId_2 { get; set; }

        private BlackListCreateRequest BLackListCreate = new BlackListCreateRequest();

        protected async override Task OnInitializedAsync()
        {
            //C1: lay userId tu localStorge
            _userId = await _localStorage.GetItemAsync<string>("UserId");

            //C2: lay userId tu GetCurrentLoginUser
            //var x = await _AuthService.GetCurrentLoginUser();
            //_userId_2 = x.Id.ToString();

        }

        private async Task SubmitCreateBlackList(EditContext context)
        {

            string userId = await _localStorage.GetItemAsync<string>("UserId");

            BLackListCreate.UserId = Guid.Parse(userId);

            var result = await BlackListApiClient.CreateBlackList(BLackListCreate);

            if (result != null && result.ToString() == "Duplicate")
            {
                ToastService.ShowError($".Duplicate", "Error");
            }
            else if (result!= null)
            {
                ToastService.ShowSuccess($"{BLackListCreate.Url} has been created successfully.", "Success");
                NavigationManager.NavigateTo("/blackLists");
            }
            else
            {
                ToastService.ShowError($"An error occurred in progress. Please contact to administrator.", "Error");
            }
        }
    }
}
