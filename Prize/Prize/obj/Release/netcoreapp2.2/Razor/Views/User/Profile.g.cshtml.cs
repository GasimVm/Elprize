#pragma checksum "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0562798ae672b747d66da54d530675556c1f79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
#line 1 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\_ViewImports.cshtml"
using Prize;

#line default
#line hidden
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\_ViewImports.cshtml"
using Prize.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0562798ae672b747d66da54d530675556c1f79", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c9426c31ee4617d416847aaccd2722e64dd104", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prize.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dashboard/authenticate/assets/images/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(116, 347, true);
            WriteLiteral(@"<style>
    .imags {
        width: 200px;
        height: 200px;
        box-sizing: border-box;
    }

    p {
        font-size: 15px;
    }

    .pad {
        padding: 10px 0;
        box-sizing: border-box;
    }
</style>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4 col-xs-12 "">
            ");
            EndContext();
            BeginContext(463, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb0562798ae672b747d66da54d530675556c1f794478", async() => {
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
            EndContext();
            BeginContext(549, 79, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-8 col-xs-12 pad\">\r\n            <p>");
            EndContext();
            BeginContext(629, 14, false);
#line 28 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
          Write(Model.Firstame);

#line default
#line hidden
            EndContext();
            BeginContext(643, 22, true);
            WriteLiteral(":</p>\r\n            <p>");
            EndContext();
            BeginContext(666, 14, false);
#line 29 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
          Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(680, 22, true);
            WriteLiteral(":</p>\r\n            <p>");
            EndContext();
            BeginContext(703, 14, false);
#line 30 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
          Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(717, 22, true);
            WriteLiteral(":</p>\r\n            <p>");
            EndContext();
            BeginContext(740, 11, false);
#line 31 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(751, 22, true);
            WriteLiteral(":</p>\r\n            <p>");
            EndContext();
            BeginContext(774, 10, false);
#line 32 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
          Write(Model.Cash);

#line default
#line hidden
            EndContext();
            BeginContext(784, 539, true);
            WriteLiteral(@":</p>
        </div>
    </div>
</div>





<h1 style=""text-align:center"">  User action</h1>

<table id=""table"" class=""table table-hover table-bordered "">
    <thead>
        <tr>
            <th>Username<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Action name<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Date<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>

        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 54 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
         if (Model != null)
        {

            

#line default
#line hidden
#line 57 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
             foreach (var item in ViewBag.Log)
            {


#line default
#line hidden
            BeginContext(1430, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1477, 14, false);
#line 61 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
                   Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1523, 15, false);
#line 62 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
                   Write(item.ActionName);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1570, 14, false);
#line 63 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
                   Write(item.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 65 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
            }

#line default
#line hidden
#line 65 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\Profile.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1640, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1685, 510, true);
                WriteLiteral(@"

    <script type=""text/javascript"">

        var table = $('#table').DataTable({

            ""order"": [[0, ""desc""]]
        });
        table.columns().every(function () {
            var that = this;
            $('input', this.header()).on('keyup change', function () {
                if (that.search() !== this.value) {
                    that
                        .search(this.value)
                        .draw();
                }
            });
        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prize.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
