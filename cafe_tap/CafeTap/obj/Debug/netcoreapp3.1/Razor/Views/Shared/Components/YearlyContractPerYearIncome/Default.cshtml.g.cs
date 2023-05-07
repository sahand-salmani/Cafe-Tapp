#pragma checksum "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\Shared\Components\YearlyContractPerYearIncome\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e216a1a02dba0d6ca0a60e43a29815201af51cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_YearlyContractPerYearIncome_Default), @"mvc.1.0.view", @"/Views/Shared/Components/YearlyContractPerYearIncome/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e216a1a02dba0d6ca0a60e43a29815201af51cb2", @"/Views/Shared/Components/YearlyContractPerYearIncome/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29cb1d535e7ca2410b898a4bdbe21b3b16e0f345", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_YearlyContractPerYearIncome_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataAccess.Common.IncomePerYearAndContractTypeVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">İllik Müqavilələrin illər üzərə gəliri</h5>
        <div class=""header-elements"">
        </div>
    </div>

    <div class=""card-body"">
        <div class=""chart-container"">
            <div class=""chart has-fixed-height"" id=""columns_basic""></div>
        </div>
    </div>
</div>
<!-- /basic columns -->


<script type=""text/javascript"">

    var incomesJson = ");
#nullable restore
#line 20 "C:\Users\sahan\Desktop\CafeTap-master\Desktop\caf - Copy\CafeTap\Views\Shared\Components\YearlyContractPerYearIncome\Default.cshtml"
                 Write(Json.Serialize(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    var incomes = [];
    incomesJson.forEach(item => {
            incomes.push(item.total);
        }
    );

    var years = [];
    incomesJson.forEach(item => {
        years.push(item.year);
    });

    var EchartsColumnsBasicLight = function () {


        //
        // Setup module components
        //

        // Basic column chart
        var _columnsBasicLightExample = function () {
            if (typeof echarts == 'undefined') {
                console.warn('Warning - echarts.min.js is not loaded.');
                return;
            }

            // Define element
            var columns_basic_element = document.getElementById('columns_basic');


            //
            // Charts configuration
            //

            if (columns_basic_element) {

                // Initialize chart
                var columns_basic = echarts.init(columns_basic_element);


                //
                // Chart config
                //

                // Options
                columns_basic.");
            WriteLiteral(@"setOption({

                    // Define colors
                    color: ['#2ec7c9', '#b6a2de', '#5ab1ef', '#ffb980', '#d87a80'],

                    // Global text styles
                    textStyle: {
                        fontFamily: 'Roboto, Arial, Verdana, sans-serif',
                        fontSize: 13
                    },

                    // Chart animation duration
                    animationDuration: 750,

                    // Setup grid
                    grid: {
                        left: 0,
                        right: 40,
                        top: 35,
                        bottom: 0,
                        containLabel: true
                    },

                    // Add legend
                    legend: {
                        data: ['Gəlirlər'],
                        itemHeight: 8,
                        itemGap: 20,
                        textStyle: {
                            padding: [0, 5]
                        }
                    },

      ");
            WriteLiteral(@"              // Add tooltip
                    tooltip: {
                        trigger: 'axis',
                        backgroundColor: 'rgba(0,0,0,0.75)',
                        padding: [10, 15],
                        textStyle: {
                            fontSize: 13,
                            fontFamily: 'Roboto, sans-serif'
                        }
                    },

                    // Horizontal axis
                    xAxis: [{
                        type: 'category',
                        data: years,
                        axisLabel: {
                            color: '#333'
                        },
                        axisLine: {
                            lineStyle: {
                                color: '#999'
                            }
                        },
                        splitLine: {
                            show: true,
                            lineStyle: {
                                color: '#eee',
                              ");
            WriteLiteral(@"  type: 'dashed'
                            }
                        }
                    }],

                    // Vertical axis
                    yAxis: [{
                        type: 'value',
                        axisLabel: {
                            color: '#333'
                        },
                        axisLine: {
                            lineStyle: {
                                color: '#999'
                            }
                        },
                        splitLine: {
                            lineStyle: {
                                color: ['#eee']
                            }
                        },
                        splitArea: {
                            show: true,
                            areaStyle: {
                                color: ['rgba(250,250,250,0.1)', 'rgba(0,0,0,0.01)']
                            }
                        }
                    }],

                    // Add series
                    series: [
   ");
            WriteLiteral(@"                     {
                            name: 'Gəlirlər',
                            type: 'bar',
                            data: incomes,
                            itemStyle: {
                                normal: {
                                    label: {
                                        show: true,
                                        position: 'top',
                                        textStyle: {
                                            fontWeight: 500
                                        }
                                    }
                                }
                            }
                        }
                    ]
                });
            }


            //
            // Resize charts
            //

            // Resize function
            var triggerChartResize = function () {
                columns_basic_element && columns_basic.resize();
            };

            // On sidebar width change
            var sidebarToggle =");
            WriteLiteral(@" document.querySelector('.sidebar-control');
            sidebarToggle && sidebarToggle.addEventListener('click', triggerChartResize);

            // On window resize
            var resizeCharts;
            window.addEventListener('resize', function () {
                clearTimeout(resizeCharts);
                resizeCharts = setTimeout(function () {
                    triggerChartResize();
                }, 200);
            });
        };


        //
        // Return objects assigned to module
        //

        return {
            init: function () {
                _columnsBasicLightExample();
            }
        }
    }();


    // Initialize module
    // ------------------------------

    document.addEventListener('DOMContentLoaded', function () {
        EchartsColumnsBasicLight.init();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DataAccess.Common.IncomePerYearAndContractTypeVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591