#pragma checksum "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenToevoegen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2941adb82de0c6a6f25df4c35cdf087dba3d822b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MotorenToevoegen), @"mvc.1.0.view", @"/Views/Home/MotorenToevoegen.cshtml")]
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
#line 2 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\_ViewImports.cshtml"
using OpdrachtASPCoreDag2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2941adb82de0c6a6f25df4c35cdf087dba3d822b", @"/Views/Home/MotorenToevoegen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae25f1b03a32147a4de737d5b4a06552636bc73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MotorenToevoegen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MotorModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nMotorenToevoegen\r\n\r\n");
#nullable restore
#line 5 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenToevoegen.cshtml"
 using (Html.BeginForm("VoegToePost", "Motor")) { 

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenToevoegen.cshtml"
Write(Html.LabelFor( a => a.Merk));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenToevoegen.cshtml"
Write(Html.TextBoxFor( a => a.Merk ));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" > Add </button>\r\n");
#nullable restore
#line 11 "C:\Users\NextProgram\source\repos\OpdrachtASPCoreDag2\OpdrachtASPCoreDag2\Views\Home\MotorenToevoegen.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("         ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MotorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591