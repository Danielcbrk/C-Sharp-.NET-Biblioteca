
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Biblioteca.Controllers
{
    public class AutenticacaoController : Controller
    {
        public static void CheckLogin(Controller controller)
        {
            if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }



        public static bool verificaLoginSenha(string login, string senha, Controller controller)
    {
        using (BibliotecaContext bc = new BibliotecaContext())
        {
            verificaSeUsuarioAdminExiste(bc);

            senha = Criptografo.TextoCriptografado(senha);

            IQueryable<Usuario> UsuarioEncontrado = bc.Usuario.Where(u => u.Login==login && u.Senha == u.Senha);
            List<Usuario> ListaUsuarioEncontrado = UsuarioEncontrado.ToList();

            if (ListaUsuarioEncontrado.Count == 0)
            {
                return false;
                
            }
            else
            {
                controller.HttpContext.Session.SetString("login", ListaUsuarioEncontrado[0].Login);
                controller.HttpContext.Session.SetString("Nome", ListaUsuarioEncontrado[0].Nome);
                controller.HttpContext.Session.SetInt32("tipo", ListaUsuarioEncontrado[0].tipo);
                return true;
            }


        }
    }




    public static void verificaSeUsuarioAdminExiste(BibliotecaContext bc)
    {
        IQueryable<Usuario> userEncontrado = bc.Usuario.Where(u => u.Login == "admin");

        //Se não existir será criado usuario admin padrão
        if (userEncontrado.ToList().Count == 0)
        {
            Usuario admin = new Usuario();
            admin.Login = "admin";
            admin.Senha = Criptografo.TextoCriptografado("123");
            admin.tipo = Usuario.ADMIN;
            admin.Nome = "Administrador";

            bc.Usuario.Add(admin);
            bc.SaveChanges();


        }
    }

    
    
    public static void verificaSeUsuarioEAdmin(Controller controller)
    {
        if (!(controller.HttpContext.Session.GetInt32("tipo")==Usuario.ADMIN))
        {
            controller.Request.HttpContext.Response.Redirect("/Usuarios/NeedAdmin");
        }
    }

    

    }
}