#pragma checksum "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd6a47f6b06a9b1d28e7c0cee7f4bacd831e348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
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
#line 1 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\_ViewImports.cshtml"
using BokuNoHeroAcademia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\_ViewImports.cshtml"
using BokuNoHeroAcademia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd6a47f6b06a9b1d28e7c0cee7f4bacd831e348", @"/Views/Professor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac46787484f541d93950c22f80767a0bd351ae0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BokuNoHeroAcademia.Models.AcademiaViewModels.ProfessorCurso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Professor ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd6a47f6b06a9b1d28e7c0cee7f4bacd831e3485237", async() => {
                WriteLiteral("Cadastrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h1>

<script>
    $(document).ready( function () {
        $('#datatable').DataTable({
            ""language"": {
                ""lengthMenu"": ""Mostrar por pagina _MENU_"",
                ""zeroRecords"": ""Nenhum registro encontrado"",
                ""info"": ""Página _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nenhum registro encontrado"",
                ""search"": ""Buscar"",
                ""paginate"": {
                    ""first"": ""Primeiro"",
                    ""last"": ""Último"",
                    ""next"": ""Próximo"",
                    ""previous"": ""Anterior""
                }
            }
        });
    });
</script>

<table id=""datatable"" class=""table table-striped table-sm table-hover"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>Nome de Herói</th>
            <th>Data de Contratação</th>
            <th>Cursos que Leciona</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
         foreach (var item in Model.Professores)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["ProfessorID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 1440, "\"", 1460, 1);
#nullable restore
#line 48 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
WriteAttributeValue("", 1448, selectedRow, 1448, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NomeHeroi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataContratacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 62 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
                      
                        foreach (var curso in item.CursosAtribuidos)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
                       Write(curso.Curso.CursoID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("  ");
#nullable restore
#line 65 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
                                                Write(curso.Curso.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 66 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd6a47f6b06a9b1d28e7c0cee7f4bacd831e34811546", async() => {
                WriteLiteral("Editar / Adicionar Cursos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd6a47f6b06a9b1d28e7c0cee7f4bacd831e34813802", async() => {
                WriteLiteral("Apagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET\Projetos_Infnet\BokuNoHeroAcademia\BokuNoHeroAcademia\Views\Professor\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BokuNoHeroAcademia.Models.AcademiaViewModels.ProfessorCurso> Html { get; private set; }
    }
}
#pragma warning restore 1591