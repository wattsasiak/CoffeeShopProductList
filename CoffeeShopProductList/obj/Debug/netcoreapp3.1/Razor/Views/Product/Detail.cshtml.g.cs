#pragma checksum "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02409672fd017ac84cbbe933b4c36f1551413c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\_ViewImports.cshtml"
using CoffeeShopProductList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\_ViewImports.cshtml"
using CoffeeShopProductList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02409672fd017ac84cbbe933b4c36f1551413c51", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb702d907c463d421b1948e75385c76ec430bcd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
 foreach (Product prod in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
  Write(prod.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <br />\r\n    <p>");
#nullable restore
#line 13 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
  Write(prod.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <br />\r\n    <p>");
#nullable restore
#line 14 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
  Write(prod.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <br />\r\n    <p>");
#nullable restore
#line 15 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
  Write(prod.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <br />\r\n    <p>");
#nullable restore
#line 16 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
  Write(prod.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
#nullable restore
#line 18 "C:\Users\awatts4\source\repos\CoffeeShopProductList\CoffeeShopProductList\Views\Product\Detail.cshtml"
    

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
