#pragma checksum "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56f0707cb1927eaacfbbb85feb4bd2fd4c435f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MotorenOverview), @"mvc.1.0.view", @"/Views/Home/MotorenOverview.cshtml")]
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
#line 1 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
using OpdrachtASPCoreDag2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56f0707cb1927eaacfbbb85feb4bd2fd4c435f1", @"/Views/Home/MotorenOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae25f1b03a32147a4de737d5b4a06552636bc73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MotorenOverview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MotorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <table>\r\n");
#nullable restore
#line 6 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
         foreach (var motor in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 8 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
               Write(motor.Merk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 8 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
                                   Write(motor.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 8 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
                                                       Write(motor.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 9 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td></td><td></td><td>");
#nullable restore
#line 10 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenOverview.cshtml"
                             Write(Html.ActionLink("Add","VoegToe","Motor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MotorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
