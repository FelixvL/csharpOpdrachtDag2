#pragma checksum "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "011c7cfcc4ffad6905ab167b6918412e286185d6"
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
#line 1 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\_ViewImports.cshtml"
using OpdrachtASPCoreDag2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml"
using OpdrachtASPCoreDag2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011c7cfcc4ffad6905ab167b6918412e286185d6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae25f1b03a32147a4de737d5b4a06552636bc73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n");
#nullable restore
#line 11 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml"
         foreach (var p in Model){ 

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml"
                              Write(p.Salary);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml"
                                            ; }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 14 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\Index.cshtml"
Write(Html.ActionLink("MotorenKijken","ShowMotoren","Motor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
