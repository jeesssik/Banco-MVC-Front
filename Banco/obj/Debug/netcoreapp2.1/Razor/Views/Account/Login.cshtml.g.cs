#pragma checksum "E:\Banco-Front-master\Banco\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f04dfa8652d43c89b551db1dc8942e56487c929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "E:\Banco-Front-master\Banco\Views\_ViewImports.cshtml"
using Banco;

#line default
#line hidden
#line 2 "E:\Banco-Front-master\Banco\Views\_ViewImports.cshtml"
using Banco.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f04dfa8652d43c89b551db1dc8942e56487c929", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93cf87558d215c927d918474522b99ff9dbc59c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\Banco-Front-master\Banco\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login Usuarios";

#line default
#line hidden
            BeginContext(48, 265, true);
            WriteLiteral(@"<!-- banner -->
<div class=""banner"">
    <div class=""header"">
        <div class=""container"">
            <nav class=""navbar navbar-default"">
                <div class=""navbar-header"">
                    <div class=""w3layouts-logo"">
                        <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 313, "\"", 348, 1);
#line 12 "E:\Banco-Front-master\Banco\Views\Account\Login.cshtml"
WriteAttributeValue("", 320, Url.Action("Index", "Home"), 320, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(349, 568, true);
            WriteLiteral(@">Siembra  <span>Online</span></a></h1>
                    </div>
                </div>
            </nav>
        </div>
    </div>
</div>
<!-- //banner -->

<div class=""limiter"">
    <div class=""container-login100"" style=""background-image: url('/images/bg-011.jpg');"">
        <div class=""wrap-login100 p-t-30 p-b-50"">
            <span class=""login100-form-title p-b-41"">
                Login
            </span>

            <div class=""login100-form-title p-b-41"">
                <div class="""">
                    <div class="""">
                        <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 917, "\"", 960, 1);
#line 31 "E:\Banco-Front-master\Banco\Views\Account\Login.cshtml"
WriteAttributeValue("", 924, Url.Action("LoginAdmin", "Account"), 924, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(961, 177, true);
            WriteLiteral(" class=\"linka\">Admin</a></h1>\n                    </div>\n                </div>\n\n                <div class=\"\">\n                    <div class=\"\">\n                        <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1138, "\"", 1183, 1);
#line 37 "E:\Banco-Front-master\Banco\Views\Account\Login.cshtml"
WriteAttributeValue("", 1145, Url.Action("LoginUsuario", "Account"), 1145, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1184, 134, true);
            WriteLiteral(" class=\"linka\">Usuarios</a></h1>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
            EndContext();
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
