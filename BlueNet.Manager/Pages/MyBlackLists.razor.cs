using Blazored.LocalStorage;
using BlueNet.Manager.Components;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlueNet.Manager.Pages
{
    public partial class MyBlackLists
    {
        [Inject] private IBlackListApiClient BlackListApiClient { get; set; }
        [Inject] private AuthenticationStateProvider authProvider { get; set; }

        [Inject] private ILocalStorageService _localStorage { get; set; }

        AuthenticationState authState;
        private string userId;

        private List<BlackListDto> BlackLists;

        protected Confirmation DeleteConfirmation { get; set; }

        private Guid DeleteId { get; set; }

        private BlackListSearch _blackListSearch = new BlackListSearch();

        protected override async Task OnInitializedAsync()
        {
            //Lấy ra userId đang đăng nhập
            string userId = await _localStorage.GetItemAsync<string>("UserId");

            //gán giá trị UserId cho _blackListSearch bằng giá trị userId vừa lấy được
            _blackListSearch.UserId = Guid.Parse(userId);

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
