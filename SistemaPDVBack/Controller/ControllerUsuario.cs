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

        public ControllerUsuario(string usuario, string senha)
        {
            login.Login = usuario;
            login.Senha = senha;


        }

        private readonly MySqlCommand cmd = new MySqlCommand();
        public bool Login()
        {
            cmd.CommandText = "select *from Usuario where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", login.Login);
            cmd.Parameters.AddWithValue("@senha", login.Senha);
            try
            {
                conexao.AbrirBanco();
                              
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                    return false;



            }
            catch(Exception e)
            {
                MessageBox.Show("Ïnvalido");
                return false;
            }
            finally
            {
                conexao.FecharBanco();
            }





        }

    }
}
