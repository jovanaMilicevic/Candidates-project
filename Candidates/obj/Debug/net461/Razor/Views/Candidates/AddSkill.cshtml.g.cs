#pragma checksum "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad14abc45bf8bf42ffcb7651f227b49ac04c7d68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_AddSkill), @"mvc.1.0.view", @"/Views/Candidates/AddSkill.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidates/AddSkill.cshtml", typeof(AspNetCore.Views_Candidates_AddSkill))]
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
#line 1 "D:\.net5\Candidates\Views\_ViewImports.cshtml"
using Candidates;

#line default
#line hidden
#line 2 "D:\.net5\Candidates\Views\_ViewImports.cshtml"
using Candidates.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad14abc45bf8bf42ffcb7651f227b49ac04c7d68", @"/Views/Candidates/AddSkill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62fd1a9076129a977ded800e881394ed55288f7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_AddSkill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Candidates.Models.Lists>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveSkill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSkills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
  
    ViewData["Title"] = "AddSkill";

#line default
#line hidden
            BeginContext(78, 20, true);
            WriteLiteral("\r\n<h2>Add Skill for ");
            EndContext();
            BeginContext(99, 46, false);
#line 7 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
             Write(Html.DisplayFor(model => model.Candidate.Name));

#line default
#line hidden
            EndContext();
            BeginContext(145, 139, true);
            WriteLiteral("</h2>\r\n\r\n    \r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(285, 45, false);
#line 14 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                   Write(Html.DisplayNameFor(model => model.HasSkills));

#line default
#line hidden
            EndContext();
            BeginContext(330, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 20 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                 foreach (var item in Model.HasSkills)
                {

#line default
#line hidden
            BeginContext(531, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(616, 39, false);
#line 24 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(655, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(746, 446, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "825dffeb9ba641fc81ad046696c1e523", async() => {
                BeginContext(777, 109, true);
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 886, "\"", 902, 1);
#line 29 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
WriteAttributeValue("", 894, item.Id, 894, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(903, 65, true);
                WriteLiteral(" name=\"ids\" />\r\n                                    <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 968, "\"", 995, 1);
#line 30 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
WriteAttributeValue("", 976, Model.Candidate.Id, 976, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(996, 189, true);
                WriteLiteral(" name=\"idc\" />\r\n                                    <input type=\"submit\" value=\"RemoveSkill\" class=\"btn btn-default\" />\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1192, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 36 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                }

#line default
#line hidden
            BeginContext(1271, 178, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    \r\n    \r\n        <table class=\"table\">\r\n\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1450, 52, false);
#line 46 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                   Write(Html.DisplayNameFor(model => model.DoesntHaveSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 52 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                 foreach (var item in Model.DoesntHaveSkills)
                {

#line default
#line hidden
            BeginContext(1710, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1795, 39, false);
#line 56 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1925, 442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86a81a1b7224bd5a68cfb069592ce0a", async() => {
                BeginContext(1954, 109, true);
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2063, "\"", 2079, 1);
#line 61 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
WriteAttributeValue("", 2071, item.Id, 2071, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2080, 65, true);
                WriteLiteral(" name=\"ids\" />\r\n                                    <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2145, "\"", 2172, 1);
#line 62 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"
WriteAttributeValue("", 2153, Model.Candidate.Id, 2153, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2173, 187, true);
                WriteLiteral(" name=\"idc\" />\r\n                                    <input type=\"submit\" value=\"AddSkills\" class=\"btn btn-default\" />\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2367, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 68 "D:\.net5\Candidates\Views\Candidates\AddSkill.cshtml"

                }

#line default
#line hidden
            BeginContext(2448, 46, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Candidates.Models.Lists> Html { get; private set; }
    }
}
#pragma warning restore 1591
