#pragma checksum "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe980c85524684a728a302ea757b80ce88a7241"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Especiales_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Especiales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Especiales/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Especiales_Index))]
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
#line 1 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 1 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe980c85524684a728a302ea757b80ce88a7241", @"/Areas/Admin/Views/Especiales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Especiales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Especiales>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonEspecialPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
  
    ViewData["Title"] = "Especiales";

#line default
#line hidden
            BeginContext(107, 167, true);
            WriteLiteral("<br />\r\n<br />\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Especiales</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(274, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe980c85524684a728a302ea757b80ce88a72414864", async() => {
                BeginContext(318, 14, true);
                WriteLiteral("Nuevo Especial");
                EndContext();
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
            EndContext();
            BeginContext(336, 158, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 34, false);
#line 26 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(529, 158, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n            <th class=\"text-center\">\r\n                Acción\r\n            </th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 36 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
         foreach (var k in Model)
        {

#line default
#line hidden
            BeginContext(733, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(794, 8, false);
#line 40 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
               Write(k.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(802, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(869, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1fe980c85524684a728a302ea757b80ce88a72417845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 43 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = k.ID;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(924, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(979, 28, true);
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1024, 208, true);
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            //Guardar\r\n            var guardar = \'");
                EndContext();
                BeginContext(1233, 19, false);
#line 58 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
                      Write(TempData["guardar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1252, 148, true);
                WriteLiteral("\'\r\n            if (guardar != \'\') {\r\n                alertify.success(guardar);\r\n            }\r\n\r\n            //Editar\r\n\r\n            var editar = \'");
                EndContext();
                BeginContext(1401, 18, false);
#line 65 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
                     Write(TempData["editar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1419, 148, true);
                WriteLiteral("\'\r\n            if (editar != \'\') {\r\n                alertify.success(editar);\r\n            }\r\n\r\n            //Eliminar\r\n            var eliminar = \'");
                EndContext();
                BeginContext(1568, 20, false);
#line 71 "C:\Users\javie\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Especiales\Index.cshtml"
                       Write(TempData["eliminar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1588, 129, true);
                WriteLiteral("\'\r\n            if (eliminar != \'\') {\r\n                alertify.error(eliminar);\r\n            }\r\n\r\n\r\n        })\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Especiales>> Html { get; private set; }
    }
}
#pragma warning restore 1591
