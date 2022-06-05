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
    public partial class User
    {
        [Inject] private IUserApiClient UserApiClient { get; set; }

        private List<UserDto> Users;

        //protected Confirmation DeleteConfirmation { get; set; }

        //private Guid DeleteId { get; set; }

        private UserSearch _userSearch = new UserSearch();

        protected override async Task OnInitializedAsync()
        {
            Users = await UserApiClient.GetUsers(_userSearch);
        }

        public async Task SearchUser(UserSearch userSearch)
        {
            _userSearch = userSearch;
            Users = await UserApiClient.GetUsers(_userSearch);
        }

        //public void OnDeleteBlackList(Guid deleteId)
        //{
        //    DeleteId = deleteId;
        //    DeleteConfirmation.Show();
        //}

        //public async Task OnConfirmDeleteTask(bool deleteConfirmed)
        //{
        //    if (deleteConfirmed)
        //    {
        //        await BlackListApiClient.DeleteBlackList(DeleteId);
        //        BlackLists = await BlackListApiClient.GetBlackList(_blackListSearch);
        //    }
        //}
    }

    
}
