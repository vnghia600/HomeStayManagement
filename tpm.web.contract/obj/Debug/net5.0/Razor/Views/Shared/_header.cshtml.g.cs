#pragma checksum "E:\Source\tpm.contract\tpm.web.contract\Views\Shared\_header.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5fd9640b9227d13565e1cba23a160dbe9ea93960348473c68b50f1d0e1a6d70a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__header), @"mvc.1.0.view", @"/Views/Shared/_header.cshtml")]
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
#line 1 "E:\Source\tpm.contract\tpm.web.contract\Views\_ViewImports.cshtml"
using tpm.web.contract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Source\tpm.contract\tpm.web.contract\Views\_ViewImports.cshtml"
using tpm.web.contract.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5fd9640b9227d13565e1cba23a160dbe9ea93960348473c68b50f1d0e1a6d70a", @"/Views/Shared/_header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4f6ea84b5937f879fbf6ef0ab5d0e2705299a1f53bdbbb98a6425e65faeefcc6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tpm.dto.admin.UserPrincipal>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Main navbar -->\r\n<div class=\"navbar navbar-expand-xl navbar-static shadow\">\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"navbar-brand flex-1\">\r\n\t\t\t<a href=\"index.html\" class=\"d-inline-flex align-items-center\">\r\n\t\t\t\t<img src=\"/tpm/images/logo1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 290, "\"", 296, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"			</a>
		</div>

		<div class=""d-flex w-100 w-xl-auto overflow-auto overflow-xl-visible scrollbar-hidden border-top border-top-xl-0 order-1 order-xl-0 pt-2 pt-xl-0 mt-2 mt-xl-0"">
			<ul class=""nav gap-1 justify-content-center flex-nowrap flex-xl-wrap mx-auto"">
				<li class=""nav-item"">
					<a href=""/Home"" class=""navbar-nav-link rounded"">
");
            WriteLiteral(@"						<i class=""ph-house me-2""></i>
						Home
					</a>
				</li>

				<li class=""nav-item nav-item-dropdown-xl dropdown"">
					<a href=""#"" class=""navbar-nav-link dropdown-toggle rounded"" data-bs-toggle=""dropdown"">
						<i class=""ph-list-bullets me-2""></i>
						Category
					</a>
					<div class=""dropdown-menu"">
						<a href=""/Employees"" class=""dropdown-item rounded"">Danh sách</a>
					</div>
				</li>

				<li class=""nav-item nav-item-dropdown-xl dropdown"">
					<a href=""#"" class=""navbar-nav-link dropdown-toggle rounded"" data-bs-toggle=""dropdown"">
						<i class=""ph-mask-happy me-2""></i>
						Author
					</a>
					<div class=""dropdown-menu"">
						<a href=""/Contracts"" class=""dropdown-item rounded"">Danh sách</a>
						<a href=""/Contracts/Create"" class=""dropdown-item rounded"">Thêm mới</a>
					</div>
				</li>
			</ul>
		</div>

		<ul class=""nav gap-1 flex-xl-1 justify-content-end order-0 order-xl-1"">
			<li class=""nav-item nav-item-dropdown-xl dropdown"">
				<a href=""#"" clas");
            WriteLiteral("s=\"navbar-nav-link align-items-center rounded-pill p-1\" data-bs-toggle=\"dropdown\">\r\n");
            WriteLiteral("\t\t\t\t\t<span");
            BeginWriteAttribute("class", " class=\"", 2065, "\"", 2116, 3);
            WriteAttributeValue("", 2073, "name-icon", 2073, 9, true);
            WriteAttributeValue(" ", 2082, "name-icon-", 2083, 11, true);
#nullable restore
#line 51 "E:\Source\tpm.contract\tpm.web.contract\Views\Shared\_header.cshtml"
WriteAttributeValue("", 2093, Html.Raw(Model.CFName), 2093, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n\t\t\t\t\t<span class=\"d-none d-md-inline-block mx-md-2\">");
#nullable restore
#line 52 "E:\Source\tpm.contract\tpm.web.contract\Views\Shared\_header.cshtml"
                                               Write(Html.Raw(string.Format("{0}", Model.FullName)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
				</a>

				<div class=""dropdown-menu dropdown-menu-end"">
					<a href=""#"" class=""dropdown-item"">
						<i class=""ph-user-circle me-2""></i>
						My profile
					</a>
					<div class=""dropdown-divider""></div>
					<a href=""#"" class=""dropdown-item"">
						<i class=""ph-gear me-2""></i>
						Account settings
					</a>
					<a href=""/Accounts/Logout"" class=""dropdown-item"">
						<i class=""ph-sign-out me-2""></i>
						Logout
					</a>
				</div>
			</li>
		</ul>
	</div>
</div>
<!-- /main navbar -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tpm.dto.admin.UserPrincipal> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
