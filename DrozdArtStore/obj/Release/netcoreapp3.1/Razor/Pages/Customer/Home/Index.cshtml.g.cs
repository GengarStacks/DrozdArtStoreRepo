#pragma checksum "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2cd093847d9fdb18f2559d559893785f762a00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DrozdArtStore.Pages.Customer.Home.Pages_Customer_Home_Index), @"mvc.1.0.razor-page", @"/Pages/Customer/Home/Index.cshtml")]
namespace DrozdArtStore.Pages.Customer.Home
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
#line 1 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\_ViewImports.cshtml"
using DrozdArtStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
using DrozdArtStore.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2cd093847d9fdb18f2559d559893785f762a00", @"/Pages/Customer/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20fe89980f2afd9859d1b94a3c7de5934816c813", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customer_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 2px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
 if (!User.IsInRole(SD.CustomerRole) && !User.IsInRole(SD.ManagerRole))

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p class=\"text-center text-warning\" style=\"font-size: larger;\">Sign in to view the details or make purchase. </p>\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
 foreach (var category in Model.CategoryList)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
     if (Model.MenuItemList.Where(c => c.CategoryId == category.Id).Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container pb-3 bg-light pt-2\">\r\n            <div class=\"col-12\">\r\n                <div class=\"row\">\r\n                    <h2 class=\"text-secondary pl-1\"><b>");
#nullable restore
#line 22 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                                  Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n\r\n                    <div class=\"col-12\">\r\n                        <div class=\"row my-3\">\r\n");
#nullable restore
#line 26 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                             foreach (var menuItem in Model.MenuItemList.Where(c => c.CategoryId == category.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-3 col-xl-3 col-md-6 pg-4 pb-2"">
                                    <div class=""card"" style=""border: 1px solid;border-radius: 5px"">
                                        <div class=""pl-3 pt-1 text-center"">
                                            <h3 class=""card-title text-primary""><small>");
#nullable restore
#line 31 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                                                                  Write(menuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small></h3>
                                        </div>
                                        <div class=""d-flex justify-content-between form-control text-center"">
                                            <div class=""col-6 badge badge-gree text-center"" style=""font-size:14px;"">
                                                ");
#nullable restore
#line 35 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                           Write(menuItem.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"col-6 text-center h4 text-primary\">\r\n                                            <b>");
#nullable restore
#line 39 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                          Write(menuItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</b>\r\n\r\n                                        </div>\r\n                                        <img id=\"myImg\"");
            BeginWriteAttribute("src", " src=\"", 1997, "\"", 2018, 1);
#nullable restore
#line 42 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
WriteAttributeValue("", 2003, menuItem.Image, 2003, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Snow\" class=\"card-img-top p-2 rounded\"/>\r\n\r\n\r\n\r\n");
#nullable restore
#line 46 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                         if (User.IsInRole(SD.CustomerRole) || User.IsInRole(SD.ManagerRole))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d2cd093847d9fdb18f2559d559893785f762a008986", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                                                                                                     WriteLiteral(menuItem.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 52 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\DrozdArtStore deployed\DrozdArtStore\Pages\Customer\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrozdArtStore.Pages.Customer.Home.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DrozdArtStore.Pages.Customer.Home.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DrozdArtStore.Pages.Customer.Home.IndexModel>)PageContext?.ViewData;
        public DrozdArtStore.Pages.Customer.Home.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
