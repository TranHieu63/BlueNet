#pragma checksum "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ea91271ec286d517e0641da3f06ce74beaaefb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
                  _userSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
                                          SearchFromUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col");
                __builder2.AddMarkupContent(8, "<label>UserName</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
                                                         _userSearch.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userSearch.UserName = __value, _userSearch.UserName))));
                __builder2.AddAttribute(13, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userSearch.UserName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col");
                __builder2.AddMarkupContent(17, "<label>Email</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "J:\BlueNet\BlueNet\BlueNet.Manager\Components\UserSearchForm.razor"
                                                         _userSearch.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userSearch.Email = __value, _userSearch.Email))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userSearch.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n\r\n       ");
                __builder2.AddMarkupContent(24, "<div class=\"col pt-4\"><button type=\"submit\" class=\"btn btn-primary\">Search</button></div>\r\n\r\n       ");
                __builder2.AddMarkupContent(25, "<div class=\"col pt-4\"><a href=\"/userCreate\" class=\"btn btn-success\">Create</a></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
