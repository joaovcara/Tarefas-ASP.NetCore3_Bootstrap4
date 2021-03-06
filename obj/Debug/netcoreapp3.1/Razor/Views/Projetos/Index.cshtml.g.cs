#pragma checksum "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cee90a612f60bbdb29e36c92a152701891bd7bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projetos_Index), @"mvc.1.0.view", @"/Views/Projetos/Index.cshtml")]
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
#line 1 "B:\Projetos\Tarefas\Views\_ViewImports.cshtml"
using Tarefas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Projetos\Tarefas\Views\_ViewImports.cshtml"
using Tarefas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cee90a612f60bbdb29e36c92a152701891bd7bc", @"/Views/Projetos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b1d4ceb903fd790b0685a9067e34add11b7dd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Projetos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tarefas.Models.Projetos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-blue pl-4 pr-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
  
    ViewData["Title"] = "Projetos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row align-items-center\">\r\n    <h2>Projetos</h2>\r\n    <div class=\"pl-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cee90a612f60bbdb29e36c92a152701891bd7bc4026", async() => {
                WriteLiteral("NOVO");
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
            WriteLiteral(@"
    </div>
</div>

<div class=""row justify-content-center pt-3"">
    <table class=""table table-sm shadow-sm"">
        <thead>
            <tr class=""bg-login-blue text-light "">
                <th class=""border-0 font-weight-normal"">T??tulo</th>
                <th class=""border-0 font-weight-normal"">Descri????o</th>
                <th class=""text-center border-0 font-weight-normal"" style=""width:100px"">A????es</th>
            </tr>   
        </thead>
        <tbody>
");
            WriteLiteral(@"            <tr class=""border-primary bg-white"">
                <td class=""border-right border-bottom"">Sistema de gest??o de projetos</td>
                <td class=""border-right border-bottom"">Sistema para controle de chamados, e solicita????es para desenvolvimento do sistema</td>
                <td class=""text-center border-bottom"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1245, 1);
#nullable restore
#line 31 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 1212, Url.Action("Editar", "Projetos"), 1212, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-pencil-square btn-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1319, "\"", 1360, 1);
#nullable restore
#line 32 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 1326, Url.Action("Excluir", "Projetos"), 1326, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-trash btn-trash\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1469, 1);
#nullable restore
#line 33 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 1434, Url.Action("Imprimir", "Projetos"), 1434, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-printer btn-print\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1538, "\"", 1578, 1);
#nullable restore
#line 34 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 1545, Url.Action("Enviar", "Projetos"), 1545, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""bi bi-envelope btn-send""></i></a>
                </td>
            </tr>
            <tr class=""border-primary bg-white"">
                <td class=""border-right border-bottom"">Sistema de gest??o de projetos</td>
                <td class=""border-right border-bottom"">Sistema para controle de chamados, e solicita????es para desenvolvimento do sistema</td>
                <td class=""text-center border-bottom"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2029, "\"", 2069, 1);
#nullable restore
#line 41 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 2036, Url.Action("Editar", "Projetos"), 2036, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-pencil-square btn-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2143, "\"", 2184, 1);
#nullable restore
#line 42 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 2150, Url.Action("Excluir", "Projetos"), 2150, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-trash btn-trash\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2251, "\"", 2293, 1);
#nullable restore
#line 43 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 2258, Url.Action("Imprimir", "Projetos"), 2258, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-printer btn-print\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2362, "\"", 2402, 1);
#nullable restore
#line 44 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 2369, Url.Action("Enviar", "Projetos"), 2369, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""bi bi-envelope btn-send""></i></a>
                </td>
            </tr>
            <tr class=""border-primary bg-white"">
                <td class=""border-right border-bottom"">Sistema de gest??o de projetos</td>
                <td class=""border-right border-bottom"">Sistema para controle de chamados, e solicita????es para desenvolvimento do sistema</td>
                <td class=""text-center border-bottom"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2853, "\"", 2893, 1);
#nullable restore
#line 51 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 2860, Url.Action("Editar", "Projetos"), 2860, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-pencil-square btn-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2967, "\"", 3008, 1);
#nullable restore
#line 52 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 2974, Url.Action("Excluir", "Projetos"), 2974, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-trash btn-trash\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3075, "\"", 3117, 1);
#nullable restore
#line 53 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 3082, Url.Action("Imprimir", "Projetos"), 3082, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-printer btn-print\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3186, "\"", 3226, 1);
#nullable restore
#line 54 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 3193, Url.Action("Enviar", "Projetos"), 3193, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""bi bi-envelope btn-send""></i></a>
                </td>
            </tr>
            <tr class=""border-primary bg-white"">
                <td class=""border-right border-bottom"">Sistema de gest??o de projetos</td>
                <td class=""border-right border-bottom"">Sistema para controle de chamados, e solicita????es para desenvolvimento do sistema</td>
                <td class=""text-center border-bottom"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 3677, "\"", 3717, 1);
#nullable restore
#line 61 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 3684, Url.Action("Editar", "Projetos"), 3684, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-pencil-square btn-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3791, "\"", 3832, 1);
#nullable restore
#line 62 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 3798, Url.Action("Excluir", "Projetos"), 3798, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-trash btn-trash\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3899, "\"", 3941, 1);
#nullable restore
#line 63 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 3906, Url.Action("Imprimir", "Projetos"), 3906, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-printer btn-print\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4010, "\"", 4050, 1);
#nullable restore
#line 64 "B:\Projetos\Tarefas\Views\Projetos\Index.cshtml"
WriteAttributeValue("", 4017, Url.Action("Enviar", "Projetos"), 4017, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-envelope btn-send\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tarefas.Models.Projetos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
