#pragma checksum "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a63560fe3dd6c072756275857e62680b062870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SignUp), @"mvc.1.0.view", @"/Views/Home/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a63560fe3dd6c072756275857e62680b062870", @"/Views/Home/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e93d83325607d1f1b051275a69a83b4377d4c65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SET11105_CW2.Models.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
  
    ViewData["Title"] = "Sign Up";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Please Sign Up:</h2>\n\n<!--below is the form asking the user for the relevant information in order to pass and store the information to the database and create a new user-->\n\n");
#nullable restore
#line 10 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
 using (Html.BeginForm())
{

  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\n    <legend>Become A Member</legend>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 21 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
   Write(Html.LabelFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 23 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.EditorFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 24 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 31 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
   Write(Html.LabelFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 33 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.EditorFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 34 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 41 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
   Write(Html.LabelFor(model => model.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 43 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.EditorFor(model => model.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 44 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 51 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
   Write(Html.LabelFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 53 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.EditorFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 54 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div>\n        <label for=\"email\">Confirm your email</label>\n        <div class=\"col-md-3\">\n            <input type=\"email\"  id=\"email\" />\n        </div>\n    </div>\n\n\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 68 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
   Write(Html.LabelFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 70 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.EditorFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 71 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>

    <div>
        <label for=""psw"">Confirm your password</label>
        <div class=""col-md-3"">
            <input type=""password"" id=""psw"" />
        </div>
    </div>

    <br />

    <p>
        <input type=""submit"" value=""Sign Up"" />
    </p>

</fieldset>
");
            WriteLiteral("<div>\n    ");
#nullable restore
#line 91 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"
Write(Html.ActionLink("Back to HomePage", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
#nullable restore
#line 93 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/SignUp.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SET11105_CW2.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591