#pragma checksum "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9039a05c2b41a5af92739d52028809dfac2cebc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chemical_Delete), @"mvc.1.0.view", @"/Views/Chemical/Delete.cshtml")]
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
#line 1 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/_ViewImports.cshtml"
using ChemicalMVCDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/_ViewImports.cshtml"
using ChemicalMVCDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9039a05c2b41a5af92739d52028809dfac2cebc3", @"/Views/Chemical/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3088aa15dac8c0d3e687baadefb06bf18fda49", @"/Views/_ViewImports.cshtml")]
    public class Views_Chemical_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChemicalMVCDatabase.Models.Chemical>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
  
  ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Delete</h2>\n<h3>Are you sure you want to delete this?</h3>\n<div>\n  <h4>Chemicals</h4>\n  <hr />\n  <dl class=\"dl-horizontal\">\n    <dt>\n      ");
#nullable restore
#line 13 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayNameFor(model => model.Chemical_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd>\n      ");
#nullable restore
#line 16 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayFor(model => model.Chemical_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt>\n      ");
#nullable restore
#line 19 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayNameFor(model => model.Molecular_Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd>\n      ");
#nullable restore
#line 22 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayFor(model => model.Molecular_Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt>\n      ");
#nullable restore
#line 25 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayNameFor(model => model.Product_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd>\n      ");
#nullable restore
#line 28 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayFor(model => model.Product_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt>\n      ");
#nullable restore
#line 31 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayNameFor(model => model.Vendor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd>\n      ");
#nullable restore
#line 34 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
 Write(Html.DisplayFor(model => model.Vendor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n  </dl>\n\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9039a05c2b41a5af92739d52028809dfac2cebc36968", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9039a05c2b41a5af92739d52028809dfac2cebc37226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "/Users/rskogsberg/Documents/Projects/ChemicalMVCDatabase/Views/Chemical/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Chemical_ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <input type=\"Submit\" value=\"Delete\" class=\"btn btn-primary\" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9039a05c2b41a5af92739d52028809dfac2cebc38991", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChemicalMVCDatabase.Models.Chemical> Html { get; private set; }
    }
}
#pragma warning restore 1591
