#pragma checksum "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8e5488d996dc6af861db655bb6723dc7880a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EduHomee.Areas.Admin.Views.Shared.Event.Areas_Admin_Views_Event_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Event/Detail.cshtml")]
namespace EduHomee.Areas.Admin.Views.Shared.Event
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
#line 1 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
using EduHomee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8e5488d996dc6af861db655bb6723dc7880a6b", @"/Areas/Admin/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa753f968db8f5a24fee43bd8a69f651a37c0e2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8e5488d996dc6af861db655bb6723dc7880a6b4442", async() => {
                WriteLiteral("\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">Title</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 8 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""mt-3"">
        <label class=""form-label"" style=""font-size:34px;"">Description</label>

        <div class=""mt-1"" style=""width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;"">
            ");
#nullable restore
#line 15 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"mt-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">Image</label>\n\n        <div class=\"mt-1\" style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 23 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">Location</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 29 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">StartDate</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 35 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">EndDate</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 41 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.EndDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"mb-3\">\n        <label class=\"form-label\" style=\"font-size:34px;\">Date</label>\n        <div style=\"width:100%;height:40px;border:1px dashed grey;padding-top:10px;padding-left:20px;\">\n            ");
#nullable restore
#line 47 "/Users/elmirustayev/Desktop/EduHomee/EduHomee/Areas/Admin/Views/Event/Detail.cshtml"
       Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8e5488d996dc6af861db655bb6723dc7880a6b8061", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
