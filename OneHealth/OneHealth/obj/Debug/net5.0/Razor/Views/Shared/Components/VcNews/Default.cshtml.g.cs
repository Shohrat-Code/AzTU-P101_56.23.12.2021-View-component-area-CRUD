#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "135a7f8c6458462c954defe6283642f456fa48d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VcNews_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VcNews/Default.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"135a7f8c6458462c954defe6283642f456fa48d9", @"/Views/Shared/Components/VcNews/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7885a7453245dfc02cf1556aec42e1a631756a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VcNews_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmVcNews>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
 foreach (var item in Model.Blogs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 68, "\"", 135, 2);
#nullable restore
#line 6 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
WriteAttributeValue("", 76, Model.Page=="Home"?"col-lg-4 wow zoomIn":"col-sm-6", 76, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 130, "py-2", 131, 5, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""card-blog"">
            <div class=""header"">
                <div class=""post-category"">
                    <a href=""#"">Covid19</a>
                </div>
                <a href=""blog-details.html"" class=""post-thumb"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 409, "\"", 445, 2);
            WriteAttributeValue("", 415, "../assets/img/blog/", 415, 19, true);
#nullable restore
#line 13 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
WriteAttributeValue("", 434, item.Image, 434, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 446, "\"", 452, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"body\">\r\n                <h5 class=\"post-title\"><a href=\"blog-details.html\">");
#nullable restore
#line 17 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                <div class=\"site-info\">\r\n                    <div class=\"avatar mr-2\">\r\n                        <div class=\"avatar-img\">\r\n                            <img src=\"../assets/img/person/person_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 829, "\"", 835, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <span>");
#nullable restore
#line 23 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
                          Write(item.User.Name+" "+item.User.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n");
#nullable restore
#line 25 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
                      
                        DateTime today = DateTime.Today;
                        TimeSpan diff = today.Subtract(item.CreatedDate);

                        int days = diff.Days;
                        int weeks = days / 7;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"mai-time\"></span> ");
#nullable restore
#line 32 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
                                               Write(weeks==0?days==0?item.CreatedDate.ToString("HH:mm"): days + " days ago" : weeks+ " week ago");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\56.23.12.2021-View component, area, CRUD\Codes\OneHealth\OneHealth\Views\Shared\Components\VcNews\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmVcNews> Html { get; private set; }
    }
}
#pragma warning restore 1591
