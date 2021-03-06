#pragma checksum "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95dc27eb7e035a6486f210b915571b144412f2bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Receipt), @"mvc.1.0.view", @"/Views/Home/Receipt.cshtml")]
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
#line 1 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\_ViewImports.cshtml"
using SoftwareEngineeringProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\_ViewImports.cshtml"
using SoftwareEngineeringProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95dc27eb7e035a6486f210b915571b144412f2bc", @"/Views/Home/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbb6ad5b30358a556f2c840e5adb5d95b129082", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SoftwareEngineeringProject.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-centered w3-tag w3-dark-grey w3-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
  
    ViewData["Title"] = "Receipt";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""w3-container w3-red w3-padding-64 w3-xxlarge"">
    <div class=""w3-content"">
        <h1 class=""w3-center w3-jumbo"" style=""margin-bottom:64px"">RECEIPT</h1>
        <div class=""w3-row w3-center w3-border w3-border-dark-grey"">
            <div class=""w3-padding-large w3-container"">
                <div class=""w3-white"">
                    <p class=""w3-text-grey w3-center"">
                        Michael's Café
                        <br />
                        ");
#nullable restore
#line 17 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                   Write(Model.TimeOfOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        Order Name: ");
#nullable restore
#line 19 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <hr>\r\n\r\n                    <!--Below is a for loop that will display every item in the order. Since the page is passed an order object, it can freely access it\'s contents list-->\r\n\r\n");
#nullable restore
#line 25 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                      
                        foreach (var item in Model.Contents)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1>\r\n                                <b>\r\n                                    ");
#nullable restore
#line 30 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                               Write(item.food_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </b>\r\n                                <span class=\"w3-right w3-tag w3-dark-grey w3-round\">\r\n                                    ");
#nullable restore
#line 33 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                               Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </h1>\r\n                            <hr>\r\n");
#nullable restore
#line 37 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <!--Below we use the Math library to round each value to two decimal places.
                        This is due to occasional errors we had where the program would use more than two decimals when displaying the total price-->

                    <h1>
                        <span class=""w3-right w3-tag w3-dark-grey w3-round"">
                            Subtotal: ");
#nullable restore
#line 45 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                                 Write(Math.Round(Model.SubTotal, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br />\r\n                            Tax: ");
#nullable restore
#line 47 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                            Write(Math.Round(Model.AddedTax, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br />\r\n                            Total: ");
#nullable restore
#line 49 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Receipt.cshtml"
                              Write(Math.Round(Model.Total, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </h1>\r\n                    <hr>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95dc27eb7e035a6486f210b915571b144412f2bc9046", async() => {
                WriteLiteral("\r\n        Return to Menu\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoftwareEngineeringProject.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
