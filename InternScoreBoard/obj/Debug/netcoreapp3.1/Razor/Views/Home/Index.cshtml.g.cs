#pragma checksum "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82fbf7dec79b62cbc8fc2c71112c311cf1c037b"
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
#line 1 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\_ViewImports.cshtml"
using InternScoreBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\_ViewImports.cshtml"
using InternScoreBoard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82fbf7dec79b62cbc8fc2c71112c311cf1c037b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"483986dd2097ede20f9612fae60c31c934796a4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82fbf7dec79b62cbc8fc2c71112c311cf1c037b4634", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82fbf7dec79b62cbc8fc2c71112c311cf1c037b5693", async() => {
                WriteLiteral("\r\n    <div class=\"jumbotron align-items-center\" style=\"text-align: center\">\r\n");
#nullable restore
#line 8 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
         if (Model == null)
        {
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                 using (Html.BeginForm("UploadData", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <label>Select File:</label>
                    <input type=""file"" name=""uploadedFiles"" multiple=""multiple"" />
                    <hr />
                    <button type=""submit"" name=""submit"" value=""all"" class=""btn btn-primary"">Overall Report</button>
                    <button type=""submit"" name=""submit"" value=""individual"" class=""btn btn-primary"">Individual Report</button>
                    <br />
                    <div class=""text-danger"">");
#nullable restore
#line 19 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                                        Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                 
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table border=""1"" width=""100%"" cellpadding=""15"" style=""margin-bottom: 3%"">
                <thead>
                    <tr style=""font-weight: bold"">
                        <td>Rank</td>
                        <td>Intern Name</td>
                        <td>Email</td>
                        <td");
                BeginWriteAttribute("colspan", " colspan=\"", 1291, "\"", 1331, 1);
#nullable restore
#line 31 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
WriteAttributeValue("", 1301, ViewData["CourseColumnCount"], 1301, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Course Name/Total Percentage</td>\r\n                        <td>Overall Percentage</td>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                       int rank = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                     foreach (var intern in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                           Write(rank);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                           Write(intern.InternName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                           Write(intern.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 47 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                             for (int i = 0; i < intern.Courses.Count; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 50 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                               Write(intern.Courses[i].CourseName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 53 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                               Write(intern.Courses[i].Percentage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 55 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
                           Write(intern.AllOverScore);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"

                        rank++;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82fbf7dec79b62cbc8fc2c71112c311cf1c037b12350", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\subhr\source\repos\InternScoreBoard\InternScoreBoard\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591