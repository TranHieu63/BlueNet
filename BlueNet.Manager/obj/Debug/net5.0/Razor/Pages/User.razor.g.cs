#pragma checksum "J:\BlueNet\BlueNet.Manager\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42d6c666681cc04a224d3cff6e32cf94f16cace"
// <auto-generated/>
#pragma warning disable 1591
namespace BlueNet.Manager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using BlueNet.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using BlueNet.Manager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "J:\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
using BlueNet.Manager.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Danh sách người dùng</h3>");
#nullable restore
#line 9 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
 if (Users == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlueNet.Manager.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 12 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenComponent<BlueNet.Manager.Components.UserSearchForm>(4);
            __builder.AddAttribute(5, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlueNet.Models.UserSearch>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlueNet.Models.UserSearch>(this, 
#nullable restore
#line 16 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
                                  SearchUser

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row mt-4");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>UserId</th>\r\n                <th>Email</th>\r\n                <th>UserName</th>\r\n                <th>FullName</th>\r\n                <th></th></tr></thead>\r\n\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 34 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
             foreach (var item in Users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 37 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
__builder.AddContent(14, item.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 38 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
__builder.AddContent(17, item.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 39 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
__builder.AddContent(20, item.UserName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 40 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
__builder.AddContent(23, item.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    \r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/userDetails/" + (
#nullable restore
#line 43 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
                                               item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddContent(29, "Detail");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "/userUpdate/" + (
#nullable restore
#line 44 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
                                              item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "btn btn-warning");
            __builder.AddContent(34, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n                        ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
                                                                 ()=> OnDeleteUser(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<BlueNet.Manager.Components.Confirmation>(40);
            __builder.AddAttribute(41, "ConfirmationMessage", "Are you sure to delete?");
            __builder.AddAttribute(42, "ConfirmationTitle", "Delete User");
            __builder.AddAttribute(43, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 58 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
                                        OnConfirmDeleteUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 57 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
                         DeleteConfirmation = (BlueNet.Manager.Components.Confirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 61 "J:\BlueNet\BlueNet.Manager\Pages\User.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
