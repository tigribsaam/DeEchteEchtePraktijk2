#pragma checksum "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af5e6e7070029de19d22c9bee99ebbc3a8dd025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Orders), @"mvc.1.0.view", @"/Views/Order/Orders.cshtml")]
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
#line 1 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af5e6e7070029de19d22c9bee99ebbc3a8dd025", @"/Views/Order/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1653c4935ed204a0ba7941e3c8dbbf94c531f33", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnArt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1> Bestel geschiedenis</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
 if (Model.OrdersFromId.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
     foreach (var order in Model.OrdersFromId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-bordered table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th colspan=\"6\"> ");
#nullable restore
#line 12 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                                Write(order.OrderPlaced.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                </tr>
                <tr>
                    <th>Naam</th>
                    <th></th>
                    <th>Aantal Maanden</th>
                    <th>Prijs</th>
                    <th>Uiterlijk terug brengen voor:</th>
                    <th></th>
                </tr>
            </thead>


            <tbody>
");
#nullable restore
#line 26 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                 foreach (var item in order.OrderDetails)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-left\">");
#nullable restore
#line 29 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                                         Write(item.Art.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-left\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1af5e6e7070029de19d22c9bee99ebbc3a8dd0257408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 941, "~/images/", 941, 9, true);
#nullable restore
#line 31 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
AddHtmlAttributeValue("", 950, item.Art.ImageURL, 950, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
AddHtmlAttributeValue("", 975, item.Art.Name, 975, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                       Write(item.Months);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                       Write(order.OrderPlaced.AddMonths(item.Months).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 37 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                             if (item.Returned)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i>Terug gebracht</i>\r\n");
#nullable restore
#line 40 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1af5e6e7070029de19d22c9bee99ebbc3a8dd02511280", async() => {
                WriteLiteral("terug brengen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-artId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                                        WriteLiteral(item.ArtId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["artId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-artId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["artId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                                          WriteLiteral(order.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                                                WriteLiteral(item.OrderDetailId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderDetailId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderDetailId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderDetailId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n                    <td class=\"text-right\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
                   Write(order.OrderTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n");
#nullable restore
#line 66 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
     

}
else if (Model.OrdersFromId.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>U heeft nog niet iets eerder gekocht.</h2>\r\n");
#nullable restore
#line 72 "C:\Users\Birgi\source\repos\tigribsaam\DeEchteEchtePraktijk2\WebApplication1\WebApplication1\Views\Order\Orders.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
