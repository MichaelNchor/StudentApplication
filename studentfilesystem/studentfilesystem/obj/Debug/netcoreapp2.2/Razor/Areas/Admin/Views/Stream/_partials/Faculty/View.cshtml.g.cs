#pragma checksum "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345a5faa1946f287b7a05d64aadd9f284a61bfda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Stream__partials_Faculty_View), @"mvc.1.0.view", @"/Areas/Admin/Views/Stream/_partials/Faculty/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Stream/_partials/Faculty/View.cshtml", typeof(AspNetCore.Areas_Admin_Views_Stream__partials_Faculty_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345a5faa1946f287b7a05d64aadd9f284a61bfda", @"/Areas/Admin/Views/Stream/_partials/Faculty/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Stream__partials_Faculty_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 504, true);
            WriteLiteral(@"<div class=""card-body"">
    <div class=""table-responsive"">
        <table class=""table table-striped"">
            <thead class=""text-primary"">
                <tr>
                    <th>
                        Faculty Name
                    </th>
                    <th>
                        College Name
                    </th>
                    <th>
                        Actions
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 18 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                 foreach (var faculty in ViewBag.faculties)
                {

#line default
#line hidden
            BeginContext(584, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(669, 19, false);
#line 22 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                       Write(faculty.FacultyName);

#line default
#line hidden
            EndContext();
            BeginContext(688, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 25 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                             foreach(var college in ViewBag.colleges){
                                

#line default
#line hidden
#line 26 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                                 if (faculty.CollegeId == college.CollegeId)
                                {
                                    

#line default
#line hidden
            BeginContext(973, 19, false);
#line 28 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                               Write(college.CollegeName);

#line default
#line hidden
            EndContext();
#line 28 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                                                        
                                }

#line default
#line hidden
#line 29 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(1060, 459, true);
            WriteLiteral(@"                        </td>
                        <td class=""text-right"">
                            <button class=""btn btn-round btn-info btn-icon btn-sm like"" data-toggle=""modal"" data-target=""#edit-faculty""><i class=""now-ui-icons users_single-02""></i></button>
                            <button class=""btn btn-round btn-danger btn-icon btn-sm remove""><i class=""fa fa-times""></i></button>
                        </td>
                    </tr>
");
            EndContext();
#line 37 "C:\Users\UITS-PC\source\repos\studentfilesystem\studentfilesystem\Areas\Admin\Views\Stream\_partials\Faculty\View.cshtml"
                }

#line default
#line hidden
            BeginContext(1538, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
