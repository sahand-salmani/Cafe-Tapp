#pragma checksum "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee46e6bbac65cbdb2bca8b013330d5c7ce280d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_PrePayment_Index), @"mvc.1.0.view", @"/Areas/Panel/Views/PrePayment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee46e6bbac65cbdb2bca8b013330d5c7ce280d01", @"/Areas/Panel/Views/PrePayment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e678e1e498e0b84e32a5b9531791a8b8e4be48", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_PrePayment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Pagination.PaginatedList<PrePayment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PrePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Avans Siyahısı";
    ViewData["MainTitle"] = "Avans";
    ViewData["SubTitle"] = "Siyahısı";
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    int counter = 1;
    int modalCounter = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Bordered table -->
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Avans</h5>
    </div>


    <table class=""table datatable-basic table-bordered"">
        <thead>
            <tr>
                <th>No</th>
                <th>İşçi</th>
                <th>Məbləğ</th>
                <th>Ödaniş Vaxtı</th>
                <th class=""text-center"">Əməliyyatlar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 32 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                 if (Model.Count != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 39 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 40 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                           Write(Model[i].Employee.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 41 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                           Write(AzCulture.AzCurrency(Model[i].Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 42 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                           Write(AzCulture.ToAzDateTimeFormatFull(Model[i].DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <div class=""list-icons"">
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                            <i class=""icon-menu9""></i>
                                        </a>

                                        <div class=""dropdown-menu dropdown-menu-right"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0110355", async() => {
                WriteLiteral("<i class=\"icon-pencil\"></i>Redakta et");
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
#line 51 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                                 WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            <a data-toggle=\"modal\" data-target=\"#modal_theme_danger-");
#nullable restore
#line 52 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                               Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"dropdown-item\"><i class=\"icon-eraser3\"></i>Sil</a>\n                                        </div>\n                                    </div>\n                                </div>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 58 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n</div>\n<!-- /bordered table -->\n\n\n\n");
#nullable restore
#line 69 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 2521, "\"", 2558, 2);
            WriteAttributeValue("", 2526, "modal_theme_danger-", 2526, 19, true);
#nullable restore
#line 71 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
WriteAttributeValue("", 2545, modalCounter, 2545, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade\" tabindex=\"-1\">\n");
#nullable restore
#line 72 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
          
            modalCounter += 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-dialog\">\n            <div class=\"modal-content\">\n                <div class=\"modal-header bg-danger\">\n                    <h6 class=\"modal-title\">Avans Silmək ");
#nullable restore
#line 78 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                    Write(p.Employee.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>

                <div class=""modal-body"">
                    <h6 class=""font-weight-semibold"">Önəmli qeyd</h6>
                    <p>Silməyinizdən əmin misiniz? </p>
                </div>

                <div class=""modal-footer"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0116300", async() => {
                WriteLiteral("\n                        <button type=\"button\" class=\"btn btn-link\" data-dismiss=\"modal\">Bağla</button>\n                        <button type=\"submit\" class=\"btn bg-danger\">Sil</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                             WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 96 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 99 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
  
    var start = Math.Max((Model.PageIndex - 3), 1);
    int ends = Math.Min((Model.PageIndex + 3), Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"pagination align-self-end \">\n    <li");
            BeginWriteAttribute("class", " class=\"", 3790, "\"", 3821, 2);
            WriteAttributeValue("", 3798, "page-item", 3798, 9, true);
#nullable restore
#line 104 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
WriteAttributeValue(" ", 3807, prevDisabled, 3808, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0120765", async() => {
                WriteLiteral("&larr; &nbsp; Prev");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                               WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 105 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
     for (int i = start; i <= ends; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\n");
#nullable restore
#line 108 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
             if (i != Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0123917", async() => {
#nullable restore
#line 110 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                            WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 111 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
            }
            else if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0127060", async() => {
#nullable restore
#line 114 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 115 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item disabled\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0130193", async() => {
#nullable restore
#line 118 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                                     WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 119 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\n");
#nullable restore
#line 121 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 4659, "\"", 4690, 2);
            WriteAttributeValue("", 4667, "page-item", 4667, 9, true);
#nullable restore
#line 122 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
WriteAttributeValue(" ", 4676, nextDisabled, 4677, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee46e6bbac65cbdb2bca8b013330d5c7ce280d0133966", async() => {
                WriteLiteral("Next &nbsp; &rarr;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\PrePayment\Index.cshtml"
                                                                                               WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Pagination.PaginatedList<PrePayment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
