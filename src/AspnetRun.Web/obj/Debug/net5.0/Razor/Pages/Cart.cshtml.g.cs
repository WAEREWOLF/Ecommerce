#pragma checksum "C:\Users\ANGHEL PAUL\Source\Repos\Ecommerce\src\AspnetRun.Web\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08d525d9548c9ea83d5b76c643bce20d8173d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspnetRun.Web.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace AspnetRun.Web.Pages
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
#line 1 "C:\Users\ANGHEL PAUL\Source\Repos\Ecommerce\src\AspnetRun.Web\Pages\_ViewImports.cshtml"
using AspnetRun.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08d525d9548c9ea83d5b76c643bce20d8173d11", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b71149c17db55ad7a4c5d04610586169cc4ef53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGHEL PAUL\Source\Repos\Ecommerce\src\AspnetRun.Web\Pages\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Cart Page Start -->\r\n<div class=\"page-section section pt-90 pb-50\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d113902", async() => {
                WriteLiteral(@"
                    <!-- Cart Table -->
                    <div class=""cart-table table-responsive mb-40"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""pro-thumbnail"">Image</th>
                                    <th class=""pro-title"">Product</th>
                                    <th class=""pro-price"">Price</th>
                                    <th class=""pro-quantity"">Quantity</th>
                                    <th class=""pro-subtotal"">Total</th>
                                    <th class=""pro-remove"">Remove</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""pro-thumbnail""><a href=""#""><img src=""assets/images/product/product-1.png"" alt=""Product""></a></td>
                                    <td class=""pro-titl");
                WriteLiteral(@"e""><a href=""#"">Zeon Zen 4 Pro</a></td>
                                    <td class=""pro-price""><span>$295.00</span></td>
                                    <td class=""pro-quantity""><div class=""pro-qty""><input type=""text"" value=""1""></div></td>
                                    <td class=""pro-subtotal""><span>$295.00</span></td>
                                    <td class=""pro-remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                </tr>
                                <tr>
                                    <td class=""pro-thumbnail""><a href=""#""><img src=""assets/images/product/product-2.png"" alt=""Product""></a></td>
                                    <td class=""pro-title""><a href=""#"">Aquet Drone D 420</a></td>
                                    <td class=""pro-price""><span>$275.00</span></td>
                                    <td class=""pro-quantity""><div class=""pro-qty""><input type=""text"" value=""2""></div></td>
                                    <td class=");
                WriteLiteral(@"""pro-subtotal""><span>$550.00</span></td>
                                    <td class=""pro-remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                </tr>
                                <tr>
                                    <td class=""pro-thumbnail""><a href=""#""><img src=""assets/images/product/product-3.png"" alt=""Product""></a></td>
                                    <td class=""pro-title""><a href=""#"">Game Station X 22</a></td>
                                    <td class=""pro-price""><span>$295.00</span></td>
                                    <td class=""pro-quantity""><div class=""pro-qty""><input type=""text"" value=""1""></div></td>
                                    <td class=""pro-subtotal""><span>$295.00</span></td>
                                    <td class=""pro-remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                </tr>
                                <tr>
                                    <td class=""pro-thumbnail""><a ");
                WriteLiteral(@"href=""#""><img src=""assets/images/product/product-4.png"" alt=""Product""></a></td>
                                    <td class=""pro-title""><a href=""#"">Roxxe Headphone Z 75 </a></td>
                                    <td class=""pro-price""><span>$110.00</span></td>
                                    <td class=""pro-quantity""><div class=""pro-qty""><input type=""text"" value=""1""></div></td>
                                    <td class=""pro-subtotal""><span>$110.00</span></td>
                                    <td class=""pro-remove""><a href=""#""><i class=""fa fa-trash-o""></i></a></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <div class=""row"">

                    <div class=""col-lg-6 col-12 mb-15"">
                        <!-- Calculate Shipping -->
                        <div class=""calculate-shipping"">
                            <h4>Calculate Shipping</h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d119574", async() => {
                WriteLiteral("\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6 col-12 mb-25\">\r\n                                        <select class=\"nice-select\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1110082", async() => {
                    WriteLiteral("Bangladesh");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1111145", async() => {
                    WriteLiteral("China");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1112203", async() => {
                    WriteLiteral("country");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1113263", async() => {
                    WriteLiteral("India");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1114321", async() => {
                    WriteLiteral("Japan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <select class=""nice-select"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1115620", async() => {
                    WriteLiteral("Dhaka");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1116678", async() => {
                    WriteLiteral("Barisal");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1117738", async() => {
                    WriteLiteral("Khulna");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1118797", async() => {
                    WriteLiteral("Comilla");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1119857", async() => {
                    WriteLiteral("Chittagong");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <input type=""text"" placeholder=""Postcode / Zip"">
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <input type=""submit"" value=""Estimate"">
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <!-- Discount Coupon -->\r\n                        <div class=\"discount-coupon\">\r\n                            <h4>Discount Coupon Code</h4>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08d525d9548c9ea83d5b76c643bce20d8173d1122744", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <input type=""text"" placeholder=""Coupon Code"">
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <input type=""submit"" value=""Apply Code"">
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                    <!-- Cart Summary -->
                    <div class=""col-lg-6 col-12 mb-40 d-flex"">
                        <div class=""cart-summary"">
                            <div class=""cart-summary-wrap"">
                                <h4>Cart Summary</h4>
                                <p>Sub Total <span>$1250.00</span></p>
                                <p>Shipping Cost <span>$00.00</span></p>
                                <h2>Grand Total <span>$1250.00</span></h2>
                            </div>
                            <div class=""cart-summary-button"">
                                <button class=""checkout-btn"">Checkout</button>
                                <button class=""update-btn"">Update Cart</button>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</div>
<!-- Cart Page End -->");
            WriteLiteral("\n\r\n\r\n\r\n");
            DefineSection("CartNotRequired", async() => {
                WriteLiteral("\r\n\r\n    <!-- Not need to render Shopping Cart in Cart Page -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspnetRun.Web.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRun.Web.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRun.Web.Pages.CartModel>)PageContext?.ViewData;
        public AspnetRun.Web.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
