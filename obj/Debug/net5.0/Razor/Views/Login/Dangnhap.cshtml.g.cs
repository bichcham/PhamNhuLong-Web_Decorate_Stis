#pragma checksum "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Login\Dangnhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61a9d0e823a45051e3478471602c1767148c2661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Dangnhap), @"mvc.1.0.view", @"/Views/Login/Dangnhap.cshtml")]
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
#line 1 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61a9d0e823a45051e3478471602c1767148c2661", @"/Views/Login/Dangnhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41b37742cf350e2c7d5a13df020201896b51862", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Dangnhap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Login\Dangnhap.cshtml"
   
    Layout = "~/Views/Shared/_Layout.cshtml";
    Taikhoan tk = ViewBag.tk;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    Đăng nhập thành công.\r\n    Tài khoản: ");
#nullable restore
#line 7 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Login\Dangnhap.cshtml"
          Write(tk.MaTk);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n    SDT: ");
#nullable restore
#line 8 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Login\Dangnhap.cshtml"
    Write(tk.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
