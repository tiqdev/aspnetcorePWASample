#pragma checksum "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c72013d25dfb82b39935994fbf5e53eaf72a936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Index), @"mvc.1.0.view", @"/Views/Anasayfa/Index.cshtml")]
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
#nullable restore
#line 6 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
using tiqpwa.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
using tiqpwa.ExtensionMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c72013d25dfb82b39935994fbf5e53eaf72a936", @"/Views/Anasayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b07fdeb0b7afcf4528b847b82eb3cb385d801ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tiqpwa.ViewModels.AnasayfaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/karaman.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tarih"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("datepicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TariheGoreGetir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CikisYap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function () {
        $('.datepicker').datepicker({
            i18n: {
                months: [
                    'Ocak',
                    'Şubat',
                    'Mart',
                    'Nisan',
                    'Mayıs',
                    'Haziran',
                    'Temmuz',
                    'Ağustos',
                    'Eylül',
                    'Ekim',
                    'Kasım',
                    'Aralık'
                ],
                monthsShort: [
                    'Oca',
                    'Şub',
                    'Mar',
                    'Nis',
                    'May',
                    'Haz',
                    'Tem',
                    'Ağu',
                    'Eyl',
                    'Eki',
                    'Kas',
                    'Ara'
                ],
                weekdays: [
                    'Pazar',
                    'Pazartesi',
                    'Salı',");
            WriteLiteral(@"
                    'Çarşamba',
                    'Perşembe',
                    'Cuma',
                    'Cumartesi'

                ],
                weekdaysShort: [
                    'Pz',
                    'Pzt',
                    'Sl',
                    'Çrş',
                    'Prş',
                    'Cm',
                    'Cmt'
                ],
                weekdaysAbbrev: ['P', 'Pzt', 'S', 'Ç', 'Pr', 'C', 'Cts'],
                cancel: 'Geri',
                clear: 'Temizle',
                done: 'Tamam'
            },
            firstDay: 1,
            autoClose: true
        });
    });
</script>
<script>
    $(document).ready(function () {
        $('.modal').modal();
    })
</script>


<div class=""center"" style=""margin-top:30px"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c72013d25dfb82b39935994fbf5e53eaf72a9368507", async() => {
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
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"col s6 m6\" style=\"margin-top:20px\">\r\n    <p>\r\n        <b style=\"font-family: \'Roboto Condensed\', sans-serif; color: red;\">Hoşgeldiniz,</b> <b style=\"color: black; font-family: \'Roboto Condensed\', sans-serif;\">\r\n\r\n");
#nullable restore
#line 86 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
              
                Kullanici kullanıcı = Context.Session.GetObject<Kullanici>("KullanıcıObjesi");
                var isimsoyisim = kullanıcı.KullaniciAdi.ToUpper() + " " + kullanıcı.KullaniciSoyadi.ToUpper();
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
           Write(isimsoyisim);

#line default
#line hidden
#nullable disable
            WriteLiteral("        </b>\r\n    </p>\r\n</div>\r\n\r\n<div class=\"col s12 z-depth-3\" style=\"margin-top:10px\">\r\n    <ul class=\"collapsible\">\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2790, "\"", 2835, 1);
#nullable restore
#line 98 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 2797, Url.Action("YeniIsKaydi", "Anasayfa"), 2797, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">add</i>
                    <b>YENİ İŞ KAYDI EKLE</b>
                </div>
            </a>
        </li>
        <li>
            <a");
            BeginWriteAttribute("href", " href=\"", 3125, "\"", 3173, 1);
#nullable restore
#line 106 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 3132, Url.Action("YeniBakimKaydi", "Anasayfa"), 3132, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">add</i>
                    <b>YENİ BAKIM KAYDI EKLE</b>
                </div>
            </a>
        </li>
        <li>
            <a");
            BeginWriteAttribute("href", " href=\"", 3466, "\"", 3514, 1);
#nullable restore
#line 114 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 3473, Url.Action("DevamEdenListe", "Anasayfa"), 3473, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">chevron_right</i>
                    <b>DEVAM EDEN İŞLER</b>
                    <span class=""new badge red"" data-badge-caption=""Proje""><b style=""color: white"">");
#nullable restore
#line 118 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
                                                                                              Write(Model.DevamEdenSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                </div>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3944, "\"", 3990, 1);
#nullable restore
#line 123 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 3951, Url.Action("BeklemeListe", "Anasayfa"), 3951, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">chevron_right</i>
                    <b>BEKLEMEDE OLAN İŞLER</b>
                    <span class=""new badge red"" data-badge-caption=""Proje""><b style=""color: white"">");
#nullable restore
#line 127 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
                                                                                              Write(Model.BeklemeSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                </div>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4422, "\"", 4471, 1);
#nullable restore
#line 132 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 4429, Url.Action("TamamlananListe", "Anasayfa"), 4429, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">chevron_right</i>
                    <b>TAMAMLANAN İŞLER</b>
                    <span class=""new badge red"" data-badge-caption=""Proje""><b style=""color: white"">");
#nullable restore
#line 136 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
                                                                                              Write(Model.TamamlananSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                </div>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4902, "\"", 4950, 1);
#nullable restore
#line 141 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 4909, Url.Action("IptalOlanListe", "Anasayfa"), 4909, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">chevron_right</i>
                    <b>İPTAL OLAN İŞLER</b>
                    <span class=""new badge red"" data-badge-caption=""Proje""><b style=""color: white"">");
#nullable restore
#line 145 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
                                                                                              Write(Model.IptalOlanSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                </div>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5380, "\"", 5425, 1);
#nullable restore
#line 150 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 5387, Url.Action("BakimTakvim", "Anasayfa"), 5387, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                <div class=""collapsible-header"">
                    <i class=""material-icons"">chevron_right</i>
                    <b>BAKIM TAKVİMİ</b>
                </div>
            </a>
        </li>
        <li>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c72013d25dfb82b39935994fbf5e53eaf72a93617178", async() => {
                WriteLiteral("\r\n                <div class=\"collapsible-header\">\r\n                    <div class=\"input-field\" style=\"margin-left:20px\">\r\n                        <label for=\"tarih\"><b>TARİHE GÖRE GETİR....</b></label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c72013d25dfb82b39935994fbf5e53eaf72a93617678", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 162 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tarih);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\Index.cshtml"
                                                                 WriteLiteral(Model.Tarih.ToShortDateString());

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <button class=""waves-effect waves-light btn-flat"" style=""margin-top: 20px; margin-left: 10px;"" type=""submit"" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})"">
                        <i class=""material-icons""> search </i>
                    </button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n\r\n    </ul>\r\n</div>\r\n<div id=\"modal_tamamla\" class=\"modal\">\r\n    <div class=\"modal-content\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c72013d25dfb82b39935994fbf5e53eaf72a93621922", async() => {
                WriteLiteral(@"
            <div class=""center-align"">
                <h5>
                    Çıkış Yapmak İstediğinizden Emin Misiniz?
                </h5>
            </div>
            <div class=""center-align"">
                <button class=""waves-effect waves-light btn grey darken-3 "" style=""margin-top: 5px"" onclick=""M.toast({ html: 'Çıkış Yapılıyor...' })""><b style=""color: white""> Çıkış Yap </b></button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col s12 center-align\">\r\n    <a href=\"#modal_tamamla\" class=\"waves-effect waves-light btn-small modal-trigger grey darken-3\" style=\"margin-top:5px\"><b style=\"color:white\">Çıkış Yap</b></a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tiqpwa.ViewModels.AnasayfaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
