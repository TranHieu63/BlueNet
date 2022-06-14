using BlueNet.Manager.Components;
using BlueNet.Manager.Services;
using BlueNet.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
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
        [Inject] private NavigationManager NavigationManager { get; set; }

        //
        [Inject] private AuthenticationStateProvider authProvider { get; set; }

        [Inject] private IUserApiClient UserApiClient { get; set; }

        private List<BlackListDto> BlackLists;

        //
        private int role;

        protected Confirmation DeleteConfirmation { get; set; }

        private Guid DeleteId { get; set; }

        private BlackListSearch _blackListSearch = new BlackListSearch();


        protected override async Task OnInitializedAsync()
        {

            BlackLists = await BlackListApiClient.GetBlackList(_blackListSearch);

            //lấy thông tin user đăng nhập
            var authState = await authProvider.GetAuthenticationStateAsync();
            

            if (authState != null)
            {
                var user = authState.User;

                if (user.Identity.IsAuthenticated)
                {
                    var userName = user.Identity.Name;

                    //lấy thông tin người dùng đang đăng nhập theo userName 
                    var userDto = await UserApiClient.GetUserByUserName(userName);

                    if (userDto != null)
                    {
                        //nếu có user đăng nhập thì lấy tiếp thông tin quyền hạn

                        if (true)
                        {
                            role = 1;
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    NavigationManager.NavigateTo("/login");
                }
            }
            else
            {
                NavigationManager.NavigateTo("/login");
            }
 
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

        public async Task OnConfirmDeleteBlackList(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await BlackListApiClient.DeleteBlackList(DeleteId);
                BlackLists = await BlackListApiClient.GetBlackList(_blackListSearch);
            }
        }
    }

    
}
