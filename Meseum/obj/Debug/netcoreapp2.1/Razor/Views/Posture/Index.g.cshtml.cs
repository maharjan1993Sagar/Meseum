#pragma checksum "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c28bae0e69c66b23046a5a7cb3768ae003abbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posture_Index), @"mvc.1.0.view", @"/Views/Posture/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posture/Index.cshtml", typeof(AspNetCore.Views_Posture_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c28bae0e69c66b23046a5a7cb3768ae003abbc", @"/Views/Posture/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09008350dadd545daa5d7d195c952af889c06a75", @"/Views/_ViewImports.cshtml")]
    public class Views_Posture_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Meseum.Models.Posture>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
      
        ViewData["Title"] = "Index";
    

#line default
#line hidden
            BeginContext(98, 816, true);
            WriteLiteral(@"
    <style>
        table {
            border-collapse: collapse;
            border-spacing: 0;
            width: 100%;
            border: 1px solid #ddd;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }


        #myTable th, #myTable td {
            text-align: left;
            padding: 12px;
        }

        #myTable tr {
            border-bottom: 1px solid #ddd;
        }

            #myTable tr.header, #myTable tr:hover {
                background-color: #f1f1f1;
            }
    </style>
    <div class=""card mb-4"">
        <div class=""card-header py-3"">
            <h3 class=""m-1 font-weight-bold center text-primary"">Postures</h3>
        </div>
        <div class=""card-body"">
            <p>
                ");
            EndContext();
            BeginContext(914, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c437b285f54a49bdbdfc255dd1b1f915", async() => {
                BeginContext(970, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(984, 550, true);
            WriteLiteral(@"
            </p>
            <div style=""padding-top:10px;"">
                <table class=""table table-bordered"" id=""myTable"">
                    <thead>
                        <tr>

                            <th>
                                Name
                            </th>

                            <th>
                               Description
                            </th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 58 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1615, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1724, 39, false);
#line 62 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1879, 46, false);
#line 65 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2043, 92, false);
#line 69 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                               Write(Html.ActionLink("Edit", "AddEdit", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2176, 92, false);
#line 70 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                               Write(Html.ActionLink("Details", "Details", new { id = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2309, 168, false);
#line 71 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id, @class = "btn btn-success" }, new { onclick = "return confirm('Are you sure you want to delete this item?');" }));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 74 "E:\Mvc\Core\Meseum\Meseum\Views\Posture\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2580, 112, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2714, 469, true);
                WriteLiteral(@"


        <script type=""text/javascript"">

            $(document).ready(function () {
                $(""body div.myTable input"");
                var dataSrc = [];

                var table = $(""#myTable"").DataTable({
                    ""columnDefs"": [
                        { ""orderable"": false, ""targets"": 3 }

                    ],
                    ""pageLength"": 50,


                });
            });




        </script>
    ");
                EndContext();
            }
            );
            BeginContext(3186, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Meseum.Models.Posture>> Html { get; private set; }
    }
}
#pragma warning restore 1591
