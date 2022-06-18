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
    public partial class ViolationList
    {
        [Inject] private IViolationApiClient ViolationApiClient { get; set; }

        //[Inject] private ILocalStorageService _localStorage { get; set; }


        //private string userId;

        private List<ViolationParameter> violationParameters;


        protected override async Task OnInitializedAsync()
        {
            //Lấy ra userId đang đăng nhập
            //string userId = await _localStorage.GetItemAsync<string>("UserId");

            //gán giá trị UserId cho _blackListSearch bằng giá trị userId vừa lấy được
            //_blackListSearch.UserId = Guid.Parse(userId);

            violationParameters = await ViolationApiClient.GetViolations();

        }

      
    }

    
}
