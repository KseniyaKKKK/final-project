#pragma checksum "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d2630e2d2d791ba431294ddd4d3ea0a3553a74"
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
#line 3 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d2630e2d2d791ba431294ddd4d3ea0a3553a74", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17bea4c34ddd02d9235551b523f5f9a3fcc5a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 8 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" id=\"manager\">\n\n        <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d2630e2d2d791ba431294ddd4d3ea0a3553a743673", async() => {
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
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 43 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                         foreach (var user in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td><input type=\"checkbox\" class=\"CheckboxClass\" name=\"chk\"");
            BeginWriteAttribute("value", " value=", 1761, "", 1776, 1);
#nullable restore
#line 46 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
WriteAttributeValue("", 1768, user.Id, 1768, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n                                <td>");
#nullable restore
#line 47 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                               Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 48 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 49 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                               Write(user.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 51 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                     foreach (var t in UserManager.GetRolesAsync(user).Result)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                   Write(t);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 54 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                            </tr>\n");
#nullable restore
#line 57 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 63 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n        <h1 class=\"display-4\">Welcome</h1>\n        <p>Please <a href=\"/Account/Login\">log in</a> or <a href=\"/Account/Register\">register</a></p>\n\n    </div>\n");
#nullable restore
#line 71 "/Users/felicity/Desktop/Kursach/Kursach/Views/Admin/Index.cshtml"


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
            WriteLiteral(@"pe == 'checkbox' && items[i].checked == true)
                selectedItems += items[i].value + "","";
        }

        $.ajax({
            url: '/Admin/Block',
            data: { ""SelectedCheckBox"": selectedItems },
            type: ""POST"",
            success: function (jsReturnArgs) {
                $(""#manager"").html(jsReturnArgs);
            }
        })
    }

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