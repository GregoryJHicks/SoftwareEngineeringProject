#pragma checksum "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85c5e42c66ff363fba2935a8fad0bbcada66ec4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f85c5e42c66ff363fba2935a8fad0bbcada66ec4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbb6ad5b30358a556f2c840e5adb5d95b129082", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SoftwareEngineeringProject.Models.FullMenu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Header for the Menu-->
<style>
    .bgimg {
        background-repeat: no-repeat;
        background-size: cover;
        background-image: url(~/Views/Home/mc_bg_img.jpg); /*Cannot figure out the image*/
        min-height: 90%;
    }
</style>
<header class=""bgimg w3-display-container w3-grayscale-min"" id=""home"">
    <div class=""w3-display-bottomleft w3-padding"">
        <span class=""w3-tag w3-xlarge"">Open weekdays from 7am to 4:30pm</span>
    </div>
    <div class=""w3-display-middle w3-center"">
        <span class=""w3-text-white w3-hide-small"" style=""font-size:100px"">Michael's<br />Café</span>
    </div>
</header>

");
#nullable restore
#line 25 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Index.cshtml"
   
    for (int i = 0; i < Model.Length; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Hello</p><br />\r\n");
#nullable restore
#line 29 "C:\Code\GitHub Repositories\SoftwareEngineeringProject\SoftwareEngineeringProject\SoftwareEngineeringProject\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoftwareEngineeringProject.Models.FullMenu> Html { get; private set; }
    }
}
#pragma warning restore 1591
