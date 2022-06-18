#pragma checksum "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae6aeeacb5128b5c358e1417bfe001db2c54c732"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/userCreate")]
    public partial class UserCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UserCreate</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                 UserRequestCreate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                   SubmitCreateUser

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
                __builder2.AddMarkupContent(9, "<label for=\"UserName\">UserName</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                     UserRequestCreate.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRequestCreate.UserName = __value, UserRequestCreate.UserName))));
                __builder2.AddAttribute(14, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRequestCreate.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 10 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                ()=>UserRequestCreate.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.AddMarkupContent(19, "<small id=\"usernameHelp\" class=\"form-text text-muted\">Please enter user title here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"Email\">Email</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                     UserRequestCreate.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRequestCreate.Email = __value, UserRequestCreate.Email))));
                __builder2.AddAttribute(28, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRequestCreate.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 24 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                ()=>UserRequestCreate.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.AddMarkupContent(33, "<small id=\"emailHelp\" class=\"form-text text-muted\">Please enter email here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n\r\n     ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label for=\"FirstName\">FirstName</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                     UserRequestCreate.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRequestCreate.FirstName = __value, UserRequestCreate.FirstName))));
                __builder2.AddAttribute(42, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRequestCreate.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateValidationMessage_2(__builder2, 44, 45, 
#nullable restore
#line 38 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                ()=>UserRequestCreate.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.AddMarkupContent(47, "<small id=\"firstNamelHelp\" class=\"form-text text-muted\">Please enter firstname here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n     ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label for=\"LastName\">LastName</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                     UserRequestCreate.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRequestCreate.LastName = __value, UserRequestCreate.LastName))));
                __builder2.AddAttribute(56, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRequestCreate.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateValidationMessage_3(__builder2, 58, 59, 
#nullable restore
#line 45 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                ()=>UserRequestCreate.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.AddMarkupContent(61, "<small id=\"lastNamelHelp\" class=\"form-text text-muted\">Please enter lastname here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "<label for=\"Password\">Password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "type", "password");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                                     UserRequestCreate.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRequestCreate.Password = __value, UserRequestCreate.Password))));
                __builder2.AddAttribute(71, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRequestCreate.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateValidationMessage_4(__builder2, 73, 74, 
#nullable restore
#line 60 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                ()=>UserRequestCreate.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.AddMarkupContent(76, "<small id=\"passwordHelp\" class=\"form-text text-muted\">Please enter password here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "<label for=\"Role\">Role</label> <br>\r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateInputRadioGroup_5(__builder2, 81, 82, "role", 83, "form-control", 84, 
#nullable restore
#line 66 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                                UserRequestCreate.RoleId

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRequestCreate.RoleId = __value, UserRequestCreate.RoleId)), 86, () => UserRequestCreate.RoleId, 87, (__builder3) => {
#nullable restore
#line 67 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
             foreach (var item in _ListRoleDto)
            {

#line default
#line hidden
#nullable disable
                    __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateInputRadio_6(__builder3, 88, 89, 
#nullable restore
#line 69 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                    item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 69 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
__builder3.AddContent(90, item.Name);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(91, " <t></t>");
#nullable restore
#line 70 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(92, " \r\n        ");
                __Blazor.BlueNet.Manager.Pages.UserCreate.TypeInference.CreateValidationMessage_7(__builder2, 93, 94, 
#nullable restore
#line 72 "J:\BlueNet\BlueNet\BlueNet.Manager\Pages\UserCreate.razor"
                                ()=>UserRequestCreate.RoleId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.AddMarkupContent(96, "<small id=\"xxx\" class=\"form-text text-muted\">Please choose user role here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n    ");
                __builder2.AddMarkupContent(98, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlueNet.Manager.Pages.UserCreate
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputRadioGroup_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
