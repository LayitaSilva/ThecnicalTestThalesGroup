#pragma checksum "C:\Users\silvalam\Source\repos\ThecnicalTestThalesGroup\TechTestThalesGroup\TechTestThalesGroup\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ace66641ad255c4025a1592ec19ca645247ff763"
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
#line 1 "C:\Users\silvalam\Source\repos\ThecnicalTestThalesGroup\TechTestThalesGroup\TechTestThalesGroup\Views\_ViewImports.cshtml"
using TechTestThalesGroup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\silvalam\Source\repos\ThecnicalTestThalesGroup\TechTestThalesGroup\TechTestThalesGroup\Views\_ViewImports.cshtml"
using TechTestThalesGroup.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ace66641ad255c4025a1592ec19ca645247ff763", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf5de8886d6c6028db44646ed1e92c669420f65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\silvalam\Source\repos\ThecnicalTestThalesGroup\TechTestThalesGroup\TechTestThalesGroup\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>


<div class=""text-primary"">
    <button ttype=""button"" name=""GetEmployee""");
            BeginWriteAttribute("onclick", "  onclick=\"", 313, "\"", 370, 3);
            WriteAttributeValue("", 324, "location.href=\'", 324, 15, true);
#nullable restore
#line 12 "C:\Users\silvalam\Source\repos\ThecnicalTestThalesGroup\TechTestThalesGroup\TechTestThalesGroup\Views\Home\Index.cshtml"
WriteAttributeValue("", 339, Url.Action("Employee","Home"), 339, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 369, "\'", 369, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Get Employee information</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
