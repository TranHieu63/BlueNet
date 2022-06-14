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
    public partial class User
    {
        [Inject] private IUserApiClient UserApiClient { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        [Inject] private AuthenticationStateProvider authProvider { get; set; }

        private int role;

        private List<UserDto> Users;

        protected Confirmation DeleteConfirmation { get; set; }

        private Guid DeleteId { get; set; }

        private UserSearch _userSearch = new UserSearch();

        protected override async Task OnInitializedAsync()
        {
            Users = await UserApiClient.GetUsers(_userSearch);

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

        public async Task SearchUser(UserSearch userSearch)
        {
            _userSearch = userSearch;
            Users = await UserApiClient.GetUsers(_userSearch);
        }

        public void OnDeleteUser(Guid deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteUser(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await UserApiClient.DeleteUser(DeleteId);
                Users = await UserApiClient.GetUsers(_userSearch);
            }
        }
    }
    
}
