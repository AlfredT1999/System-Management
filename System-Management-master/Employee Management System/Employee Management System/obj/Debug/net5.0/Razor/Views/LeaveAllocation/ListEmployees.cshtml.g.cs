#pragma checksum "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6225bb90b5b565f617ee3b0b3bbb8cca79b7d46c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveAllocation_ListEmployees), @"mvc.1.0.view", @"/Views/LeaveAllocation/ListEmployees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6225bb90b5b565f617ee3b0b3bbb8cca79b7d46c", @"/Views/LeaveAllocation/ListEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1313d08c9939cf0d7a3076257266b1b8a94e89", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveAllocation_ListEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee_Management_System.Models.EmployeeVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
  
    ViewData["Title"] = "ListEmployees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>List Employees</h1>\n\n<table id=\"table_id\" class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 25 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 28 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 31 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6225bb90b5b565f617ee3b0b3bbb8cca79b7d46c7417", async() => {
                WriteLiteral("\n                    <i class=\"fa fa-search\"></i> Details\n                ");
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
#line 37 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
                                                                          WriteLiteral(item.Id);

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
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 42 "C:\Users\Alfredo\Documents\EmployeeManagementSystem\System-Management-master\Employee Management System\Employee Management System\Views\LeaveAllocation\ListEmployees.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee_Management_System.Models.EmployeeVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
