#pragma checksum "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f8d14b98d88fc5e6087bf65fd33c2d859fd0c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveHistory_Details), @"mvc.1.0.view", @"/Views/LeaveHistory/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f8d14b98d88fc5e6087bf65fd33c2d859fd0c99", @"/Views/LeaveHistory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1313d08c9939cf0d7a3076257266b1b8a94e89", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveHistory_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee_Management_System.Models.LeaveHistoryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
 if (Model.Approved == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        <h4 class=\"alert-heading\">Pending Approval</h4>\r\n        <p>\r\n            <strong>");
#nullable restore
#line 12 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>  ");
#nullable restore
#line 12 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                                    Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                                                                        Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'s Leave Request <br />\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
#nullable restore
#line 16 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 16 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
}

else if (Model.Approved == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        <h4 class=\"alert-heading\">Approved by ");
#nullable restore
#line 24 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                         Write(Model.ApprovedBy.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                     Write(Model.ApprovedBy.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>\r\n            <strong>");
#nullable restore
#line 26 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 26 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br />\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
#nullable restore
#line 30 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 30 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <h4 class=\"alert-heading\">Rejected by ");
#nullable restore
#line 38 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                         Write(Model.ApprovedBy.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                     Write(Model.ApprovedBy.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>\r\n            <strong>");
#nullable restore
#line 40 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 40 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
#nullable restore
#line 44 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 44 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestingEmployee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                           Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 79 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
     if (Model.Approved == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8d14b98d88fc5e6087bf65fd33c2d859fd0c9919057", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-check\"></i> Approve\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8d14b98d88fc5e6087bf65fd33c2d859fd0c9921469", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-remove\"></i> Reject\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveHistory\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8d14b98d88fc5e6087bf65fd33c2d859fd0c9924159", async() => {
                WriteLiteral("\r\n        <i class=\"fa fa-arrow-left\"></i> Back to List\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee_Management_System.Models.LeaveHistoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
