#pragma checksum "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92c7b5b3bb1f0f896b6f13ae93c7362426f7e4b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Detail), @"mvc.1.0.view", @"/Views/QandA/Detail.cshtml")]
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
#line 1 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c7b5b3bb1f0f896b6f13ae93c7362426f7e4b8", @"/Views/QandA/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bd00d17f4bd890ab5f401ea4a830e86779818e", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    p.groove {\r\n        border-style: groove;\r\n    }\r\n</style>\r\n<h1>");
#nullable restore
#line 7 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h6><i>");
#nullable restore
#line 8 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
  Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> by: ");
#nullable restore
#line 8 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                        Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<br />\r\n<p class=\"groove\">");
#nullable restore
#line 10 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
             Write(Model.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 224, "\"", 275, 3);
            WriteAttributeValue("", 234, "location.href=\'/QandA/Edit?_id=", 234, 31, true);
#nullable restore
#line 12 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 265, Model.id, 265, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 274, "\'", 274, 1, true);
            EndWriteAttribute();
            WriteLiteral(">EDIT</button>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 299, "\"", 352, 3);
            WriteAttributeValue("", 309, "location.href=\'/QandA/Delete?_id=", 309, 33, true);
#nullable restore
#line 13 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 342, Model.id, 342, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 351, "\'", 351, 1, true);
            EndWriteAttribute();
            WriteLiteral(">DELETE</button>\r\n<br /><br />\r\n");
#nullable restore
#line 15 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (ViewBag.Answerlist != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Answers</h4>\r\n");
#nullable restore
#line 18 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    foreach (Answer answer in ViewBag.Answerlist)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><i>");
#nullable restore
#line 20 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
         Write(answer.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - by: ");
#nullable restore
#line 20 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                              Write(answer.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        <p class=\"groove\">");
#nullable restore
#line 21 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                     Write(answer.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 634, "\"", 690, 3);
            WriteAttributeValue("", 644, "location.href=\'/QandA/AddAnswer?_id=", 644, 36, true);
#nullable restore
#line 25 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 680, Model.id, 680, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 689, "\'", 689, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add an Answer</button>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 723, "\"", 784, 3);
            WriteAttributeValue("", 733, "location.href=\'/QandA/Close?_id=", 733, 32, true);
#nullable restore
#line 26 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 765, Model.id, 765, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 774, "&status=1\'", 774, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Mark as Resolved</button>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
