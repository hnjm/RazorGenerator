#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleRazorHelperLibrary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorSingleFileGenerator", "1.0.0.0")]
    public static class MvcHelperSamples
    {
#line hidden
#line hidden
public static System.Web.WebPages.HelperResult WriteList(this HtmlHelper helper, IEnumerable<string> items) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {


                                                                      

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <ul>\r\n");


         foreach (var s in items) {

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <li>\r\n                ");


WebViewPage.WriteTo(@__razor_helper_writer, s);

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " (From helper)\r\n            </li>\r\n");


        }

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </ul>\r\n");



});

}


    }
}
#pragma warning restore 1591
