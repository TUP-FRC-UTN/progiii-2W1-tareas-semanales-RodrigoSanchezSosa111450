#pragma checksum "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c91851a693f87a69683c2ac34f0c0ae7fe704bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_DatosPersona), @"mvc.1.0.view", @"/Views/Persona/DatosPersona.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Persona/DatosPersona.cshtml", typeof(AspNetCore.Views_Persona_DatosPersona))]
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
#line 1 "C:\Users\Usuario\source\repos\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Usuario\source\repos\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c91851a693f87a69683c2ac34f0c0ae7fe704bc", @"/Views/Persona/DatosPersona.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_DatosPersona : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Persona>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
  
    ViewBag.Mewssage = "Datos de persona";

#line default
#line hidden
            BeginContext(92, 118, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div>\r\n                <h4>Datos de la persona: ");
            EndContext();
            BeginContext(211, 14, false);
#line 10 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
                                    Write(ViewBag.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(225, 55, true);
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(327, 33, false);
#line 16 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
#line 16 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
                                          ;

#line default
#line hidden
            BeginContext(363, 310, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-horizontal"">
                    <div class=""form-group"">
                        <label class=""col-sm-6 control-label"">Nombre</label>
                        <div class=""col-sm-6"">
                            ");
            EndContext();
            BeginContext(674, 107, false);
#line 23 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
                       Write(Html.TextBoxFor(model => model.Nombre , htmlAttributes: new { @class = "form control", @id = "txtNombre" }));

#line default
#line hidden
            EndContext();
            BeginContext(781, 264, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-6 control-label"">Apellido</label>
                        <div class=""col-sm-6"">
                            ");
            EndContext();
            BeginContext(1046, 111, false);
#line 29 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
                       Write(Html.TextBoxFor(model => model.Apellido , htmlAttributes: new { @class = "form control", @id = "txtApellido" }));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 264, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-6 control-label"">Telefono</label>
                        <div class=""col-sm-6"">
                            ");
            EndContext();
            BeginContext(1422, 111, false);
#line 35 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
                       Write(Html.TextBoxFor(model => model.Telefono , htmlAttributes: new { @class = "form control", @id = "txtTelefono" }));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 260, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-6 control-label"">Edad</label>
                        <div class=""col-sm-6"">
                            ");
            EndContext();
            BeginContext(1794, 103, false);
#line 41 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
                       Write(Html.TextBoxFor(model => model.Edad , htmlAttributes: new { @class = "form control", @id = "txtEdad" }));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 454, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group text-right"">
                        <div class=""col-xs-12"">
                            <button class=""btn btn-primary"" type=""submit"">
                                 Actualizar datos
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 54 "C:\Users\Usuario\source\repos\WebApplication1\Views\Persona\DatosPersona.cshtml"
    }

#line default
#line hidden
            BeginContext(2358, 6, true);
            WriteLiteral("    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
