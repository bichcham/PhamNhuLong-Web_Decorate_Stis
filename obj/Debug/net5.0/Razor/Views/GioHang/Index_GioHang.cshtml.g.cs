#pragma checksum "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab1b17d2dae56e13565233afae28e0304506f141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index_GioHang), @"mvc.1.0.view", @"/Views/GioHang/Index_GioHang.cshtml")]
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
#line 1 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1b17d2dae56e13565233afae28e0304506f141", @"/Views/GioHang/Index_GioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41b37742cf350e2c7d5a13df020201896b51862", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index_GioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/DonDatHang/Index_DDH"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
  
    List<GioHang> list_cart_item = (List<GioHang>)ViewBag.carts;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""breadcrumb-area"" style=""height:150px"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <ul>
                            <li>
                                <a href=""index.html"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Giỏ hàng</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 30 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
     if (list_cart_item == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center p-100\" style=\"height:50px\">Giỏ hàng trống. Cùng mua sắm nào!</div>\r\n");
#nullable restore
#line 33 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cart-area section-space-y-axis-100\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                                \r\n");
#nullable restore
#line 41 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                               
                                var tongtien = 0;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"table-content table-responsive\">\r\n                                    <table class=\"table\">\r\n                                        <thead>\r\n                                            <tr>\r\n");
            WriteLiteral(@"                                                <th class=""product_remove"">Xóa</th>
                                                <th class=""product-thumbnail"">Hình ảnh</th>
                                                <th class=""cart-product-name"">Tên sản phẩm</th>
                                                <th class=""product-price"">Giá sản phẩm</th>
                                                <th class=""product-quantity"">Số lượng</th>
                                                <th class=""product-subtotal"">Tổng tiền</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 58 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                              
                                                var stt = 0;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                             foreach (var item in list_cart_item)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n");
            WriteLiteral("                                                <td class=\"product_remove\">\r\n");
#nullable restore
#line 66 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                      
                                                        stt += 1;
                                                        var id_del = "delete_cart" + @stt.ToString();
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1b17d2dae56e13565233afae28e0304506f1418936", async() => {
                WriteLiteral("\r\n                                                        <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3383, "\"", 3437, 3);
                WriteAttributeValue("", 3393, "document.getElementById(\'", 3393, 25, true);
#nullable restore
#line 71 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 3418, id_del, 3418, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3425, "\').submit();", 3425, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <i class=\"pe-7s-close\" title=\"Remove\"></i>\r\n                                                        </a>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3235, "/GioHang/Delete_cart?product_id=", 3235, 32, true);
#nullable restore
#line 70 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 3267, item.sanpham.MaSp, 3267, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 70 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 3305, id_del, 3305, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                </td>
                                                <td class=""product-thumbnail"">
                                                    <a href=""javascript:void(0)"">
                                                        <img");
            BeginWriteAttribute("src", " src=\"", 3948, "\"", 3967, 1);
#nullable restore
#line 79 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 3954, item.hinhanh, 3954, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3968, "\"", 3987, 1);
#nullable restore
#line 79 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 3974, item.hinhanh, 3974, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                                                    </a>\r\n                                                </td>\r\n                                                <td class=\"product-name\"><a");
            BeginWriteAttribute("href", " href=\"", 4199, "\"", 4232, 3);
            WriteAttributeValue("", 4206, "/{", 4206, 2, true);
#nullable restore
#line 82 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 4208, item.sanpham.MaSp, 4208, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4226, "}.html", 4226, 6, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                                                                         Write(item.sanpham.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 83 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                                                          Write(item.sanpham.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                                                <td class=\"quantity\">\r\n");
#nullable restore
#line 85 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                      
                                                        var sl = @item.Soluong;
                                                        var id_minus = "minus_cart" + @stt.ToString();
                                                        var id_plus = "plus_cart" + @stt.ToString();
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"row p-5\">\r\n                                                        <div class=\"col-4 dec qtybutton\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1b17d2dae56e13565233afae28e0304506f14115690", async() => {
                WriteLiteral("\r\n                                                                <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5299, "\"", 5355, 3);
                WriteAttributeValue("", 5309, "document.getElementById(\'", 5309, 25, true);
#nullable restore
#line 93 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 5334, id_minus, 5334, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5343, "\').submit();", 5343, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                    <i class=\"fa fa-minus\"></i>\r\n                                                                </a>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5131, "/GioHang/Minus_quantity?product_id=", 5131, 35, true);
#nullable restore
#line 92 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5166, item.sanpham.MaSp, 5166, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5184, "&sl=", 5184, 4, true);
#nullable restore
#line 92 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5188, sl, 5188, 3, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 92 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5211, id_minus, 5211, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </div>\r\n                                                        <div class=\"col-4 cart-plus-minus-box\">");
#nullable restore
#line 98 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                                                          Write(sl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                        <div class=\"col-4 inc qtybutton\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1b17d2dae56e13565233afae28e0304506f14119953", async() => {
                WriteLiteral("\r\n                                                                <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6096, "\"", 6151, 3);
                WriteAttributeValue("", 6106, "document.getElementById(\'", 6106, 25, true);
#nullable restore
#line 101 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 6131, id_plus, 6131, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6139, "\').submit();", 6139, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                    <i class=\"fa fa-plus\"></i>\r\n                                                                </a>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5930, "/GioHang/Plus_quantity?product_id=", 5930, 34, true);
#nullable restore
#line 100 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5964, item.sanpham.MaSp, 5964, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5982, "&sl=", 5982, 4, true);
#nullable restore
#line 100 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5986, sl, 5986, 3, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 100 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 6009, id_plus, 6009, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                                                </td>
");
#nullable restore
#line 110 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                  
                                                    var sump = @sl * @item.sanpham.GiaTien;
                                                    tongtien += Convert.ToInt32(sump);
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td class=\"product-subtotal\"><span class=\"amount\">");
#nullable restore
#line 114 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                                                             Write(sump.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 116 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <div class=""coupon-all"">
                                            <div class=""coupon"">
                                                <input id=""coupon_code"" class=""input-text"" name=""coupon_code""");
            BeginWriteAttribute("value", " value=\"", 7703, "\"", 7711, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Mã voucher"" type=""text"">
                                                <input class=""button mt-xxs-30"" name=""apply_coupon"" value=""Áp dụng"" type=""submit"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-5 ml-auto"">
                                        <div class=""cart-page-total"">
                                            <h2>Thành tiền</h2>
                                            <ul>
                                                <li>Tổng tiền: <span>");
#nullable restore
#line 135 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
                                                                Write(tongtien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></li>                                                \r\n                                            </ul>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1b17d2dae56e13565233afae28e0304506f14126979", async() => {
                WriteLiteral("\r\n                                                <a href=\"#\" onclick=\"document.getElementById(\'checkout\').submit();\">Thanh toán</a>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                                </div>

                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 149 "F:\Nam 3\Famewor\DOAN\PhamNhuLong-Web_Decorate_Stis\Views\GioHang\Index_GioHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </main>\r\n<!-- Main Content Area End Here -->");
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
