#pragma checksum "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Areas\Panel\Views\Shared\_DashboardNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5d242dd9af5443869197f38272d7345a648f69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_Shared__DashboardNavigation), @"mvc.1.0.view", @"/Areas/Panel/Views/Shared/_DashboardNavigation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b5d242dd9af5443869197f38272d7345a648f69", @"/Areas/Panel/Views/Shared/_DashboardNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e678e1e498e0b84e32a5b9531791a8b8e4be48", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_Shared__DashboardNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header bg-transparent border-bottom header-elements-inline"">
        <span class=""card-title font-weight-semibold"">Navigation</span>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
            </div>
        </div>
    </div>

    <div class=""card-body p-0"">
        <div class=""nav nav-sidebar mb-2"">
            <li class=""nav-item-header"">
                <div class=""text-uppercase font-size-xs line-height-xs"">Main</div>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""icon-googleplus5""></i>
                    Create invoice
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""icon-compose""></i>
                    Edit invoice
                </a>
            </li>
            <li class=""nav-item"">
");
            WriteLiteral(@"                <a href=""#"" class=""nav-link"">
                    <i class=""icon-archive""></i>
                    Acrhive
                    <span class=""badge badge-pill badge-secondary ml-auto"">190</span>
                </a>
            </li>

            <li class=""nav-item-header"">
                <div class=""text-uppercase font-size-xs line-height-xs"">Invoices</div>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""icon-files-empty""></i>
                    All invoices
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""icon-file-plus""></i>
                    Pending invoices
                    <span class=""badge badge-pill bg-blue ml-auto"">16</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""icon-file-check""></i>
        ");
            WriteLiteral(@"            Paid invoices
                    <span class=""badge badge-pill bg-success ml-auto"">50</span>
                </a>
            </li>
            <li class=""nav-item-divider""></li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""icon-cog3""></i>
                    Settings
                </a>
            </li>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
