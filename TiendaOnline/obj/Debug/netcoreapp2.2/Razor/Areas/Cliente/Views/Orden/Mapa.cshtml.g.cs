#pragma checksum "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d8c875c6a5ad43782a86c55d85403e36fe9bf16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Orden_Mapa), @"mvc.1.0.view", @"/Areas/Cliente/Views/Orden/Mapa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Orden/Mapa.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Orden_Mapa))]
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
#line 1 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d8c875c6a5ad43782a86c55d85403e36fe9bf16", @"/Areas/Cliente/Views/Orden/Mapa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Orden_Mapa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Orden>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Todas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "En proceso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Enviado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Completado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mapa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
  
    ViewData["Title"] = "Mapa";

#line default
#line hidden
            BeginContext(96, 105, true);
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n\r\n    <h1 class=\"display-4 text-center\">Ordenes</h1>\r\n    ");
            EndContext();
            BeginContext(201, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8c875c6a5ad43782a86c55d85403e36fe9bf166233", async() => {
                BeginContext(239, 58, true);
                WriteLiteral("\r\n        <select id=\"estado\" name=\"estado\">\r\n            ");
                EndContext();
                BeginContext(297, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8c875c6a5ad43782a86c55d85403e36fe9bf166677", async() => {
                    BeginContext(319, 5, true);
                    WriteLiteral("Todas");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(333, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(347, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8c875c6a5ad43782a86c55d85403e36fe9bf168150", async() => {
                    BeginContext(374, 10, true);
                    WriteLiteral("En proceso");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(393, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(407, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8c875c6a5ad43782a86c55d85403e36fe9bf169629", async() => {
                    BeginContext(431, 7, true);
                    WriteLiteral("Enviado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(447, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(461, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8c875c6a5ad43782a86c55d85403e36fe9bf1611104", async() => {
                    BeginContext(488, 10, true);
                    WriteLiteral("Completado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(507, 103, true);
                WriteLiteral("\r\n        </select>\r\n\r\n        <input type=\"submit\" class=\"btn_3 p-2 ml-2\" value=\"Consultar\" />\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(617, 138, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <p class=\"h2 text-center\">Ordenes con el estado: <strong class=\"text-danger\"> ");
            EndContext();
            BeginContext(756, 18, false);
#line 32 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                                                             Write(ViewData["Estado"]);

#line default
#line hidden
            EndContext();
            BeginContext(774, 238, true);
            WriteLiteral("</strong></p>\r\n\r\n    <br />\r\n\r\n    <div id=\"map\" style=\"height: 480px; \"></div>\r\n\r\n    <!--Scripts\r\n    <!-- Make sure you put this AFTER Leaflet\'s CSS -->\r\n    <script src=\"https://unpkg.com/leaflet@1.0.2/dist/leaflet.js\"></script>\r\n    ");
            EndContext();
            BeginContext(1012, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8c875c6a5ad43782a86c55d85403e36fe9bf1614993", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1050, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
            EndContext();
#line 44 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
 foreach (var item in Model)
{



#line default
#line hidden
            BeginContext(1099, 31, true);
            WriteLiteral("    <script>\r\n            if (\"");
            EndContext();
            BeginContext(1131, 11, false);
#line 49 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
            Write(item.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 7, true);
            WriteLiteral("\" === \"");
            EndContext();
            BeginContext(1150, 18, false);
#line 49 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                               Write(ViewData["Estado"]);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 6, true);
            WriteLiteral("\" && \"");
            EndContext();
            BeginContext(1175, 18, false);
#line 49 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                                        Write(ViewData["Estado"]);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 43, true);
            WriteLiteral("\" != \'Todas\') {\r\n                L.marker([");
            EndContext();
            BeginContext(1237, 8, false);
#line 50 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                     Write(item.Lat);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1248, 9, false);
#line 50 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                Write(item.Long);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 86, true);
            WriteLiteral("], { draggable: true }).addTo(map)\r\n                    .bindPopup(\"<b>No. Orden:</b> ");
            EndContext();
            BeginContext(1344, 16, false);
#line 51 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                             Write(item.numeroOrden);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 22, true);
            WriteLiteral(" <br> <b>Cliente:</b> ");
            EndContext();
            BeginContext(1383, 11, false);
#line 51 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                                                                    Write(item.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 20, true);
            WriteLiteral(" <br><b>Estado:</b> ");
            EndContext();
            BeginContext(1415, 11, false);
#line 51 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                                                                                                    Write(item.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 63, true);
            WriteLiteral(" \")\r\n                    .openPopup();\r\n            }else if (\"");
            EndContext();
            BeginContext(1490, 18, false);
#line 53 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                  Write(ViewData["Estado"]);

#line default
#line hidden
            EndContext();
            BeginContext(1508, 40, true);
            WriteLiteral("\" === \'Todas\') {\r\n            L.marker([");
            EndContext();
            BeginContext(1549, 8, false);
#line 54 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                 Write(item.Lat);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1560, 9, false);
#line 54 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                            Write(item.Long);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 81, true);
            WriteLiteral("], { draggable: true }).addTo(map)\r\n               .bindPopup(\"<b>No. Orden:</b> ");
            EndContext();
            BeginContext(1651, 16, false);
#line 55 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                        Write(item.numeroOrden);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 22, true);
            WriteLiteral(" <br> <b>Cliente:</b> ");
            EndContext();
            BeginContext(1690, 11, false);
#line 55 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                                                               Write(item.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 20, true);
            WriteLiteral(" <br><b>Estado:</b> ");
            EndContext();
            BeginContext(1722, 11, false);
#line 55 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"
                                                                                                               Write(item.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 75, true);
            WriteLiteral(" \" )\r\n                    .openPopup();\r\n                }\r\n    </script>\r\n");
            EndContext();
#line 59 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Mapa.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Orden>> Html { get; private set; }
    }
}
#pragma warning restore 1591
