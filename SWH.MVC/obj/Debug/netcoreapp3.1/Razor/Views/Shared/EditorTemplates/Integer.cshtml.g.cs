#pragma checksum "C:\Users\Matyi\Desktop\SWH3\SWH\SWH.MVC\Views\Shared\EditorTemplates\Integer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16edb573dd69fae30e055e294f0868be6afdff59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Integer), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Integer.cshtml")]
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
#line 1 "C:\Users\Matyi\Desktop\SWH3\SWH\SWH.MVC\Views\_ViewImports.cshtml"
using SWH.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matyi\Desktop\SWH3\SWH\SWH.MVC\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16edb573dd69fae30e055e294f0868be6afdff59", @"/Views/Shared/EditorTemplates/Integer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b20011ac72ef705a1a98e7c6c78f047426784b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_EditorTemplates_Integer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int?>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Matyi\Desktop\SWH3\SWH\SWH.MVC\Views\Shared\EditorTemplates\Integer.cshtml"
Write(Html.Kendo().IntegerTextBoxFor(m => m)
      .HtmlAttributes(new { style = "width:100%", title = Html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName("")})
      .Min(int.MinValue)
      .Max(int.MaxValue)
);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int?> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
