#pragma checksum "D:\Dropbox\VisualStudioProjects\Projects\WebAppRfc\WebAppRfc\Views\NewDevice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7979a3c92bd5345f6936072d8ea47e454ac9a820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewDevice_Index), @"mvc.1.0.view", @"/Views/NewDevice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewDevice/Index.cshtml", typeof(AspNetCore.Views_NewDevice_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7979a3c92bd5345f6936072d8ea47e454ac9a820", @"/Views/NewDevice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90c131eb4fc474f8be073ba9427ab21d9f6bfbb", @"/Views/_ViewImports.cshtml")]
    public class Views_NewDevice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Dropbox\VisualStudioProjects\Projects\WebAppRfc\WebAppRfc\Views\NewDevice\Index.cshtml"
  
    ViewData["Title"] = "AddNewDevice";

#line default
#line hidden
            BeginContext(50, 1347, true);
            WriteLiteral(@"
<div class=""panel panel-primary"" style=""display:inline-block"">
    <h2 class=""panel-heading"">Adding new device</h2>
    <div id=""app_controller_addNewDev"" ng-controller=""addNewDev as newDev"" ng-init=""newDev.Init()"" class=""panel-body"">
        <button class=""btn-success"" ng-click=""newDev.ShowBaseFromNewDev()"">Test base from newDevController</button>
        <div>
            <input type=""text"" ng-model=""newDev.Name"" placeholder=""Device Name"" />
        </div>
        <div>
            <select ng-model=""newDev.selectedType"" ng-options=""type.name for type in newDev.DevTypes""> </select>
        </div>
        <div>
            <select ng-model=""newDev.selectedRoom"" ng-options=""room for room in newDev.myFactory.Rooms"" ng-change=""newDev.RoomSelected(newDev.Name,newDev.selectedRoom,newDev.selectedType)""> </select>
        </div>

        <div ng-show=""newDev.selectedType.id == 1 || newDev.selectedType.id == 2"">
            <input class=""btn-primary"" type=""button"" ng-click=""newDev.BindClicked()"" valu");
            WriteLiteral(@"e=""Send Bind""/>
        </div>

        <div>
            <input type=""button"" value=""Add"" ng-click=""newDev.AddClicked()"" />
        </div>
        <div class=""center-block""> 
            <label  class=""bg-success text-center""  ng-model=""newDev.Status"">{{newDev.Status}}</label>
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
