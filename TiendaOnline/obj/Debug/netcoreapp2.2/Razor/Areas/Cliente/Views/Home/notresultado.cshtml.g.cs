#pragma checksum "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\notresultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e55c259685f1f3c66a1675d3e978bb356d85bf10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Home_notresultado), @"mvc.1.0.view", @"/Areas/Cliente/Views/Home/notresultado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Home/notresultado.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Home_notresultado))]
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
#line 1 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 2 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e55c259685f1f3c66a1675d3e978bb356d85bf10", @"/Areas/Cliente/Views/Home/notresultado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Home_notresultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 86, true);
            WriteLiteral("<style>\r\n    #notret {\r\n        color: red;\r\n    }\r\n</style>\r\n<h2 id=\"notret\"><center>");
            EndContext();
            BeginContext(87, 23, false);
#line 6 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\notresultado.cshtml"
                   Write(ViewData["NORESULTADO"]);

#line default
#line hidden
            EndContext();
            BeginContext(110, 14, true);
            WriteLiteral("</center></h2>");
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
