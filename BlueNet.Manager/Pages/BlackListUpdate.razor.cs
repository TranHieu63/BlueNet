using Blazored.LocalStorage;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class BlackListUpdate
    {
        [Inject] private ILocalStorageService _localStorage { get; set; }

        [Parameter]
        public string blackListId { get; set; }

        private BlackListUpdateRequest BLackListUpdate;

        private string _userId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var blackListDto = await BlackListApiClient.GetBlackListDetail(blackListId);

            BLackListUpdate = new BlackListUpdateRequest();
            BLackListUpdate.Url = blackListDto.Url;
            ///blackListDto.UserId = blackListDto.UserId;

            _userId = await _localStorage.GetItemAsync<string>("UserId");

        }


        private async Task SubmitUpdateBlackList(EditContext context)
        {
            string userId = await _localStorage.GetItemAsync<string>("UserId");

            BLackListUpdate.UserId = Guid.Parse(userId);

            var result = await BlackListApiClient.UpdateBlackList(Guid.Parse(blackListId), BLackListUpdate);
            if (result)
            {
                ToastService.ShowSuccess($"{BLackListUpdate.Url} has been update successfully.", "Success");
                NavigationManager.NavigateTo("/myBlackLists");
            }
            else
            {
                ToastService.ShowError($"An error occurred in progress. Please contact to administrator.", "Error");
            }
        }
    }
}
