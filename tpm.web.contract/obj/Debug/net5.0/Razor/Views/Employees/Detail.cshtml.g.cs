#pragma checksum "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Detail), @"mvc.1.0.view", @"/Views/Employees/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\_ViewImports.cshtml"
using tpm.web.contract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\_ViewImports.cshtml"
using tpm.web.contract.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d478", @"/Views/Employees/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4f6ea84b5937f879fbf6ef0ab5d0e2705299a1f53bdbbb98a6425e65faeefcc6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employees_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NhanVien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary ms-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:90px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    label {
        color: #FF0000
    }
</style>

<div class=""content-wrapper"">
    <div class=""content-inner"">
        <div class=""page-header page-header-light shadow"">
            <div class=""page-header-content d-lg-flex border-top"">
                <div class=""d-flex"">
                    <div class=""breadcrumb py-2"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d4787665", async() => {
                WriteLiteral("<i class=\"ph-house\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span class=\"breadcrumb-item active\">Nhân Viên</span>\r\n                        <span class=\"breadcrumb-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d4789299", async() => {
                WriteLiteral("DS Nhân Viên");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                        <span class=\"breadcrumb-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d47810760", async() => {
                WriteLiteral("Thông Tin Nhân Viên");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span>

                    </div>

                    <a href=""#breadcrumb_elements""
                       class=""btn btn-light align-self-center collapsed d-lg-none border-transparent rounded-pill p-0 ms-auto""
                       data-bs-toggle=""collapse"">
                        <i class=""ph-caret-down collapsible-indicator ph-sm m-1""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""content"">
            <div class=""card"">
                <h6 style=""font-size: 30px; text-align: center;margin: 15px 0px;color: #0066FF; "">THÔNG TIN NHÂN VIÊN</h6>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d47812818", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d47813121", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 37 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <input type=""hidden"" />
                    <fieldset style=""margin: 15px !important;"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label  class=""form-label "">Tên NV: </label>
");
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label "">Giới Tính: </label>
                                    <span>");
#nullable restore
#line 50 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                      Write(Model.GioiTinh == 1 ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label "">SĐT: </label>
");
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label "">Email: </label>
");
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label"">Ngày Sinh: </label>
                                    <span>");
#nullable restore
#line 68 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                     Write(Model.NgaySinh.ToString("dd/MM/yyyy").Replace(" ","/"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label "">Nơi Sinh: </label>
");
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label "">Địa Chỉ: </label>
");
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label "">CCCD: </label>
");
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label\">Ngày Cấp: </label>\r\n                                    <span>");
#nullable restore
#line 92 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                     Write(Model.NgayCap.ToString("dd/MM/yyyy").Replace(" ","/"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label \">Nơi Cấp: </label>\r\n");
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label\">Chức Vụ: </label>\r\n");
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label\">Phòng Ban: </label>\r\n");
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label \">Tình Trạng: </label>\r\n                                    <span>");
#nullable restore
#line 122 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                      Write(Model.TinhTrang == 1 ? "Đang Làm" : "Nghỉ Việc");

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label \">Gia Đình: </label>\r\n                                    <span>");
#nullable restore
#line 129 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                      Write(Model.GiaDinh == 1 ? "Có GĐ" : "Chưa có GĐ");

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"mb-3\">\r\n                                    <label ");
                WriteLiteral(" class=\"form-label\">Hình Ảnh: </label>\r\n");
#nullable restore
#line 135 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                     if (ViewBag.ImageDataUrl != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img");
                BeginWriteAttribute("src", " src=\"", 7576, "\"", 7603, 1);
#nullable restore
#line 137 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
WriteAttributeValue("", 7582, ViewBag.ImageDataUrl, 7582, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"100\" />\r\n");
#nullable restore
#line 138 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                            </div>

                        </div>
                    </fieldset>
                    <div style=""justify-content:center !important"" class=""card-footer d-flex justify-content-end"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d47822668", async() => {
                    WriteLiteral("Quay Lại");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404e919593f1a165a3931cc8d8f8c4b74b74a585da5afcd195d2ea6387e5d47824112", async() => {
                    WriteLiteral("Sửa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\DokGo\Documents\HomeStayManagement\tpm.web.contract\Views\Employees\Detail.cshtml"
                                               WriteLiteral(Model?.MaNv);

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
                WriteLiteral("\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
