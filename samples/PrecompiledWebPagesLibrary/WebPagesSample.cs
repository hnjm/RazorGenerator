﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrecompiledWebPagesHelper
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/WebPagesSample.cshtml")]
    public class WebPagesSample : System.Web.WebPages.WebPage
    {
#line hidden

                // Resolve package relative syntax
                // Also, if it comes from a static embedded resource, change the path accordingly
                public override string Href(string virtualPath, params object[] pathParts) {
                    virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                    return base.Href(virtualPath, pathParts);
                }
        public WebPagesSample()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n\r\n<ul>\r\n    <li>\r\n        This precompiled page was served to you at ");


            
            #line 5 "D:\forks\razorsinglefilegenerator\PrecompiledWebPagesHelper\WebPagesSample.cshtml"
                                              Write(DateTime.Now);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </li>\r\n    <li>\r\n        <a href=\"");


            
            #line 8 "D:\forks\razorsinglefilegenerator\PrecompiledWebPagesHelper\WebPagesSample.cshtml"
            Write(Href("@/WebPagesSample"));

            
            #line default
            #line hidden
WriteLiteral(@""">Hyperlinks</a> inside ApplicationParts can be rooted to the base virtual path that is registered.    
    </li>
    <li>
        Application parts can also serve embedded resources. For instance, this cake is not a lie: 
        <br />
        <img src=""");


            
            #line 13 "D:\forks\razorsinglefilegenerator\PrecompiledWebPagesHelper\WebPagesSample.cshtml"
             Write(Href("@/Images/Cake.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Delicious chocolate cake - Courtesy Bakery Template, WebMatrix\" />\r\n    </" +
"li>\r\n</ul>\r\n    ");


        }
    }
}
#pragma warning restore 1591