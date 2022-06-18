#pragma checksum "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6482935ae6b9dfb41903cf85def2be8062eebc33"
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
#line 13 "J:\BlueNet\BlueNet\BlueNet.Manager\_Imports.razor"
using Blazored.Toast.Services;

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
#line 3 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
using BlueNet.Manager.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blackListDetails/{blackListId}")]
    public partial class BlackListDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
 if (blacklistDto == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlueNet.Manager.Components.LoadingIndicator>(0);
            __builder.CloseComponent();
#nullable restore
#line 10 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>BlackList Detail </h3>\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<td>Url</td>\r\n            ");
            __builder.OpenElement(7, "td");
#nullable restore
#line 18 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
__builder.AddContent(8, blacklistDto.Url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "<td>UserId</td>\r\n            ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 22 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
__builder.AddContent(13, blacklistDto.UserId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "<td>Create date</td>\r\n            ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 27 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
__builder.AddContent(18, blacklistDto.CreatedDate.ToString(Configuration["DataTimeFormat"]));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\BlackListDetails.razor"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
    }
}
#pragma warning restore 1591
