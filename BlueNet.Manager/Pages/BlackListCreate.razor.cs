using Blazored.Toast.Services;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class BlackListCreate
    {
        [Inject] private IBlackListApiClient BlackListApiClient { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private IToastService ToastService { get; set; }

        private BlackListCreateRequest BLackListCreate = new BlackListCreateRequest();

        private async Task SubmitCreateBlackList(EditContext context)
        {
            var result = await BlackListApiClient.CreateBlackList(BLackListCreate);
            if (result)
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
