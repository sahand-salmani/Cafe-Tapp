#pragma checksum "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5154b14440a9abbae93102900e19321c5e096363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_UserManagement_AllTokens), @"mvc.1.0.view", @"/Areas/Panel/Views/UserManagement/AllTokens.cshtml")]
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
#line 4 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Infrastructure.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Humanizer.Localisation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5154b14440a9abbae93102900e19321c5e096363", @"/Areas/Panel/Views/UserManagement/AllTokens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e678e1e498e0b84e32a5b9531791a8b8e4be48", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_UserManagement_AllTokens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Pagination.PaginatedList<UserRegisterToken>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RoleManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllTokens", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTokenForRegistration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link text-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteToken", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Registration Token List";
    ViewData["MainTitle"] = "Registration Token";
    ViewData["SubTitle"] = "List";
    ViewData["users"] = "active";
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    int counter = 1;
    int modalCounter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title font-weight-bold"">İstifadəçilər və mövqeylər Bölməsi</h5>
    </div>

    <div class=""card-body"">
        <ul class=""nav nav-tabs nav-tabs-highlight"">
            <li class=""nav-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5154b14440a9abbae93102900e19321c5e0963638904", async() => {
                WriteLiteral("İstifadəçilər");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n            <li class=\"nav-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5154b14440a9abbae93102900e19321c5e09636310907", async() => {
                WriteLiteral("Mövqeylər");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n            <li class=\"nav-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5154b14440a9abbae93102900e19321c5e09636312907", async() => {
                WriteLiteral("Tokenlər");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n        </ul>\n        <div class=\"d-md-flex align-items-md-center flex-md-wrap text-center text-md-left\">\n            <ul class=\"list-inline list-inline-condensed mb-0\">\n                <li class=\"list-inline-item dropdown\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5154b14440a9abbae93102900e19321c5e09636315126", async() => {
                WriteLiteral("<i class=\"icon-add\"></i> Yeni <strong>Token</strong> əlavə et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
            </ul>
        </div>
    </div>
</div>

<!-- Bordered table -->
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Tokenlərin siyahısı</h5>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
    </div>
       

    <table class=""table datatable-basic table-bordered"">
        <thead>
            <tr>
                <th>No</th>
                <th>Token</th>
                <th>İstifadə olunub</th>
                <th class=""text-center"">Əməliyyatlar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 59 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                 if (Model.Count != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 66 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 67 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                           Write(Model[i].Token);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 68 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                             if (Model[i].IsUsed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Hə</td>\n");
#nullable restore
#line 71 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Yox</td>\n");
#nullable restore
#line 75 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td class=""text-center"">
                                <div class=""list-icons"">
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                            <i class=""icon-menu9""></i>
                                        </a>

                                        <div class=""dropdown-menu dropdown-menu-right"">
                                            <a data-toggle=""modal"" data-target=""#modal_theme_danger-");
#nullable restore
#line 84 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                                                                                               Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"dropdown-item\"><i class=\"icon-eraser3\"></i>Sil</a>\n                                        </div>\n                                    </div>\n                                </div>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 90 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n</div>\n<!-- /bordered table -->\n\n\n\n");
#nullable restore
#line 101 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 4010, "\"", 4047, 2);
            WriteAttributeValue("", 4015, "modal_theme_danger-", 4015, 19, true);
#nullable restore
#line 103 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
WriteAttributeValue("", 4034, modalCounter, 4034, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade\" tabindex=\"-1\">\n");
#nullable restore
#line 104 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
          
            modalCounter += 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-dialog\">\n            <div class=\"modal-content\">\n                <div class=\"modal-header bg-danger\">\n                    <h6 class=\"modal-title\">Token silinəcək: ");
#nullable restore
#line 110 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                                                        Write(product.Token);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>

                <div class=""modal-body"">
                    <h6 class=""font-weight-semibold"">Vacib qeyd!!!</h6>
                    <p>Bu tokeni silmək istədiyinizdən əminsiniz mi?</p>
                </div>

                <div class=""modal-footer"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5154b14440a9abbae93102900e19321c5e09636323959", async() => {
                WriteLiteral("\n                        <button type=\"button\" class=\"btn btn-link\" data-dismiss=\"modal\">Bağla</button>\n                        <button type=\"submit\" class=\"btn bg-danger\">Sil</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                                                                                                      WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 128 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 131 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
  
    var start = Math.Max((Model.PageIndex - 3), 1);
    int ends = Math.Min((Model.PageIndex + 3), Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul class=\"pagination align-self-end\">\n    <li");
            BeginWriteAttribute("class", " class=\"", 5311, "\"", 5342, 2);
            WriteAttributeValue("", 5319, "page-item", 5319, 9, true);
#nullable restore
#line 137 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
WriteAttributeValue(" ", 5328, prevDisabled, 5329, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\" class=\"page-link\">&larr; &nbsp; Prev</a></li>\n");
#nullable restore
#line 138 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
     for (int i = start; i <= ends; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\n");
#nullable restore
#line 141 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
             if (i != Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\"><a href=\"#\" class=\"page-link\">");
#nullable restore
#line 143 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 144 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\"><a href=\"#\" class=\"page-link\">");
#nullable restore
#line 147 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 148 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n");
#nullable restore
#line 150 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 5761, "\"", 5792, 2);
            WriteAttributeValue("", 5769, "page-item", 5769, 9, true);
#nullable restore
#line 151 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\UserManagement\AllTokens.cshtml"
WriteAttributeValue(" ", 5778, nextDisabled, 5779, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\" class=\"page-link\">Next &nbsp; &rarr;</a></li>\n</ul>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AzCultureInfo AzCulture { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Pagination.PaginatedList<UserRegisterToken>> Html { get; private set; }
    }
}
#pragma warning restore 1591
