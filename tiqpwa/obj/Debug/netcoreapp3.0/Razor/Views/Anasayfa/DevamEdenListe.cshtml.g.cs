#pragma checksum "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c1b79d4eb44395fe8c997d77e05681b4730dc79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_DevamEdenListe), @"mvc.1.0.view", @"/Views/Anasayfa/DevamEdenListe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1b79d4eb44395fe8c997d77e05681b4730dc79", @"/Views/Anasayfa/DevamEdenListe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b07fdeb0b7afcf4528b847b82eb3cb385d801ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_DevamEdenListe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
  
    ViewData["Title"] = "DevamEdenListe";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"margin-top:20px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c1b79d4eb44395fe8c997d77e05681b4730dc794148", async() => {
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
            WriteLiteral("\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 202, "\"", 241, 1);
#nullable restore
#line 8 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
WriteAttributeValue("", 209, Url.Action("Index", "Anasayfa"), 209, 32, false);

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
                <b style=""font-size:18px"">DEVAM EDEN İŞLER </b>
               </div>

            <!-- Burada foreach döngüsü icinde bir devameden nesnesi gelecek. bu nesne içindeki id ile inceleme sayfası acılacak-->
            <div class=""collection-item"">
                <a");
            BeginWriteAttribute("href", " href=\"", 838, "\"", 902, 1);
#nullable restore
#line 22 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
WriteAttributeValue("", 845, Url.Action("DevamEdenAyrinti","Anasayfa",new { id =  2}), 845, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <p><b style=""color:red""> Proje Adı: </b><b>A Projesi </b></p>
                    <p><span class=""badge secondary-content"" style=""margin-top:10px ""><i class=""material-icons"">chevron_right</i></span></p>
                    <p><b style=""color:red""> Tarih : </b><b>01.01.2020  </b></p>
                    <p><b style=""color:red""> Konu  : </b><b>Devreye Alma </b></p>
                    <p><b style=""color:red""> İlgili Personel : </b><b>Enes Zeybekoğlu </b></p>
                </a>
                <!--
        <a class=""waves-effect waves-light btn-small lime lighten-2 secondary-content"" style=""margin-top:-10px"" href=""");
#nullable restore
#line 30 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
                                                                                                                 Write(Url.Action("DevamEdenListe","Anasayfa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><b>Güncelle</b></a>\r\n        <br />\r\n        -->\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"collection-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1733, "\"", 1797, 1);
#nullable restore
#line 38 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
WriteAttributeValue("", 1740, Url.Action("DevamEdenAyrinti","Anasayfa",new { id =  2}), 1740, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <p><b style=""color:red""> Proje Adı: </b><b>A Projesi </b></p>
                    <p><span class=""badge secondary-content"" style=""margin-top:10px ""><i class=""material-icons"">chevron_right</i></span></p>
                    <p><b style=""color:red""> Tarih : </b><b>01.01.2020  </b></p>
                    <p><b style=""color:red""> Konu  : </b><b>Devreye Alma </b></p>
                    <p><b style=""color:red""> İlgili Personel : </b><b>Enes Zeybekoğlu </b></p>
                </a>
                <!--
        <a class=""waves-effect waves-light btn-small lime lighten-2 secondary-content"" style=""margin-top:-10px"" href=""");
#nullable restore
#line 46 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
                                                                                                                 Write(Url.Action("DevamEdenListe","Anasayfa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><b>Güncelle</b></a>\r\n        <br />\r\n        -->\r\n            </div>\r\n            <div class=\"collection-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2622, "\"", 2686, 1);
#nullable restore
#line 51 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
WriteAttributeValue("", 2629, Url.Action("DevamEdenAyrinti","Anasayfa",new { id =  2}), 2629, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <p><b style=""color:red""> Proje Adı: </b><b>A Projesi </b></p>
                    <p><span class=""badge secondary-content"" style=""margin-top:10px ""><i class=""material-icons"">chevron_right</i></span></p>
                    <p><b style=""color:red""> Tarih : </b><b>01.01.2020  </b></p>
                    <p><b style=""color:red""> Konu  : </b><b>Devreye Alma </b></p>
                    <p><b style=""color:red""> İlgili Personel : </b><b>Enes Zeybekoğlu </b></p>
                </a>
                <!--
                <a class=""waves-effect waves-light btn-small lime lighten-2 secondary-content"" style=""margin-top:-10px"" href=""");
#nullable restore
#line 59 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
                                                                                                                         Write(Url.Action("DevamEdenListe","Anasayfa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><b>Güncelle</b></a>\r\n                <br />\r\n                -->\r\n            </div>\r\n            <div class=\"collection-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3535, "\"", 3599, 1);
#nullable restore
#line 64 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
WriteAttributeValue("", 3542, Url.Action("DevamEdenAyrinti","Anasayfa",new { id =  2}), 3542, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <p><b style=""color:red""> Proje Adı: </b><b>A Projesi </b></p>
                    <p><span class=""badge secondary-content"" style=""margin-top:10px ""><i class=""material-icons"">chevron_right</i></span></p>
                    <p><b style=""color:red""> Tarih : </b><b>01.01.2020  </b></p>
                    <p><b style=""color:red""> Konu  : </b><b>Devreye Alma </b></p>
                    <p><b style=""color:red""> İlgili Personel : </b><b>Enes Zeybekoğlu </b></p>
                </a>
                <!--
                <a class=""waves-effect waves-light btn-small lime lighten-2 secondary-content"" style=""margin-top:-10px"" href=""");
#nullable restore
#line 72 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
                                                                                                                         Write(Url.Action("DevamEdenListe","Anasayfa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><b>Güncelle</b></a>\r\n                <br />\r\n                -->\r\n            </div>\r\n            <div class=\"collection-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4448, "\"", 4512, 1);
#nullable restore
#line 77 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
WriteAttributeValue("", 4455, Url.Action("DevamEdenAyrinti","Anasayfa",new { id =  2}), 4455, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <p><b style=""color:red""> Proje Adı: </b><b>A Projesi </b></p>
                    <p><span class=""badge secondary-content"" style=""margin-top:10px ""><i class=""material-icons"">chevron_right</i></span></p>
                    <p><b style=""color:red""> Tarih : </b><b>01.01.2020  </b></p>
                    <p><b style=""color:red""> Konu  : </b><b>Devreye Alma </b></p>
                    <p><b style=""color:red""> İlgili Personel : </b><b>Enes Zeybekoğlu </b></p>
                </a>
                <!--
                <a class=""waves-effect waves-light btn-small lime lighten-2 secondary-content"" style=""margin-top:-10px"" href=""");
#nullable restore
#line 85 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenListe.cshtml"
                                                                                                                         Write(Url.Action("DevamEdenListe","Anasayfa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><b>Güncelle</b></a>\r\n                <br />\r\n                -->\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</div>\r\n");
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
