#pragma checksum "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92ac8decb288d7111b75b76820d9dbe65aad3fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\_ViewImports.cshtml"
using FinancialAidAllocationTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\_ViewImports.cshtml"
using FinancialAidAllocationTool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ac8decb288d7111b75b76820d9dbe65aad3fd5", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df650b1438e04e1d76f7e1f1a3e3493ff465c799", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            DefineSection("head", async() => {
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n         body {\r\n            margin: 0;\r\n            \r\n            background-size: cover;\r\n        }\r\n    </style>\r\n");
            }
            );
#nullable restore
#line 14 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
 if(User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
 if(TempData["error"] != null && !TempData["error"].Equals(""))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
Write(Html.Raw(TempData["error"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                                ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"Dbox\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 391, "\"", 399, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""text-align: center;margin-top:5px;"">
		<h5 style=""color: white;"">Dash Board</h5>
     	<div class=""row"">
			    <div class=""col-lg-2 col-md-2 col-sm-2""></div>
			    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
               
					<div class=""Dbox-part text-center"">
                        
                            <a style=""font-size:50px;"" class=""text-info""><i class=""fas fa-cog""></i></a>                         
						<div class=""title"">
							<h4>Settings</h4>
						</div>
                        
						<div class=""Dtext"">
							<label class=""Dspan"" style=""font-weight: bold;"">Total Budget:</label>
            				<label>");
#nullable restore
#line 36 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["Budget"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t<br>\r\n                            <label class=\"Dspan\" style=\"font-weight: bold;\">Merit Min CGPA:</label>\r\n\t\t\t\t\t\t\t<label>");
#nullable restore
#line 39 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["MeritCgpa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t<label class=\"Dspan\" style=\"font-weight: bold;\">Need Min CGPA:</label>\r\n   \t\t\t\t\t\t\t<label>");
#nullable restore
#line 42 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                                 Write(TempData["NeedCgpa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
   
    
						</div>
                        
                        
					 </div>
				</div>	 
				
				 <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
               
					<div class=""Dbox-part text-center"" style=""padding-bottom: 40px;"">
					    
					   <a style=""font-size:50px;"" class=""text-success""><i class=""fas fa-check""></i></a>
                    
						<div class=""title"">
							<h4>Accepted Students</h4>
						</div>
                        
						<div class=""Dtext"">
							<label class=""Dspan"" style=""font-weight: bold;""><i class='fas fa-award'></i>  Merit Based:</label>
							<label>");
#nullable restore
#line 63 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["MeritAccept"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t<label class=\"Dspan\" style=\"font-weight: bold;\"><i class=\"fa fa-graduation-cap\" aria-hidden=\"true\"></i>  Need Based:</label>\r\n                            <label>");
#nullable restore
#line 66 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["NeedAccept"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            
						</div>
                        
						
                        
					 </div>
				</div>
     	</div>
         <div class=""row"">	 
				<div class=""col-lg-2 col-md-2 col-sm-2""></div>
				 <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
               
					<div class=""Dbox-part text-center"" style=""padding-bottom: 40px;"">
                        
                        <a style=""font-size:50px;"" class=""text-danger""><i class=""fas fa-times""></i></a>
                        
						<div class=""title"">
							<h4>Rejected Students</h4>
						</div>
                        
						<div class=""Dtext"">
							<label class=""Dspan"" style=""font-weight: bold;""><i class='fas fa-award'></i>  Merit Based:</label>
							<label>");
#nullable restore
#line 89 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["MeritReject"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t<label class=\"Dspan\" style=\"font-weight: bold;\"><i class=\"fa fa-graduation-cap\" aria-hidden=\"true\"></i>  Need Based:</label>\r\n                            <label>");
#nullable restore
#line 92 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["NeedReject"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>

						</div>
                        
						
                        
					 </div>
				</div>	 
				
				<div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
               
					<div class=""Dbox-part text-center"" style=""padding-bottom: 40px;"">
                        
                        <a style=""font-size:50px;"" class=""text-primary""><i class=""fas fa-users""></i></a>
                        
						<div class=""title"">
							<h4>Registered Users</h4>
						</div>
                        
						<div class=""Dtext"">
							<label class=""Dspan"" style=""font-weight: bold;"">Student:</label>
							<label>");
#nullable restore
#line 113 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["Student"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t<label class=\"Dspan\" style=\"font-weight: bold;\">Committee Members:</label>\r\n                            <label>");
#nullable restore
#line 116 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
                              Write(TempData["Committee"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n                        \r\n\t\t\t\t\t\t\r\n                        \r\n\t\t\t\t\t </div>\r\n\t\t\t\t</div>\t \r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t\r\n\t\t\r\n\t\t</div>\t\t\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 132 "C:\Users\muham\Source\Repos\FinancialAidAllocationTool\FinancialAidAllocationTool\Views\Home\Dashboard.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591