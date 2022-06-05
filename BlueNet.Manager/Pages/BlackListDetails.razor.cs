using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;


namespace BlueNet.Manager.Pages
{
    public partial class BlackListDetails
    {
        [Parameter]
        public string blackListId { get; set; }

        [Inject] private IBlackListApiClient _blackListApiClient { get; set; }

        private BlackListDto blacklistDto { get; set; }

        protected async override Task OnInitializedAsync()
        {
            blacklistDto = await _blackListApiClient.GetBlackListDetail(blackListId);
        }
    }
}
