#pragma checksum "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1930dbaeb8d51943992493b979ea919c5c9da6ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EduHomee.Areas.Admin.Views.Shared.CourseDetails.Areas_Admin_Views_CourseDetails_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/CourseDetails/Detail.cshtml")]
namespace EduHomee.Areas.Admin.Views.Shared.CourseDetails
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
#line 1 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/_ViewImports.cshtml"
using EduHomee.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml"
using EduHomee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1930dbaeb8d51943992493b979ea919c5c9da6ef", @"/Areas/Admin/Views/CourseDetails/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3bd7e6640f539211a20efbc9f7fcd86ba4b12b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CourseDetails_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1930dbaeb8d51943992493b979ea919c5c9da6ef4514", async() => {
                WriteLiteral("\n\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">CourseName</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 9 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml"
       Write(Model.Course.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">Certificate</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 15 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml"
       Write(Model.Certificate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"mt-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">About</label>\n\n        <div class=\"mt-1\" style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 22 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml"
       Write(Model.About);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""mt-3"">
        <label class=""form-label"" style=""font-size:34px;"">How to Apply</label>

        <div class=""mt-1"" style=""width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;"">
            ");
#nullable restore
#line 29 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml"
       Write(Model.HowToApply);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""mt-3"">
        <label class=""form-label"" style=""font-size:34px;"">CourseCount</label>

        <div class=""mt-1"" style=""width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;"">
            ");
#nullable restore
#line 36 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/CourseDetails/Detail.cshtml"
       Write(Model.CourseCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1930dbaeb8d51943992493b979ea919c5c9da6ef7260", async() => {
                    WriteLiteral("Go back");
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
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
