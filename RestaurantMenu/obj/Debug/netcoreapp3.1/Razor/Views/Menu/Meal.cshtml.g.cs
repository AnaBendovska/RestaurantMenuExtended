#pragma checksum "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7417e347ddbbf276461e9e7a57392447e415a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Meal), @"mvc.1.0.view", @"/Views/Menu/Meal.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\_ViewImports.cshtml"
using RestaurantMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\_ViewImports.cshtml"
using RestaurantMenu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7417e347ddbbf276461e9e7a57392447e415a4", @"/Views/Menu/Meal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6f3d97ddc868b82f8c190d482de1013e8ddc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Meal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RestaurantMenu.Models.Meal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Restaurant Menu</h1>\r\n<hr>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 14 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
             foreach (MealType t in MealType.ListAllActiveTypes())
            {
                if (t.IsActive)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"list-group-item\"");
            BeginWriteAttribute("href", " href=\"", 434, "\"", 492, 3);
            WriteAttributeValue("", 441, "/menu/", 441, 6, true);
#nullable restore
#line 18 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
WriteAttributeValue("", 447, MealType.GetTypeOfMeal(t.Id).ToLower(), 447, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 486, "/meals", 486, 6, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                                                                                                     Write(MealType.GetTypeOfMeal(t.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 19 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""col-md-9"">
        <p class=""col-md-12"" style=""margin-top:15px;"">
            <a class=""btn btn-primary float-left"" href=""/menu/create"">Create New</a>
            <a class=""btn btn-info float-right"" href=""/menu/interests"">See interests</a>
        </p><br /><br /><br>

        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Type
                    </th>
                    <th>
                        Name
                    </th>
                    <th>
                        Price
                    </th>
                    <th>
                        Ingredients
                    </th>
                    <th>
                        Vegeterian
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 51 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                 foreach (var m in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                       Write(RestaurantMenu.Models.MealType.GetTypeOfMeal(m.MealTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                       Write(Html.DisplayFor(modelItem => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                       Write(Html.DisplayFor(modelItem => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 64 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                             foreach (var i in m.Ingredients)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 66 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /></span>\r\n");
#nullable restore
#line 67 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 70 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                             if (m.IsVegeterian)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Yes</span> ");
#nullable restore
#line 71 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                                              }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>No</span>");
#nullable restore
#line 73 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a7417e347ddbbf276461e9e7a57392447e415a411379", async() => {
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                                                                                            WriteLiteral(m.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\14. Restaurant menu Extendet - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Meal.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RestaurantMenu.Models.Meal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
