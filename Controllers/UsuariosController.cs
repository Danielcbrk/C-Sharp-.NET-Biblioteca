using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {

        public IActionResult ListaDeUsuarios()
        {
            AutenticacaoController.CheckLogin(this);
            AutenticacaoController.verificaSeUsuarioEAdmin(this);

            return View(new UsuarioRepository().Listar());
        }

        public IActionResult editarUsuario(int id)
        {
            Usuario u = new UsuarioRepository().Listar(id);

            return View(u);
        }
        
        [HttpPost]

        public IActionResult editarUsuario(Usuario userEditado)
        {
            UsuarioRepository us = new UsuarioRepository();
            us.editarUsuario(userEditado);

            return RedirectToAction("ListaDeUsuarios");

        }

        public IActionResult RegistrarUsuarios()
        {
            AutenticacaoController.CheckLogin(this);
            AutenticacaoController.verificaSeUsuarioEAdmin(this);
            return View();
        }

        [HttpPost]

        public IActionResult RegistrarUsuarios(Usuario novoUser)
        {
            AutenticacaoController.CheckLogin(this);
            AutenticacaoController.verificaSeUsuarioEAdmin(this);

            novoUser.Senha = Criptografo.TextoCriptografado(novoUser.Senha);

            UsuarioRepository us = new UsuarioRepository();
            us.incluirUsuario(novoUser);

            return RedirectToAction("cadastroRealizado"); 

        }


        public IActionResult Excluirusuario(int id)
        {
            return View(new UsuarioRepository().Listar(id));
        }


        [HttpPost]
        public IActionResult ExcluirUsuario(string decisao, int id)
        {
            if(decisao=="EXCLUIR")
            {
                ViewData["Mensagem"] = "Exclusão de usuario" + new UsuarioRepository().Listar(id).Nome + " Realizado com sucesso ";
                new UsuarioRepository().excluirUsuario(id);
                return View("ListadeUsuarios",new UsuarioRepository().Listar());
            }
            else
            {
                ViewData["Mensagem"] = "Exclusão cancelada";
                return View("ListaDeUsuarios", new UsuarioRepository().Listar());
            }
        }

        
        public IActionResult cadastroRealizado()
        {
            AutenticacaoController.CheckLogin(this);
            AutenticacaoController.verificaSeUsuarioEAdmin(this);

            return View();
        }

        public IActionResult NeedAdmin()
        {
            AutenticacaoController.CheckLogin(this);
            return View();
        }

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }



        
    }
}