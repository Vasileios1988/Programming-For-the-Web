#pragma checksum "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cfd95182201d200b775ee4b51da735d773728af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateCause), @"mvc.1.0.view", @"/Views/Home/CreateCause.cshtml")]
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
#line 1 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/_ViewImports.cshtml"
using SET11105_CW2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/_ViewImports.cshtml"
using SET11105_CW2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfd95182201d200b775ee4b51da735d773728af", @"/Views/Home/CreateCause.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e93d83325607d1f1b051275a69a83b4377d4c65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateCause : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SET11105_CW2.Models.Cause>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
  
    ViewData["Title"] = "Create A Cause";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n<br />\n<br />\n<br />\n\n\n<!--create the form and connect to the correct object tha represents a table in the database-->\n");
#nullable restore
#line 15 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
 using (Html.BeginForm())
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\n\n        <h5>Please type the subject</h5>\n        <p>Racism - Sexism - Tax Avoidance - Environemt</p>\n        <div> <!--pass and validate the right informtaion into the database - subject field-->\n            ");
#nullable restore
#line 27 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
       Write(Html.EditorFor(model => model.subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 28 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
       Write(Html.ValidationMessageFor(model => model.subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n        <br />\n\n        <h5>Please type cause:</h5>\n\n        <div>\n            <!--pass and validate the right informtaion into the database - description field-->\n            ");
#nullable restore
#line 37 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
       Write(Html.EditorFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 38 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
       Write(Html.ValidationMessageFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n\n\n\n        <br />\n\n        <p>\n            <input type=\"submit\" class=\"btn btn-success\" value=\"Submit\" />\n        </p>\n\n\n\n    </fieldset>\n");
            WriteLiteral("    <br />\n");
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 58 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"
   Write(Html.ActionLink("Back to HomePage", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 60 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/CreateCause.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SET11105_CW2.Models.Cause> Html { get; private set; }
    }
}
#pragma warning restore 1591
