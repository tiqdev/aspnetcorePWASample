#pragma checksum "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\TamamlananListe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d32a68ca02b97892bba79bb65fcc3f51b6e337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_TamamlananListe), @"mvc.1.0.view", @"/Views/Anasayfa/TamamlananListe.cshtml")]
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
#line 1 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\_ViewImports.cshtml"
using tiqpwa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\_ViewImports.cshtml"
using tiqpwa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d32a68ca02b97892bba79bb65fcc3f51b6e337", @"/Views/Anasayfa/TamamlananListe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b07fdeb0b7afcf4528b847b82eb3cb385d801ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_TamamlananListe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/karaman.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\TamamlananListe.cshtml"
  
    ViewData["Title"] = "TamamlananListe";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"margin-top:20px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35d32a68ca02b97892bba79bb65fcc3f51b6e3374163", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 215, "\"", 254, 1);
#nullable restore
#line 8 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\TamamlananListe.cshtml"
WriteAttributeValue("", 222, Url.Action("Index", "Anasayfa"), 222, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""waves-effect waves-light btn-small red lighten-1 secondary-content"" style=""margin-top:5px""><b style=""color:white""> Geri </b></a>
    </div>
<div class=""col s12"" style=""margin-top:10px"">

    <ul class=""collection with-header"">
        <li>
            <div class=""collection-header center-align"">
                <b style=""font-size:18px"">TAMAMLANAN İŞLER </b>
           </div>
            <!--listenin her bir elemanı tıklanabilir olacak ve ayrıntılarını verecek.-->
            <div class=""collection-item"">
                <p><b style=""color: red""> Proje Adı:</b> <b> A Projesi </b></p>
                <p><b style=""color: red""> Tarih :</b> <b> 01.01.2020  </b></p>
                <p><b style=""color: red""> Tamamlanma Tarihi :</b> <b> 01.01.2020</b></p>
                <p><b style=""color: red""> Konu  :</b> <b> Devreye Alma </b></p>
                <p><b style=""color: red""> İlgili Personel :</b> <b> Enes Zeybekoğlu </b></p>
            </div>

            <!--Burada foreach içerisinde broj");
            WriteLiteral(@"eler dönecek kendi kendine olusacak-->
            <div class=""collection-item"">
                <p><b style=""color: red""> Proje Adı:</b> <b> B Projesi </b></p>
                <p><b style=""color: red""> Tarih :</b> <b> 01.01.2020  </b></p>
                <p><b style=""color: red""> Tamamlanma Tarihi :</b> <b> 01.01.2020</b></p>
                <p><b style=""color: red""> Konu  :</b> <b> Devreye Alma </b></p>
                <p><b style=""color: red""> İlgili Personel :</b> <b> Enes Zeybekoğlu </b></p>
            </div>

            <div class=""collection-item"">
                <p><b style=""color: red""> Proje Adı:</b> <b> C Projesi </b></p>
                <p><b style=""color: red""> Tarih :</b> <b> 01.01.2020  </b></p>
                <p><b style=""color: red""> Tamamlanma Tarihi :</b> <b> 01.01.2020</b></p>
                <p><b style=""color: red""> Konu  :</b> <b> Devreye Alma </b></p>
                <p><b style=""color: red""> İlgili Personel :</b> <b> Enes Zeybekoğlu </b></p>
            </div>

  ");
            WriteLiteral(@"          <div class=""collection-item"">
                <p><b style=""color: red""> Proje Adı:</b> <b> D Projesi </b></p>
                <p><b style=""color: red""> Tarih :</b> <b> 01.01.2020  </b></p>
                <p><b style=""color: red""> Tamamlanma Tarihi :</b> <b> 01.01.2020</b></p>
                <p><b style=""color: red""> Konu  :</b> <b> Devreye Alma </b></p>
                <p><b style=""color: red""> İlgili Personel :</b> <b> Enes Zeybekoğlu </b></p>
            </div>
        </li>
    </ul>
</div>
");
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
