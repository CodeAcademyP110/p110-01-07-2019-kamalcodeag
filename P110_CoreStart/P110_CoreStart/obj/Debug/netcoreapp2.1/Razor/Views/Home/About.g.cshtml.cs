#pragma checksum "D:\Programming\Other\ASP.NET\01.07.2019(MVC Core Start)\P110_CoreStart\P110_CoreStart\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b39d887b00100d593756ec05320a8ac649e7d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b39d887b00100d593756ec05320a8ac649e7d5", @"/Views/Home/About.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programming\Other\ASP.NET\01.07.2019(MVC Core Start)\P110_CoreStart\P110_CoreStart\Views\Home\About.cshtml"
  
    string[] names = new string[]
    {
        "Samir",
        "Medis",
        "Shems",
        "Kamuran",
        "Aqil",
        "Elcin",
        "Kamil"
    };

#line default
#line hidden
            BeginContext(183, 110, true);
            WriteLiteral("\r\n<main>\r\n    <div class=\"container\">\r\n        <h3>Salam, P110 - About</h3>\r\n        <ul class=\"list-group\">\r\n");
            EndContext();
#line 18 "D:\Programming\Other\ASP.NET\01.07.2019(MVC Core Start)\P110_CoreStart\P110_CoreStart\Views\Home\About.cshtml"
             foreach (var item in names)
            {

#line default
#line hidden
            BeginContext(350, 44, true);
            WriteLiteral("                <li class=\"list-group-item\">");
            EndContext();
            BeginContext(395, 4, false);
#line 20 "D:\Programming\Other\ASP.NET\01.07.2019(MVC Core Start)\P110_CoreStart\P110_CoreStart\Views\Home\About.cshtml"
                                       Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(399, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 21 "D:\Programming\Other\ASP.NET\01.07.2019(MVC Core Start)\P110_CoreStart\P110_CoreStart\Views\Home\About.cshtml"
            }

#line default
#line hidden
            BeginContext(421, 43, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</main>\r\n\r\n   \r\n");
            EndContext();
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
