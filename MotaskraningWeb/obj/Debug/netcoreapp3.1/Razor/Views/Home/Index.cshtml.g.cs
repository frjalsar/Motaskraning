#pragma checksum "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc7051da1bf9e4ac397aacff5941d136fe59115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\_ViewImports.cshtml"
using MotaskraningWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\_ViewImports.cshtml"
using MotaskraningWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc7051da1bf9e4ac397aacff5941d136fe59115", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d1771f45b201f48030086514744767c312fa87d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MotaskraningWeb.Models.MotaskraningModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Motaskraning";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Motaskraning</h1>

<!-- div>
    <a>Móthaldari: </a>
    <input value=""Go!"" onclick="""" />
</div>
<div>
    <a>Staðsetning móts: </a>
    <input value=""Go!"" onclick="""" />
</div>
<div>
    <a>Dómari: </a>
    <input value=""Go!"" onclick="""" />
</div -->
<!--link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
<link rel=""stylesheet"" href=""/resources/demos/style.css"">-->
<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
<!--<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>-->

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
");
#nullable restore
#line 28 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
             using (Html.BeginForm("Index", "Home", FormMethod.Post))
            {

                // @Html.HiddenFor(model => model.EmpID)


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group input-group-sm\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.LabelFor(model => model.skraning.DagsFra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(model => model.skraning.DagsFra, new { @class = "form-control datepicker", placeholder = "Enter Drop-off date here..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.skraning.DagsFra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.LabelFor(model => model.skraning.motshaldari, "Mótshaldari"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 41 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(model => model.skraning.motshaldari, ViewBag.CityList2 as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.LabelFor(model => model.skraning.stadsetning, "staðsetning"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(model => model.skraning.stadsetning, ViewBag.CityList3 as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.LabelFor(model => model.skraning.domari, "Dómari"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(model => model.skraning.domari, ViewBag.CityList as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral(@"                <table id=""children"">
                    <tbody>
                        <!-- tr>
                            <td><strong>Grein</strong></td>
                            <td><strong>Gerð greinar</strong></td>
                            <td><strong>Takkar</strong></td>
                        </tr -->
                        <tr>
                            <td><strong>Greinar:</strong></td>
                        </tr>
");
#nullable restore
#line 63 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
                         if (Model.skraning.greinar != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
                             foreach (var grein in Model.skraning.greinar)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    ");
#nullable restore
#line 68 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
                               Write(Html.Partial("_Grein", grein));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <strong>Bæta við grein: </strong>
                <button type=""button"" class=""btn btn-secondary"" id=""addChild"" onclick=""AddOne()"">Úti Karla</button>
                <button type=""button"" class=""btn btn-secondary"" id=""addChild"" onclick=""AddOne2()"">Úti Kvenna</button>
                <button type=""button"" class=""btn btn-secondary"" id=""addChild"" onclick=""AddOne3()"">Inni Karla</button>
                <button type=""button"" class=""btn btn-secondary"" id=""addChild"" onclick=""AddOne4()"">Inni Kvenna</button>
                <br />
                <input type=""submit"" class=""btn btn-primary "" value=""Senda mót"" />
");
#nullable restore
#line 81 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>



<script type=""text/javascript"">

    /*$(function () { // will trigger when the document is ready
       $('.datepicker').datepicker(); //Initialise any date pickers
    });*/


    function AddOne() {

        $.ajax({
             url: """);
#nullable restore
#line 99 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
              Write(Url.Action("AddChild", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: {
            },
            type: ""Get"",
            dataType: ""html"",
             success: function (data) {
                //Whatever result you have got from your controller with html partial view replace with a specific html.
                 $('#children> tbody:last-child').append(data);
                 // $(""#ThresholdmodalPartialView"").html(data); // HTML DOM replace
            }
        });
    }

    function AddOne2() {

        $.ajax({
             url: """);
#nullable restore
#line 115 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
              Write(Url.Action("AddChild2", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: {
            },
            type: ""Get"",
            dataType: ""html"",
             success: function (data) {
                //Whatever result you have got from your controller with html partial view replace with a specific html.
                 $('#children> tbody:last-child').append(data);
                 // $(""#ThresholdmodalPartialView"").html(data); // HTML DOM replace
            }
        });
    }

    function AddOne3() {

        $.ajax({
             url: """);
#nullable restore
#line 131 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
              Write(Url.Action("AddChild3", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: {
            },
            type: ""Get"",
            dataType: ""html"",
             success: function (data) {
                //Whatever result you have got from your controller with html partial view replace with a specific html.
                 $('#children> tbody:last-child').append(data);
                 // $(""#ThresholdmodalPartialView"").html(data); // HTML DOM replace
            }
        });
    }

    function AddOne4() {

        $.ajax({
             url: """);
#nullable restore
#line 147 "C:\Users\Stein\Documents\GitHub\Motaskraning\MotaskraningWeb\Views\Home\Index.cshtml"
              Write(Url.Action("AddChild4", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: {
            },
            type: ""Get"",
            dataType: ""html"",
             success: function (data) {
                //Whatever result you have got from your controller with html partial view replace with a specific html.
                 $('#children> tbody:last-child').append(data);
                 // $(""#ThresholdmodalPartialView"").html(data); // HTML DOM replace
            }
        });
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MotaskraningWeb.Models.MotaskraningModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
