#pragma checksum "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\Shared\Components\MeetingsCalendar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80831dc862022bfc64c23acae3749e81704ec20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MeetingsCalendar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MeetingsCalendar/Default.cshtml")]
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
#line 4 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\_ViewImports.cshtml"
using Infrastructure.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\_ViewImports.cshtml"
using Humanizer.Localisation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\_ViewImports.cshtml"
using static Infrastructure.Common.ClaimsList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80831dc862022bfc64c23acae3749e81704ec20d", @"/Views/Shared/Components/MeetingsCalendar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29cb1d535e7ca2410b898a4bdbe21b3b16e0f345", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MeetingsCalendar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Infrastructure.RestaurantMeetings.ViewModels.MeetingCalendarVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\Shared\Components\MeetingsCalendar\Default.cshtml"
     if (Model != null)
    {
        if (Model.Any())
        {
            foreach (var meetingCalendarVm in Model)
            {
                meetingCalendarVm.Url = Url.Action("Get", "RestaurantMeetings", new { id = meetingCalendarVm.Id });
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Event colors -->
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Görüşlər Təqvimi</h5>
        <div class=""header-elements"">
        </div>
    </div>
					
    <div class=""card-body"">
        <div class=""fullcalendar-event-colors""></div>
    </div>
</div>



<script type=""text/javascript"">
    var FullCalendarStyling = function() {
        
        var model = ");
#nullable restore
#line 34 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\Shared\Components\MeetingsCalendar\Default.cshtml"
               Write(Json.Serialize(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";


        //
        // Setup module components
        //

        // External events
        var _componentFullCalendarStyling = function () {
            if (typeof FullCalendar == 'undefined') {
                console.warn('Warning - Fullcalendar files are not loaded.');
                return;
            }


            // Add events
            // ------------------------------

            // Event colors
            var eventColors = model;

            // Initialization
            // ------------------------------

            //
            // Event colors
            //
            function toJSONLocal(date) {
                var local = new Date(date);
                local.setMinutes(date.getMinutes() - date.getTimezoneOffset());
                return local.toJSON().slice(0, 10);
            };
            var today = new Date();
            today = toJSONLocal(today);

            // Define element
            var calendarEventColorsElement = document.querySelector('.fullcalendar-event-col");
            WriteLiteral(@"ors');

            // Initialize
            if (calendarEventColorsElement) {
                var calendarEventColorsInit = new FullCalendar.Calendar(calendarEventColorsElement, {
                    plugins: ['dayGrid', 'interaction'],
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'dayGridMonth,dayGridWeek,dayGridDay'
                    },
                    defaultDate: today,
                    editable: true,
                    events: eventColors
                }).render();
            }


            //
            // Event background colors
            //

            // Define element
            var calendarEventBgColorsElement = document.querySelector('.fullcalendar-background-colors');

            // Initialize
            if (calendarEventBgColorsElement) {
                var calendarEventBgColorsInit = new FullCalendar.Calendar(calendarEventBgColorsElement, {
                    plugi");
            WriteLiteral(@"ns: ['dayGrid', 'interaction'],
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'dayGridMonth,dayGridWeek,dayGridDay'
                    },
                    defaultDate: today,
                    editable: true,
                    events: eventBackgroundColors
                }).render();
            }
        };


        //
        // Return objects assigned to module
        //

        return {
            init: function () {
                _componentFullCalendarStyling();
            }
        }
    }();


    // Initialize module
    // ------------------------------

    document.addEventListener('DOMContentLoaded', function () {
        FullCalendarStyling.init();
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Infrastructure.RestaurantMeetings.ViewModels.MeetingCalendarVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
