#pragma checksum "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520be41eee7592fb2733f28e57d2c284980f366a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "/Users/felicity/Desktop/Kursach/Kursach/Views/_ViewImports.cshtml"
using Kursach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/felicity/Desktop/Kursach/Kursach/Views/_ViewImports.cshtml"
using Kursach.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520be41eee7592fb2733f28e57d2c284980f366a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17bea4c34ddd02d9235551b523f5f9a3fcc5a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PersonalCabinet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
   ViewData["Title"] = "Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" id=\"manager\">\n\n        <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "520be41eee7592fb2733f28e57d2c284980f366a4602", async() => {
                WriteLiteral(@"
                <button type=""button"" class=""btn btn-sm btn-danger"" onclick='deleteChecked()'>
                    Delete
                </button>
                <button type=""button"" class=""btn btn-sm btn-danger"" onclick='blockChecked()'>
                    Block
                </button>
                <button type=""button"" class=""btn btn-sm btn-danger"" onclick='unblockChecked()'>
                    Unblock
                </button>
                <button type=""button"" class=""btn btn-sm btn-danger"" onclick='addToAdminChecked()'>
                    Add to admin
                </button>
                <button type=""button"" class=""btn btn-sm btn-danger"" onclick='removeFromAdminChecked()'>
                    Remove from admin
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""row"">
            <div class=""col-12"">
                <table class=""table table-bordered"" id=""table"">
                    <thead>
                        <tr>
                            <th>
                                <input type=""checkbox"" id=""select-all"" class=""CheckboxClass"">
                                <label for=""car"">Select All</label>
                            </th>

                            <th scope=""col"">Name</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">Status</th>
                            <th scope=""col"">Role</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 52 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                         foreach (var user in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td><input type=\"checkbox\" class=\"CheckboxClass\" name=\"chk\"");
            BeginWriteAttribute("value", " value=", 2216, "", 2231, 1);
#nullable restore
#line 55 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
WriteAttributeValue("", 2223, user.Id, 2223, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n                                <td>");
#nullable restore
#line 56 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                               Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 57 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 58 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                               Write(user.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 60 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                     foreach (var t in UserManager.GetRolesAsync(user).Result)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                   Write(t);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 63 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "520be41eee7592fb2733f28e57d2c284980f366a9791", async() => {
                WriteLiteral("Personal cabinet");
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
#line 65 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                                                                            WriteLiteral(user.Id);

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
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 67 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 73 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n        <h1 class=\"display-4\">Welcome</h1>\n        <p>Please <a href=\"/Account/Login\">log in</a> or <a href=\"/Account/Register\">register</a></p>\n\n    </div>\n");
#nullable restore
#line 81 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>document.getElementById('select-all').onclick = function () {
        var checkboxes = document.getElementsByName('chk');
        for (var checkbox of checkboxes) {
            checkbox.checked = this.checked;
        }
    }</script>

<script>function deleteChecked() {
        var items = document.getElementsByName('chk');
        var selectedItems = """";
        for (var i = 0; i < items.length; i++) {
            if (items[i].type == 'checkbox' && items[i].checked == true)
                selectedItems += items[i].value + "","";
        }

        $.ajax({
            url: '/Admin/Delete',
            data: { ""SelectedCheckBox"": selectedItems },
            type: ""POST"",
            success: function (jsReturnArgs) {
                $(""#manager"").html(jsReturnArgs);
            }
        })
    }</script>

<script>function blockChecked() {
        var items = document.getElementsByName('chk');
        var selectedItems = """";
        for (var i = 0; i < items.length; i++) {
            if (items[i].ty");
            WriteLiteral("pe == \'checkbox\' && items[i].checked == true)\n                selectedItems += items[i].value + \",\";\n        }\n\n    window.location.href = \'");
#nullable restore
#line 118 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                       Write(Url.Action("Block", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\' + selectedItems;\n\n");
            WriteLiteral(@"    }

    function unblockChecked() {
        var items = document.getElementsByName('chk');
        var selectedItems = """";
        for (var i = 0; i < items.length; i++) {
            if (items[i].type == 'checkbox' && items[i].checked == true)
                selectedItems += items[i].value + "","";
        }



        $.ajax({
            url: '/Admin/Unblock',
            data: { ""SelectedCheckBox"": selectedItems },
            type: ""POST"",
            success: function (jsReturnArgs) {
                $(""#manager"").html(jsReturnArgs);
            }
        })
    }

    function addToAdminChecked() {
        var items = document.getElementsByName('chk');
        var selectedItems = """";
        for (var i = 0; i < items.length; i++) {
            if (items[i].type == 'checkbox' && items[i].checked == true)
                selectedItems += items[i].value + "","";
        }

        $.ajax({
            url: '/Admin/AddToAdmin',
            data: { ""SelectedCheckBox"": selectedItems },
            type: ""POS");
            WriteLiteral(@"T"",
            success: function (jsReturnArgs) {
                $(""#manager"").html(jsReturnArgs);
            }
        })
    }

    function removeFromAdminChecked() {
        var items = document.getElementsByName('chk');
        var selectedItems = """";
        for (var i = 0; i < items.length; i++) {
            if (items[i].type == 'checkbox' && items[i].checked == true)
                selectedItems += items[i].value + "","";
        }

        $.ajax({
            url: '/Admin/RemoveFromAdmin',
            data: { ""SelectedCheckBox"": selectedItems },
            type: ""POST"",
            success: function (jsReturnArgs) {
                $(""#manager"").html(jsReturnArgs);
            }
        })
    }</script>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
