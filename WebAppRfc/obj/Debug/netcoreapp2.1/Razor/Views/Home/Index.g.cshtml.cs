#pragma checksum "D:\Dropbox\VisualStudioProjects\Projects\WebAppRfc\WebAppRfc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4770f6485a61a8f61646b5e75a0ef72b75e80fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Dropbox\VisualStudioProjects\Projects\WebAppRfc\WebAppRfc\Views\_ViewImports.cshtml"
using WebAppRfc;

#line default
#line hidden
#line 2 "D:\Dropbox\VisualStudioProjects\Projects\WebAppRfc\WebAppRfc\Views\_ViewImports.cshtml"
using WebAppRfc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4770f6485a61a8f61646b5e75a0ef72b75e80fa6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90c131eb4fc474f8be073ba9427ab21d9f6bfbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Dropbox\VisualStudioProjects\Projects\WebAppRfc\WebAppRfc\Views\Home\Index.cshtml"
  
    ViewBag.DevCount = Program.DevBase.Data.Count;

#line default
#line hidden
            BeginContext(59, 1350, true);
            WriteLiteral(@"

<div>
    <div id=""app_controller"" ng-controller=""appController as devView"" ng-init=""devView.GetDevBase()"">
        <h1>NooLite Controller for Web</h1>

        <h2>There are {{devView.myFactory.DevCount}} NooLite devices</h2>
        <div style=""margin-left:auto; margin-right:auto"">
            <div ng-model=""devView.myFactory.DevBase"" ng-repeat=""dev in devView.myFactory.DevBase track by dev.key"" class=""panel panel-default"" style=""min-width: 150px; max-width: 150px; display:inline-grid"">
                <div class=""panel-heading text-center"">{{dev.name}} </div>
                <div class=""panel-body"">
                    <p> Key: {{dev.key}}</p>
                    <p>
                        State: <span class=""label-success"" ng-show=""(dev.state != 0)""> On </span>
                        <span ng-show=""!(dev.state != 0)""> Off </span>
                    </p>
                    <p ng-model=""dev.bright""> Bright: {{dev.bright}}</p>
                    <p> <input ng-model=""dev.bright"" type=""");
            WriteLiteral(@"range"" class=""label-success"" ng-click=""devView.SetBright(dev.key, dev.bright)"" /> </p>
                    <p> <input ng-click=""devView.SetSwitch(dev.key)"" type=""button"" title=""Switch"" value=""Switch"" class=""btn btn-primary center-block"" /></p>
                </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
