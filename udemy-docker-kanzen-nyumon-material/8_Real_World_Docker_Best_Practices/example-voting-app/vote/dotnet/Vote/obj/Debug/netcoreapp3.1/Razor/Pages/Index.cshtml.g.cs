#pragma checksum "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70facffd2a53c219edcc984eae4d7bb6eecba32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70facffd2a53c219edcc984eae4d7bb6eecba32", @"/Pages/Index.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.11.1-min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70facffd2a53c219edcc984eae4d7bb6eecba324371", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <title>");
#nullable restore
#line 8 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
      Write(Model.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral(" vs ");
#nullable restore
#line 8 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                        Write(Model.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("!</title>\n    <base href=\"/index.html\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale = 1.0\">\n    <meta name=\"keywords\" content=\"docker-compose, docker, stack\">\n    <meta name=\"author\" content=\"Docker DevRel team\">\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b70facffd2a53c219edcc984eae4d7bb6eecba325533", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70facffd2a53c219edcc984eae4d7bb6eecba327527", async() => {
                WriteLiteral("\n    <div id=\"content-container\">\n        <div id=\"content-container-center\">\n            <h3>");
#nullable restore
#line 19 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
           Write(Model.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral(" vs ");
#nullable restore
#line 19 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                             Write(Model.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("!</h3>\n            <form method=\"POST\" id=\"choice\" name=\'form\'>\n                <button id=\"a\" type=\"submit\" name=\"vote\" class=\"a\" value=\"a\">");
#nullable restore
#line 21 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                                                                        Write(Model.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n                <button id=\"b\" type=\"submit\" name=\"vote\" class=\"b\" value=\"b\">");
#nullable restore
#line 22 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                                                                        Write(Model.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n            </form>\n            <div id=\"tip\">\n                (Tip: you can change your vote)\n            </div>\n            <div id=\"hostname\">\n                Processed by container ID ");
#nullable restore
#line 28 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                                     Write(System.Environment.MachineName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n    </div>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70facffd2a53c219edcc984eae4d7bb6eecba3210073", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                WriteLiteral("\n    <script>\n      var vote = \"");
#nullable restore
#line 36 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
             Write(Model.Vote);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\n\n      if(vote == \"a\"){\n        $(\".a\").prop(\'disabled\', true);\n        $(\".a\").html(\'");
#nullable restore
#line 40 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                 Write(Model.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fa fa-check-circle\"></i>\');\n        $(\".b\").css(\'opacity\',\'0.5\');\n      }\n      if(vote == \"b\"){\n        $(\".b\").prop(\'disabled\', true);\n        $(\".b\").html(\'");
#nullable restore
#line 45 "C:\dev\GitHub\Docker\udemy-docker-kanzen-nyumon-material\8_Real_World_Docker_Best_Practices\example-voting-app\vote\dotnet\Vote\Pages\Index.cshtml"
                 Write(Model.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fa fa-check-circle\"></i>\');\n        $(\".a\").css(\'opacity\',\'0.5\');\n      }\n    </script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vote.Pages.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Vote.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Vote.Pages.IndexModel>)PageContext?.ViewData;
        public Vote.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
