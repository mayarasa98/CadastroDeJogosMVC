#pragma checksum "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6603b22adba4cd759b2e2b8801e93ac6c64a7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogo_Form), @"mvc.1.0.view", @"/Views/Jogo/Form.cshtml")]
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
#line 1 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\_ViewImports.cshtml"
using Cadastro_de_jogos_MVC_16._1_Mayara;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\_ViewImports.cshtml"
using Cadastro_de_jogos_MVC_16._1_Mayara.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6603b22adba4cd759b2e2b8801e93ac6c64a7d", @"/Views/Jogo/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b282380259029b6c5c0a097791877f01d1c72761", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Jogo_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JogoViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Salvar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml"
  
 Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Cadastro de Jogos</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6603b22adba4cd759b2e2b8801e93ac6c64a7d4475", async() => {
                WriteLiteral("\r\n\r\n <label for=\"Id\" class=\"control-label\">Id</label>\r\n <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 225, "\"", 242, 1);
#nullable restore
#line 10 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml"
WriteAttributeValue("", 233, Model.Id, 233, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n <br />\r\n\r\n <label for=\"Descricao\" class=\"control-label\">Descrição do jogo</label>\r\n <input type=\"text\" Name=\"Descricao\"");
                BeginWriteAttribute("value", " value=\"", 368, "\"", 392, 1);
#nullable restore
#line 14 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml"
WriteAttributeValue("", 376, Model.Descricao, 376, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n <br />\r\n\r\n <label for=\"CategoriaId\" class=\"control-label\">Categoria</label>\r\n <input type=\"text\" Name=\"CategoriaId\"");
                BeginWriteAttribute("value", " value=\"", 514, "\"", 540, 1);
#nullable restore
#line 18 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml"
WriteAttributeValue("", 522, Model.CategoriaId, 522, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n <br />\r\n\r\n <label for=\"DataAquisicao\" class=\"control-label\">Data de aquisição</label>\r\n <input type=\"date\" Name=\"DataAquisicao\"");
                BeginWriteAttribute("value", " value=\"", 674, "\"", 725, 1);
#nullable restore
#line 22 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml"
WriteAttributeValue("", 682, Model.DataAquisicao.ToString("yyyy-MM-dd"), 682, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n <br />\r\n\r\n <label for=\"ValorLocacao\" class=\"control-label\">Valor de locação</label>\r\n <input type=\"number\" Name=\"ValorLocacao\"");
                BeginWriteAttribute("value", " value=\"", 858, "\"", 885, 1);
#nullable restore
#line 26 "C:\Users\mayar\Downloads\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_20.1_Mayara\Cadastro_de_jogos_MVC_16.1_Mayara\Views\Jogo\Form.cshtml"
WriteAttributeValue("", 866, Model.ValorLocacao, 866, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n <br />\r\n\r\n <input type=\"submit\" value=\"Salvar dados\" />\r\n <br />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JogoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
