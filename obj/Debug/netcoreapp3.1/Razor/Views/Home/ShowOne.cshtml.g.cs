#pragma checksum "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d49d18b7cf862d003b98453525e88ddd2ae63ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowOne), @"mvc.1.0.view", @"/Views/Home/ShowOne.cshtml")]
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
#line 1 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/_ViewImports.cshtml"
using Crudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/_ViewImports.cshtml"
using Crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d49d18b7cf862d003b98453525e88ddd2ae63ec", @"/Views/Home/ShowOne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
  
    ViewData["Title"] = "One Dish";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"w-50 mx-auto\" id=\"dishcard\">\n    <p>Name: ");
#nullable restore
#line 7 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
        Write(ViewBag.OneDish.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Tasty Level: ");
#nullable restore
#line 8 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
               Write(ViewBag.OneDish.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Calories: ");
#nullable restore
#line 9 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
            Write(ViewBag.OneDish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Description: ");
#nullable restore
#line 10 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
               Write(ViewBag.OneDish.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 319, "\"", 354, 2);
            WriteAttributeValue("", 326, "edit/", 326, 5, true);
#nullable restore
#line 11 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
WriteAttributeValue("", 331, ViewBag.OneDish.DishId, 331, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\n    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 394, "\"", 432, 2);
            WriteAttributeValue("", 401, "/delete/", 401, 8, true);
#nullable restore
#line 12 "/Users/douglasherman/Desktop/CodingDojo/C#/Crudelicious/Views/Home/ShowOne.cshtml"
WriteAttributeValue("", 409, ViewBag.OneDish.DishId, 409, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
