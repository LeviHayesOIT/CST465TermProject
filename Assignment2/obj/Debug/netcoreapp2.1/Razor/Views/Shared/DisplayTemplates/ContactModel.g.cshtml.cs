#pragma checksum "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b85bd8c7f75fcd2ef4e6c7757dcaaafdb49249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_ContactModel), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/ContactModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/ContactModel.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_ContactModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b85bd8c7f75fcd2ef4e6c7757dcaaafdb49249", @"/Views/Shared/DisplayTemplates/ContactModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1408aaa82a1cc8ed8eb18efa9d7bedf644612ed2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_ContactModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment2.Models.ContactModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
  
    ViewData["Title"] = "ContactModel";

#line default
#line hidden
            BeginContext(90, 131, true);
            WriteLiteral("\r\n<h2>ContactModel</h2>\r\n\r\n<div>\r\n    <h4>ContactModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(222, 40, false);
#line 14 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(306, 36, false);
#line 17 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(342, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(386, 47, false);
#line 20 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayNameFor(model => model.phoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(433, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(477, 43, false);
#line 23 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayFor(model => model.phoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(520, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(564, 41, false);
#line 26 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 37, false);
#line 29 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(686, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(730, 43, false);
#line 32 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayNameFor(model => model.message));

#line default
#line hidden
            EndContext();
            BeginContext(773, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(817, 39, false);
#line 35 "C:\Users\ImHay\Documents\HTML\Assignment2\Views\Shared\DisplayTemplates\ContactModel.cshtml"
       Write(Html.DisplayFor(model => model.message));

#line default
#line hidden
            EndContext();
            BeginContext(856, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Models.ContactModel> Html { get; private set; }
    }
}
#pragma warning restore 1591