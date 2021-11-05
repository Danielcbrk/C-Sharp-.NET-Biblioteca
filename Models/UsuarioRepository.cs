using System.Linq;
using System;
using System.Collections.Generic;
using MySqlConnector;


namespace Biblioteca.Models
{
    public class UsuarioRepository
    {



 /*       private const string DadosConexao = "Database=Biblioteca;Data Source=localhost; User Id=root";

        public Usuario ValidarLogin(Usuario user)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            string SqlConsultaLoginSenha = "select * from Usuario WHERE Login=@Login and Senha=@Senha";


            MySqlCommand Comando = new MySqlCommand(SqlConsultaLoginSenha, Conexao);


            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@tipo ", user.tipo);


            MySqlDataReader Reader = Comando.ExecuteReader();


            Usuario userEncontrado = null;


            if (Reader.Read())
            {

                userEncontrado = new Usuario();
                userEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");




            }

            //fechar a conexao
            Conexao.Close();

            //retornar a lista 
            return userEncontrado;

        }
*/

         /*       public Usuario ValidarLogin(Usuario user)
                {
                    using (BibliotecaContext bc = new BibliotecaContext())
                    {
                        Usuario userEncontroado = null;

                        

                        if (userEncontroado != null)

                        {

                            Usuario u = bc.Usuario.Find(userEncontroado.Id);
                            u.Login = userEncontroado.Login;
                            u.Senha = userEncontroado.Senha;
                            //u.tipo = userEncontroado.tipo;


                            
                        }

                        bc.SaveChanges();
                        return userEncontroado;
                        

                        
                    }
                }

        */

        public List<Usuario> Listar()
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.ToList();
            }
        }

        public Usuario Listar(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.Find(id);
            }
        }

        public void incluirUsuario(Usuario novoUser)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Add(novoUser);
                bc.SaveChanges();
            }
        }

        public void editarUsuario(Usuario userEditado)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario u = bc.Usuario.Find(userEditado.Id);

                u.Login = userEditado.Login;
                u.Nome = userEditado.Nome;
                u.Senha = userEditado.Senha;
                u.tipo = userEditado.tipo;

                bc.SaveChanges();
            }
        }


        public void excluirUsuario(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Remove(bc.Usuario.Find(id));
                bc.SaveChanges();
            }
        }


    }
}