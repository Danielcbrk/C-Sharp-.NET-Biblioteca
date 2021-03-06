#pragma checksum "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61c295f7b3cb8b3876d5e275502ab36d9ea1f4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
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
#line 1 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61c295f7b3cb8b3876d5e275502ab36d9ea1f4d", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 17 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
                 if (u.tipo == Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 25 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 29 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 748, 2);
            WriteAttributeValue("", 726, "editarUsuario?id=", 726, 17, true);
#nullable restore
#line 31 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 743, u.Id, 743, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 789, "\"", 819, 2);
            WriteAttributeValue("", 796, "ExcluirUsuario?id=", 796, 18, true);
#nullable restore
#line 32 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 814, u.Id, 814, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "E:\ARQUIVOS P\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC07-NOVA\Biblioteca2\Views\Usuarios\ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
