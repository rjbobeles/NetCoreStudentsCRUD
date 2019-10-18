#pragma checksum "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f0e2620d7f397a338750e5556fe0e0235bb4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
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
#line 1 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/_ViewImports.cshtml"
using studentsCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/_ViewImports.cshtml"
using studentsCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f0e2620d7f397a338750e5556fe0e0235bb4d1", @"/Views/Students/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46735380644d426ab8c1832e6b104d5882fc1fab", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<studentsCRUD.StudentsModel.StudentClasses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
  
    ViewData["Title"] = "Add Student";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Add Student - Full</h1>\n\n\n");
#nullable restore
#line 9 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
 using(@Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Students</h4>\n        <hr />\n        ");
#nullable restore
#line 16 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        ");
#nullable restore
#line 18 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
   Write(Html.HiddenFor(Model => Model.stud.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 21 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.stud.IDNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 23 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.stud.IDNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 24 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.stud.IDNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 29 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.stud.Firstname, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 31 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.stud.Firstname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 32 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.stud.Firstname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 37 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.stud.MiddleName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 39 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.stud.MiddleName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 40 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.stud.MiddleName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 45 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.stud.Lastname, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 47 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.stud.Lastname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 48 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.stud.Lastname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 53 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.stud.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 55 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.stud.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 56 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.stud.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 61 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.stud.Course, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 63 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.stud.Course, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 64 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.stud.Course, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        ");
#nullable restore
#line 68 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
   Write(Html.HiddenFor(Model => Model.studInfo.StudentInfoID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 71 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.studInfo.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 73 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.studInfo.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 74 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.studInfo.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 79 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.studInfo.City, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 81 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.studInfo.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 82 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.studInfo.City, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        \n        <div class=\"form-group\">\n            ");
#nullable restore
#line 87 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.studInfo.Zip, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 89 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.studInfo.Zip, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 90 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.studInfo.Zip, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 95 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.studInfo.Country, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 97 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.studInfo.Country, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 98 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.studInfo.Country, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 103 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
       Write(Html.LabelFor(model => Model.studInfo.Phone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-12 col-md-6\">\n                ");
#nullable restore
#line 105 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.EditorFor(model => Model.studInfo.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 106 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => Model.studInfo.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Edit\" class=\"btn btn-primary\" />\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 116 "/Users/rjbobeles/Sites/dotnet/studentsCRUD/Views/Students/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr>\n\n<div id=\"controls\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f0e2620d7f397a338750e5556fe0e0235bb4d118321", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f0e2620d7f397a338750e5556fe0e0235bb4d119855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f0e2620d7f397a338750e5556fe0e0235bb4d120939", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<studentsCRUD.StudentsModel.StudentClasses> Html { get; private set; }
    }
}
#pragma warning restore 1591