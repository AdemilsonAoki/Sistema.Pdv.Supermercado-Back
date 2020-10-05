using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerUsuario
    {
        Usuario login = new Usuario();
        Conexao conexao = new Conexao();
        private readonly MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader reader;

        public ControllerUsuario(string usuario, string senha)
        {
            login.Login = usuario;
            login.Senha = senha;


        }

            

        public bool Login()
        {
            cmd.CommandText = "select *from usuario where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", login.Login);
            cmd.Parameters.AddWithValue("@senha", login.Senha);
            try
            {
                cmd.Connection = conexao.AbrirBanco();
                              
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                    



            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conexao.FecharBanco();
            }





        }

    }
}
