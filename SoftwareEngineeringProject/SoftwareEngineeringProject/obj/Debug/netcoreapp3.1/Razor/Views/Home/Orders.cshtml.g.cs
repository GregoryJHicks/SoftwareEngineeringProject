#pragma checksum "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e597a4bcecb4cb921500f9c9f3ba135a7f914c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Orders), @"mvc.1.0.view", @"/Views/Home/Orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e597a4bcecb4cb921500f9c9f3ba135a7f914c", @"/Views/Home/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbb6ad5b30358a556f2c840e5adb5d95b129082", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SoftwareEngineeringProject.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-bar-item w3-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
  
    ViewData["Title"] = "Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Navbar (sit on top) -->\r\n<div class=\"w3-top w3-hide-small\">\r\n    <div class=\"w3-bar w3-xlarge w3-white w3-opacity w3-hover-opacity-off\" id=\"myNavbar\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e597a4bcecb4cb921500f9c9f3ba135a7f914c5627", async() => {
                WriteLiteral("Menu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e597a4bcecb4cb921500f9c9f3ba135a7f914c7277", async() => {
                WriteLiteral("My Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e597a4bcecb4cb921500f9c9f3ba135a7f914c8930", async() => {
                WriteLiteral("Previous Orders");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""w3-container w3-red w3-padding-64 w3-xxlarge"">
    <div class=""w3-content"">
        <h1 class=""w3-center w3-jumbo"" style=""margin-bottom:64px"">PREVIOUS ORDERS</h1>
        <div class=""w3-row w3-center w3-border w3-border-dark-grey"">
            <div class=""w3-padding-large"">
                <div class=""w3-white"">

                    <!--Below is the for loop which allows this page to dislay every order created durring the session-->
");
#nullable restore
#line 24 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                      
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <h1>\r\n                                    Name: ");
#nullable restore
#line 29 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h1>\r\n                                <h1>\r\n                                    Address: ");
#nullable restore
#line 32 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                                        Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h1>\r\n                                <h1>\r\n                                    Time: ");
#nullable restore
#line 35 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                                     Write(item.TimeOfOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h1>\r\n                                <hr />\r\n                            </div>\r\n");
            WriteLiteral("                            <!--Below is the for loop which allows this page to display all items in this specific order-->\r\n");
#nullable restore
#line 41 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                            foreach (var item2 in item.Contents)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"flex-container\">\r\n                                    <div class=\"menu-item--name\" style=\"width:650px;text-align:left;\">\r\n                                        <b>\r\n                                            ");
#nullable restore
#line 46 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                                       Write(item2.food_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </b>
                                    </div>
                                    <div class=""menu-item--price"" style=""width:100px;text-align:right;"">
                                        <span class=""w3-tag w3-dark-grey w3-round"">
                                            ");
#nullable restore
#line 51 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                                       Write(item2.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n                                    </div>\r\n                                </div>\r\n                                <hr />\r\n");
#nullable restore
#line 56 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!--Below we use the Math library to round each value to two decimal places.
                            This is due to occasional errors we had where the program would use more than two decimals when displaying the total price-->
                            <div class=""menu-item--price flex-container w3-text-grey"">
                                <span class=""w3-tag w3-dark-grey w3-round"">
                                    Total: ");
#nullable restore
#line 62 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                                      Write(Math.Round(item.Total, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                            <hr style=\"height:2px;border-width:0;color:gray;background-color:gray\" />\r\n");
#nullable restore
#line 66 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Orders.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SoftwareEngineeringProject.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
