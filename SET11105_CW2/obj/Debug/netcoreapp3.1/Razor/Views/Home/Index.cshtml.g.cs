#pragma checksum "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0b4dca1e80241c0682dc793329dc661a09324f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0b4dca1e80241c0682dc793329dc661a09324f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e93d83325607d1f1b051275a69a83b4377d4c65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SET11105_CW2.Models.Cause>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--generate a list of the cause object in order to use the context to our page-->\n");
            WriteLiteral("\n\n\n\n\n<h1>Popular Causes: </h1>\n\n<br />\n<br />\n\n<!--foreach loop in order to iterate through every record of the cause table and display it appropriatley through html with razor pages-->\n");
#nullable restore
#line 18 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
  
    foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"tweetable\" data-user=\"jqueryscript\" href=\"https://twitter.com/share\">\n        <h4>Subject:<span class=\"badge badge-secondary\"> ");
#nullable restore
#line 23 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
                                                    Write(item.subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n        <p class=\"causepPar tweetable\">\n            ");
#nullable restore
#line 25 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
       Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <div class=\"row\">\n            <div class=\"col-md-4 col-xs-6\"><h5>Signatories: <span id=\"signatures\" class=\"label label-primary\">");
#nullable restore
#line 28 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
                                                                                                         Write(item.numOfSignatures);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5></div>\n            <div class=\"col-md-4 col-xs-6\"><h5><span class=\"badge badge-secondary\">");
#nullable restore
#line 29 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
                                                                              Write(item.timeOfPublish);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5></div>
            <div class=""col-md-4 col-xs-6""><button onclick=""addSign()"" type=""button"" class=""btn btn-success pull-right"" id=""sign"">Sign the Cause</button></div>
            <div><a href=""https://twitter.com/share"" class=""twitter-share-button"" data-count=""vertical"">Tweet it</a></div>
        </div>
    </div>
");
            WriteLiteral("        <br />\n");
#nullable restore
#line 37 "/Users/vasileiosmilias/Desktop/SET11105_CW2/SET11105_CW2/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<br />


<!--Jquery script-->
<script src=""//ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js""></script>

<script>
    $('.twitter-share-button').attr('.causePar');
</script>

<!-- we create afunction where the message shows when the user clicks the ""sign"" button and we increase by 1 the number of signatoires-->
<script type=""text/javascript"">function addSign() {
    $(""#signatures"").append(""  Your vote was counted"");

    }</script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SET11105_CW2.Models.Cause>> Html { get; private set; }
    }
}
#pragma warning restore 1591
