#pragma checksum "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\BlackListCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23c91ac1242ab233d1a1ab112da9d12882517f9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/blackListCreate")]
    public partial class BlackListCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlackListCreate</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\BlackListCreate.razor"
                 BLackListCreate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\BlackListCreate.razor"
                                                 SubmitCreateBlackList

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label for=\"Url\">Url</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\BlackListCreate.razor"
                                                     BLackListCreate.Url

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BLackListCreate.Url = __value, BLackListCreate.Url))));
                __builder2.AddAttribute(14, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => BLackListCreate.Url));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __Blazor.BlueNet.Manager.Pages.BlackListCreate.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 11 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\BlackListCreate.razor"
                                ()=>BLackListCreate.Url

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.AddMarkupContent(19, "<small id=\"urlHelp\" class=\"form-text text-muted\">Please enter black list title here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddContent(22, "_userId: ");
#nullable restore
#line 15 "J:\BlueNet-20220618T020959Z-001\BlueNet\BlueNet.Manager\Pages\BlackListCreate.razor"
__builder2.AddContent(23, _userId);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n \r\n    ");
                __builder2.AddMarkupContent(25, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlueNet.Manager.Pages.BlackListCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
