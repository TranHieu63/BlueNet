#pragma checksum "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad56dcadf1f478755b4de69e3e1612345dc371d9"
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
#line 1 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using BlueNet.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using BlueNet.Manager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
using BlueNet.Manager.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/violations")]
    public partial class ViolationList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Danh sách vi phạm</h3>");
#nullable restore
#line 9 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
 if (violationParameters == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlueNet.Manager.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 12 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row mt-4");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>Url</th>\r\n                <th>ComputerName</th>\r\n                <th>TimeStamp</th>\r\n                <th>HandwareId</th>\r\n                <th>IpLocal</th>\r\n                <th>UserId</th></tr></thead>\r\n\r\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 29 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
             foreach (var item in violationParameters)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
#nullable restore
#line 33 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
__builder.AddContent(10, item.Url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 34 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
__builder.AddContent(13, item.ComputerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 35 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
__builder.AddContent(16, item.TimeStamp.ToString(Configuration["DataTimeFormat"]));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 36 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
__builder.AddContent(19, item.HandwareId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 37 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
__builder.AddContent(22, item.IpLocal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 38 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
__builder.AddContent(25, item.UserId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\ViolationList.razor"


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
