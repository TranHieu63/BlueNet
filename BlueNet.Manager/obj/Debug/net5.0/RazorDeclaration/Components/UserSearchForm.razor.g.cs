// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlueNet.Manager.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using BlueNet.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using BlueNet.Manager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
using BlueNet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
using BlueNet.Manager.Services;

#line default
#line hidden
#nullable disable
    public partial class UserSearchForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
       
    [Inject] private IUserApiClient UserApiClient { get; set; }

    [Inject] private IToastService ToastService { get; set; }

    [Parameter]
    public EventCallback<UserSearch> OnSearch { get; set; }

    private UserSearch _userSearch = new UserSearch();

    private List<UserDto> Users;

    //protected override async Task OnInitializedAsync()
    //{
    //    Users = await UserApiClient.GetUsers();
    //}

    private async Task SearchFromUser(EditContext context)
    {
        await OnSearch.InvokeAsync(_userSearch);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
