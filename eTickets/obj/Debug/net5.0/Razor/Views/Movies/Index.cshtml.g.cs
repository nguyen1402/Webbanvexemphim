#pragma checksum "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e96486b54ed0c9e3fec4b440f2210568f7ff1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "D:\C#5\buy_movie_tickets\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#5\buy_movie_tickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#5\buy_movie_tickets\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e96486b54ed0c9e3fec4b440f2210568f7ff1c", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865a0b377e3fa3d64066c49d3b515cd9f4a964f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eTickets.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Danh sách phim" + ViewBag.Curren;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\" id=\"record_sp\">\r\n");
#nullable restore
#line 9 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3"">
            <div class=""card mb-3"" style=""max-width: 540px;"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    ");
#nullable restore
#line 18 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e96486b54ed0c9e3fec4b440f2210568f7ff1c6681", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </h5>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1164, "\"", 1184, 1);
#nullable restore
#line 28 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1170, item.ImageURL, 1170, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 1198, "\"", 1214, 1);
#nullable restore
#line 28 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1204, item.Name, 1204, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""col-md-6"">
                        <div class=""card-body"">
                            <p class=""card-text"">
                                <b>
                                    Rạp chiếu phim:
                                </b>");
#nullable restore
#line 35 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                               Write(item.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"card-text\"><b>Thể loại phim: </b>");
#nullable restore
#line 37 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                                                  Write(item.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Ngày bắt đầu chiếu: </b>");
#nullable restore
#line 38 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                                                       Write(item.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Ngày kết thúc: </b>");
#nullable restore
#line 39 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                                                  Write(item.EndDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text \">\r\n                                <b>Trạng thái: </b>\r\n");
#nullable restore
#line 42 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                 if (DateTime.Now >= item.StartDate && DateTime.Now <= item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-success text-white\">CÓ SẴN</span>\r\n");
#nullable restore
#line 45 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                }
                                else if (DateTime.Now > item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-danger text-white\">HẾT HẠN</span>\r\n");
#nullable restore
#line 49 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-primary text-white\">SẮP XẾP</span>\r\n");
#nullable restore
#line 53 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                            <p class=\"card-text\">\r\n                                <b>Tóm Tắt bộ phim</b>\r\n                                ");
#nullable restore
#line 57 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer "">
                            <p class=""card-text"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e96486b54ed0c9e3fec4b440f2210568f7ff1c13969", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-eye-fill\"></i> Show Details\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e96486b54ed0c9e3fec4b440f2210568f7ff1c16392", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-cart-plus\"></i> Thêm vào giỏi hàng (Price ");
#nullable restore
#line 71 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                                                                         Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3425, "btn", 3425, 3, true);
            AddHtmlAttributeValue(" ", 3428, "btn-success", 3429, 12, true);
            AddHtmlAttributeValue(" ", 3440, "text-white", 3441, 11, true);
#nullable restore
#line 67 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
AddHtmlAttributeValue(" ", 3451, (DateTime.Now > item.EndDate) ? "disabled" : "", 3452, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 79 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 82 "D:\C#5\buy_movie_tickets\eTickets\Views\Movies\Index.cshtml"
Write(await Html.PartialAsync("_CreateItem", "Movies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#keyw"").keyup(function () {
                var str = $(""#keyw"").val();
                $.ajax({
                    url: ""/SeachFilms/Timkiem"",
                    datatype: ""JSON"",
                    type: ""POST"",
                    data:
                    {
                        tkf: str
                    },
                    success: function (kq) {
                        $(""#record_sp"").html("""");
                        $(""#record_sp"").html(kq);
                    },
                    error: function () {
                        alert(""....Loi...."");
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eTickets.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591