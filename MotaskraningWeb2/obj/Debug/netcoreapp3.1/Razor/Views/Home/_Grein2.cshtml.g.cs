#pragma checksum "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\Home\_Grein2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9a7113d782f6ba2d6643c19001106a02fae75b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Grein2), @"mvc.1.0.view", @"/Views/Home/_Grein2.cshtml")]
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
#line 1 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\_ViewImports.cshtml"
using MotaskraningWeb2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\_ViewImports.cshtml"
using MotaskraningWeb2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\Home\_Grein2.cshtml"
using HtmlHelpers.BeginCollectionItemCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9a7113d782f6ba2d6643c19001106a02fae75b", @"/Views/Home/_Grein2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b6f145bc31728479a767428ecd46b4816e6409", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Grein2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Grein>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\Home\_Grein2.cshtml"
 using (Html.BeginCollectionItem("greinar"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>\r\n        ");
#nullable restore
#line 9 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\Home\_Grein2.cshtml"
   Write(Html.DropDownListFor(m => m.nafnGreinar, ViewBag.GreinarInniKvenna as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n");
#nullable restore
#line 11 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\Home\_Grein2.cshtml"



    //new SelectList(ViewBag.CityList4, "Value", "Text")

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- td>\r\n        <a>Gerð greinar: </a> Html.TextBoxFor(m => m.gerdGreinar, new { class = \"form-control\" })\r\n    </td -->\r\n");
            WriteLiteral("    <!-- <td>\r\n        <span class=\"glyphicon glyphicon-trash action-icon\" data-action=\"removeItem\">Eyða</span>\r\n    </td> -->\r\n");
#nullable restore
#line 22 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb2\Views\Home\_Grein2.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grein> Html { get; private set; }
    }
}
#pragma warning restore 1591
