#pragma checksum "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c975610db0bb36711b4644ab4c621fe57ea255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DauSach_Sach), @"mvc.1.0.view", @"/Views/DauSach/Sach.cshtml")]
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
#line 1 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c975610db0bb36711b4644ab4c621fe57ea255", @"/Views/DauSach/Sach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_DauSach_Sach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Dausach>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietSach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var page = $(""#currentPage"").text()
            if (page == 0) {
                $(""#1"").addClass(""active"");
            }
            else {
                document.getElementById(page).classList.add(""active"");
            }

        })
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url(/images/bg_6.jpg);"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-0 bread"">Tủ sách</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-lg-10 order-md-last"">
                <div class=""mb-3"">  
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c975610db0bb36711b4644ab4c621fe57ea2555238", async() => {
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""col-md-6""></div>
                            <div class=""col-md-4"">
                                <input type=""text"" name=""tensp"" id=""tensp"" class=""form-control"" placeholder=""Nhập tên sản phẩm cần tìm"" style=""border-radius: 10px"">
                            </div>
                            <div class=""col-md-2"">
                                <button type=""submit"" class=""btn btn-primary py-3"">
                                    Tìm kiếm
                                </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 49 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-12 col-md-12 col-lg-4 ftco-animate d-flex"">
                            <div class=""product d-flex flex-column"">
                                <a href=""#"" class=""img-prod"">
                                    <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 2146, "\"", 2165, 1);
#nullable restore
#line 54 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
WriteAttributeValue("", 2152, item.Hinhanh, 2152, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"">
                                    <div class=""overlay""></div>
                                </a>
                                <div class=""text py-3 pb-4 px-3"">
                                    <div class=""d-flex"">
                                        <div class=""cat"">
                                            <span>");
#nullable restore
#line 60 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                             Write(item.IdTheloaiNavigation?.Tentheloai);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                        <div class=""rating"">
                                            <p class=""text-right mb-0"">
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                            </p>
                                        </div>
                                    </div>
                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c975610db0bb36711b4644ab4c621fe57ea2559945", async() => {
#nullable restore
#line 72 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                                                                              Write(item.Tensach);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                                                      WriteLiteral(item.IdDausach);

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
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 74 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                     if (item.Tongso == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"bottom-area d-flex px-3\">\r\n                                            <a  href=\"#\" class=\"add-to-cart text-center py-2 mr-1\"><span>HẾT HÀNG</span></a>\r\n                                        </p>\r\n");
            WriteLiteral("                                        <div class=\"pricing\">\r\n                                            <p class=\"price\"><span>");
#nullable restore
#line 81 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                                              Write(item.Trigia?.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                        </div><div style=""display: none"">
                                            <input type=""text"" id=""quantity"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                        </div>
");
#nullable restore
#line 85 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"pricing\">\r\n                                            <p class=\"price\"><span>");
#nullable restore
#line 89 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                                              Write(item.Trigia?.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                        </div>
                                        <div style=""display: none"">
                                            <input type=""text"" id=""quantity"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                        </div>
");
#nullable restore
#line 94 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 100 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row mt-5\">\r\n                    <div class=\"col text-center\">\r\n                        <div class=\"block-27\">\r\n                            <span style=\"display:none\" id=\"currentPage\">");
#nullable restore
#line 106 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                                                   Write(ViewBag.pageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <ul>\r\n");
#nullable restore
#line 108 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                 for (var i = 1; i <= ViewBag.totalPage; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li");
            BeginWriteAttribute("id", " id=\"", 5679, "\"", 5686, 1);
#nullable restore
#line 110 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
WriteAttributeValue("", 5684, i, 5684, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 5690, "\"", 5746, 1);
#nullable restore
#line 110 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
WriteAttributeValue("", 5697, Url.Action("Sach", "DauSach", new { page = @i }), 5697, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 111 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-4 col-lg-2"">
                <div class=""sidebar"">
                    <div class=""sidebar-box-2"">
                        <h2 class=""heading"">Categories</h2>
                        <div class=""fancy-collapse-panel"">
                            <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
                                <div class=""panel panel-default"">
                                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                                        <h4 class=""panel-title"">
");
#nullable restore
#line 127 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                             foreach (Theloai tl in (List<Theloai>)ViewBag.dsTheLoai)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 6729, "\"", 6800, 1);
#nullable restore
#line 129 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
WriteAttributeValue("", 6736, Url.Action("Sach", "DauSach", new { idtheloai = tl.IdTheloai }), 6736, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 130 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                               Write(tl.Tentheloai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n");
#nullable restore
#line 132 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 7019, "\"", 7056, 1);
#nullable restore
#line 133 "D:\Nam3\HK2\NMCNPM\doan\gith\QUANLYTHUVIEN1\test\Test\Views\DauSach\Sach.cshtml"
WriteAttributeValue("", 7026, Url.Action("Sach", "DauSach"), 7026, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Xem tất cả</a>
                                        </h4>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            WriteLiteral("<style>\r\n    .img-fluid{\r\n        max-width: 287px;\r\n        max-height: 287px;\r\n    }\r\n    .product .text h3 {\r\n        height: 50px;\r\n    }\r\n    .price span{\r\n        font-size: 18px;\r\n        color: #e600a0;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Dausach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
