using BlueNet.Manager.Components;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class BlackList
    {
        [Inject] private IBlackListApiClient BlackListApiClient { get; set; }

        private List<BlackListDto> BlackLists;

        protected Confirmation DeleteConfirmation { get; set; }

        private Guid DeleteId { get; set; }

        private BlackListSearch _blackListSearch = new BlackListSearch();

        protected override async Task OnInitializedAsync()
        {
            BlackLists = await BlackListApiClient.GetBlackList(_blackListSearch);
        }

        public async Task SearchBlackList(BlackListSearch blackListSearch)
        {
            _blackListSearch = blackListSearch;
            BlackLists = await BlackListApiClient.GetBlackList(_blackListSearch);
        }

        public void OnDeleteBlackList(Guid deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteTask(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await BlackListApiClient.DeleteBlackList(DeleteId);
                BlackLists = await BlackListApiClient.GetBlackList(_blackListSearch);
            }
        }
    }

    
}
