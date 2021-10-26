#pragma checksum "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca0e67c68e335fa33533ab7e2a6e5f481f0a89d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveHistory_MyLeave), @"mvc.1.0.view", @"/Views/LeaveHistory/MyLeave.cshtml")]
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
#line 1 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\_ViewImports.cshtml"
using Employee_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\_ViewImports.cshtml"
using Employee_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca0e67c68e335fa33533ab7e2a6e5f481f0a89d", @"/Views/LeaveHistory/MyLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1313d08c9939cf0d7a3076257266b1b8a94e89", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveHistory_MyLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeLeaveHistoryViewVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LeaveHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to cancel this request?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
  
    ViewData["Title"] = "MyLeave";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Leave Allocations</h1>\r\n<div class=\"jumbotron\">\r\n    <div class=\"list-group list-group-flush\">\r\n        <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 11 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
             foreach (var item in Model.LeaveAllocations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    <h6>");
#nullable restore
#line 14 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                   Write(item.LeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-secondary\">");
#nullable restore
#line 14 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                                                                            Write(item.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>    </h6>\r\n                </li>\r\n");
#nullable restore
#line 16 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</div>

<hr />
<h1>My Leave Records</h1>
<table id=""tblData"" class=""table"">
    <thead>
        <tr>
            <th>
                Leave Type
            </th>
            <th>
                Start Date
            </th>
            <th>
                End Date
            </th>
            <th>
                Date Requested
            </th>
            <th>
                Approval State
            </th>
            <th>
                Cancel Request
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
 foreach (var item in Model.LeaveHistories) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 62 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                 if (item.Approved == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-success\">Approved</span>\r\n");
#nullable restore
#line 65 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                }

                else if (item.Approved == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">Rejected</span>\r\n");
#nullable restore
#line 70 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-warning\">Pending approval</span>\r\n");
#nullable restore
#line 75 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n            <td>\r\n");
#nullable restore
#line 79 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                 if (item.StartDate > DateTime.Now || item.Approved == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ca0e67c68e335fa33533ab7e2a6e5f481f0a89d11341", async() => {
                WriteLiteral("\r\n                        <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\MyLeave.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeLeaveHistoryViewVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
