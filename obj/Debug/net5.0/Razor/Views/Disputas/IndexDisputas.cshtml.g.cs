#pragma checksum "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f096a7d686e3ab415acb8f56c04f60d9739c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disputas_IndexDisputas), @"mvc.1.0.view", @"/Views/Disputas/IndexDisputas.cshtml")]
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
#line 1 "C:\Atividade_DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Atividade_DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f096a7d686e3ab415acb8f56c04f60d9739c8a", @"/Views/Disputas/IndexDisputas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6c27e866fba86603325ac11c78fec551602e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Disputas_IndexDisputas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.DisputaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 7 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 11 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
  
    ViewBag.Title = "Disputas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Relação das Disputas</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 19 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 20 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDisputa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 21 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.Narracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 22 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.Resultados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 25 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelIdem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelIdem => item.DataDisputa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelIdem => item.Narracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelIdem => item.Resultados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 35 "C:\Atividade_DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
Write(Html.ActionLink("Apagar Disputas", "ApagarDisputas", "Disputas" , null, new { @class = "btn btn-danger", onclick =
"return confirm('Deseja realmente deletar este personagem ?');"}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.DisputaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
