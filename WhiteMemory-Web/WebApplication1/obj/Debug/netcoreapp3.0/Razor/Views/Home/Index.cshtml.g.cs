#pragma checksum "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e66b4013088c835cb54856ffc80d956676efd2d"
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
#line 1 "C:\tema\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\tema\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e66b4013088c835cb54856ffc80d956676efd2d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication1.Models.BlockchainContract>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Welcome To BlockChainFirstStep!</h1>

</div>

<canvas class=""my-4 w-100"" id=""myChart"" width=""900"" height=""150""></canvas>
<div class=""row"">
    <div class=""col-md-6"">
        <h2>White Memory</h2>
    </div>
    <div class=""col-md-6"">
        <a class=""btn btn-primary text-white"" href=""/"">Update</a>
        <a class=""btn btn-success text-white"" href=""home/create"">Create New</a>
    </div>
</div>
<div class=""table-responsive"">
    <table class=""table table-striped table-sm"">
        <thead>
            <tr>
                <th>#</th>
                <th>Last Name</th>
                <th>First Name</th>
                <th>Middle Name</th>
                <th>Birthday</th>
                <th>Date of Death</th>
                <th>GPS</th>
                <th>Country</th>
                <th>City</th>
                <th>Additional Info</th>
                <th>Sync</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 38 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>#</td>\r\n                <td>");
#nullable restore
#line 42 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.DateOfDath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.GPS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><span");
            BeginWriteAttribute("id", " id=\"", 1571, "\"", 1584, 1);
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1576, item.Id, 1576, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#171;");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                         Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                         Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                          Write(item.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                                            Write(item.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                                                            Write(item.DateOfDath);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                                                                              Write(item.GPS);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                                                                                         Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                                                                                                        Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#187;</span></td>\r\n                <td> <a");
            BeginWriteAttribute("id", " id=\"", 1757, "\"", 1774, 2);
            WriteAttributeValue("", 1762, "btn-", 1762, 4, true);
#nullable restore
#line 51 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1766, item.Id, 1766, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-white\" href=\"/\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1818, "\"", 1864, 4);
            WriteAttributeValue("", 1828, "return", 1828, 6, true);
            WriteAttributeValue(" ", 1834, "sendToBlockchaine(\'", 1835, 20, true);
#nullable restore
#line 51 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1854, item.Id, 1854, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1862, "\')", 1862, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Send to Blockchain</a>\r\n                     <span");
            BeginWriteAttribute("id", " id=\"", 1916, "\"", 1934, 2);
            WriteAttributeValue("", 1921, "span-", 1921, 5, true);
#nullable restore
#line 52 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1926, item.Id, 1926, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\tema\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n    \r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    function sendToBlockchaine(id) {

        alert(""Congratulation! This data : "" + $(""#"" + id).text() + "" successfully send to BLOCKCHAIN!"");
        $(""#btn-"" + id).hide();
        $(""#span-"" + id).text(""BlockChain Synchronized!"");
        return false;
    }
</script>
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/feather-icons/4.9.0/feather.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.min.js""></script>
<script src=""js/dashboard.js""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication1.Models.BlockchainContract>> Html { get; private set; }
    }
}
#pragma warning restore 1591
