#pragma checksum "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c53c7d6eef972dd44de053bc263b0e1e08e84b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Details), @"mvc.1.0.view", @"/Views/Locations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Locations/Details.cshtml", typeof(AspNetCore.Views_Locations_Details))]
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
#line 1 "E:\Mvc\Core\Meseum\Meseum\Views\_ViewImports.cshtml"
using Meseum;

#line default
#line hidden
#line 2 "E:\Mvc\Core\Meseum\Meseum\Views\_ViewImports.cshtml"
using Meseum.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38c53c7d6eef972dd44de053bc263b0e1e08e84b", @"/Views/Locations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09008350dadd545daa5d7d195c952af889c06a75", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meseum.Models.Location>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(128, 385, true);
            WriteLiteral(@"<div class=""card mb-4 col-md-8"">
    <div class=""card-header py-3"">
        <h3 class=""m-1 font-weight-bold center text-primary"">Location</h3>
    </div>

    <div style=""patding-top:10px;"">
        <table class=""table table-bordered"" id=""myTable"">
            <tr>
                <th>
                    Id
                </th>
                <td>
                    ");
            EndContext();
            BeginContext(514, 34, false);
#line 19 "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml"
               Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(548, 175, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    Name\r\n                </th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(724, 36, false);
#line 27 "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(760, 182, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                   Short Detail\r\n                </th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(943, 43, false);
#line 35 "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml"
               Write(Html.DisplayFor(model => model.ShortDetail));

#line default
#line hidden
            EndContext();
            BeginContext(986, 182, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n\r\n                <th>\r\n                  Long Detail\r\n                </th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1169, 42, false);
#line 44 "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml"
               Write(Html.DisplayFor(model => model.LongDetail));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 95, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1307, 66, false);
#line 51 "E:\Mvc\Core\Meseum\Meseum\Views\Locations\Details.cshtml"
   Write(Html.ActionLink("Edit", "AddEditLocation", new {  id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 11, true);
            WriteLiteral(" \r\n        ");
            EndContext();
            BeginContext(1384, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e9bad1aeef14df2a134beb58d6f05a4", async() => {
                BeginContext(1406, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1422, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meseum.Models.Location> Html { get; private set; }
    }
}
#pragma warning restore 1591
