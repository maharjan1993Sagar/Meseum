#pragma checksum "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd58715bf9dc5bc124348a9b666b879a472dc259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Add), @"mvc.1.0.view", @"/Views/Inventory/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/Add.cshtml", typeof(AspNetCore.Views_Inventory_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd58715bf9dc5bc124348a9b666b879a472dc259", @"/Views/Inventory/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09008350dadd545daa5d7d195c952af889c06a75", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meseum.ViewModel.InventoryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
  
    /**/

    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(89, 22, true);
            WriteLiteral("\r\n<h4>Inventory</h4>\r\n");
            EndContext();
            BeginContext(111, 7231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "256725ab973040e89b56934eb434f43b", async() => {
                BeginContext(164, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(170, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf21cc4ab494aeb95e59a1bc278ccce", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(236, 177, true);
                WriteLiteral("\r\n   \r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    <label>Category</label>\r\n                    ");
                EndContext();
                BeginContext(414, 98, false);
#line 17 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.DropDownList("CategoryId", Model.Categories, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(512, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(535, 88, false);
#line 18 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(623, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(768, 40, false);
#line 23 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.LocationId));

#line default
#line hidden
                EndContext();
                BeginContext(808, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(833, 97, false);
#line 25 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.DropDownList("LocationId", Model.Locations, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(930, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(953, 88, false);
#line 26 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.LocationId, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1041, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(1186, 34, false);
#line 31 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1220, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1222, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "813d3df22ba34333b744169edf2f5b65", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 32 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1278, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1400, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1421, 82, false);
#line 34 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1503, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(1648, 34, false);
#line 39 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.Date));

#line default
#line hidden
                EndContext();
                BeginContext(1682, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(1707, 109, false);
#line 41 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.Date, new { htmlAttributes = new { @class = "form-control", id = "txtDate" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1816, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1839, 82, false);
#line 42 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1921, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(2066, 38, false);
#line 47 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.Material));

#line default
#line hidden
                EndContext();
                BeginContext(2104, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(2129, 97, false);
#line 49 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.Material, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2226, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2249, 86, false);
#line 50 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Material, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2335, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(2480, 40, false);
#line 55 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.ObjectCode));

#line default
#line hidden
                EndContext();
                BeginContext(2520, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(2545, 99, false);
#line 57 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.ObjectCode, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2644, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2667, 88, false);
#line 58 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.ObjectCode, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2755, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(2900, 34, false);
#line 63 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.size));

#line default
#line hidden
                EndContext();
                BeginContext(2934, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(2959, 93, false);
#line 65 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.size, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3052, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3075, 82, false);
#line 66 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.size, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3157, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(3302, 38, false);
#line 71 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.OriginOf));

#line default
#line hidden
                EndContext();
                BeginContext(3340, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(3365, 97, false);
#line 73 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.OriginOf, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3462, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3485, 86, false);
#line 74 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.OriginOf, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3571, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(3716, 36, false);
#line 79 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.MadeBy));

#line default
#line hidden
                EndContext();
                BeginContext(3752, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(3777, 95, false);
#line 81 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.MadeBy, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3872, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3895, 84, false);
#line 82 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.MadeBy, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3979, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(4124, 41, false);
#line 87 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.ShortDetail));

#line default
#line hidden
                EndContext();
                BeginContext(4165, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(4190, 100, false);
#line 89 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.ShortDetail, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(4290, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4313, 89, false);
#line 90 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.ShortDetail, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(4402, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(4547, 40, false);
#line 95 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.LongDetail));

#line default
#line hidden
                EndContext();
                BeginContext(4587, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(4612, 99, false);
#line 97 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.LongDetail, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(4711, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4734, 88, false);
#line 98 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.LongDetail, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(4822, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(4967, 42, false);
#line 103 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.DetailStatus));

#line default
#line hidden
                EndContext();
                BeginContext(5009, 72, true);
                WriteLiteral("\r\n\r\n                    <div class=\"checkbox\">\r\n                        ");
                EndContext();
                BeginContext(5082, 43, false);
#line 106 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
                   Write(Html.EditorFor(model => model.DetailStatus));

#line default
#line hidden
                EndContext();
                BeginContext(5125, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(5152, 90, false);
#line 107 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.DetailStatus, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(5242, 172, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(5415, 34, false);
#line 113 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.Long));

#line default
#line hidden
                EndContext();
                BeginContext(5449, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(5474, 93, false);
#line 115 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.Long, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(5567, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5590, 82, false);
#line 116 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Long, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(5672, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(5817, 35, false);
#line 121 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.Latit));

#line default
#line hidden
                EndContext();
                BeginContext(5852, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(5877, 94, false);
#line 123 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.EditorFor(model => model.Latit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(5971, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5994, 83, false);
#line 124 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Latit, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(6077, 385, true);
                WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label>Thumbnail Image</label>

                    <input type=""file"" id=""file"" name=""File"" />
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group"">
                    ");
                EndContext();
                BeginContext(6463, 41, false);
#line 136 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
               Write(Html.LabelFor(model => model.PhotoStatus));

#line default
#line hidden
                EndContext();
                BeginContext(6504, 72, true);
                WriteLiteral("\r\n\r\n                    <div class=\"checkbox\">\r\n                        ");
                EndContext();
                BeginContext(6577, 42, false);
#line 139 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
                   Write(Html.EditorFor(model => model.PhotoStatus));

#line default
#line hidden
                EndContext();
                BeginContext(6619, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(6646, 89, false);
#line 140 "E:\Mvc\Core\Meseum\Meseum\Views\Inventory\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PhotoStatus, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(6735, 600, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label>Images</label>

                    <input type=""file"" id=""files"" multiple name=""Files"" />
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""gallery"">

                </div>
            </div>


            <div class=""col-md-12"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7342, 19, true);
            WriteLiteral("\r\n    <div>\r\n      ");
            EndContext();
            BeginContext(7361, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "024f57048dcc454eb9febedd73af1619", async() => {
                BeginContext(7383, 12, true);
                WriteLiteral("Back to list");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7399, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meseum.ViewModel.InventoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
