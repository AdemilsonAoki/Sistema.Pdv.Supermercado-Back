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
        Colaborador colaborador = new Colaborador();
        Conexao conexao = new Conexao();
        private readonly MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader reader;

        public ControllerUsuario(string usuario, string senha, string idColaborador)
        {
            ValidarConverter(usuario, senha, idColaborador);

        }
        public ControllerUsuario(string usuario, string senha)
        {
            login.Login = usuario;
            login.Senha = senha;

        }

        private void ValidarConverter(string usuario, string senha, string idColaborador)
        {
            try
            {
                login.Login = usuario;
                login.Senha = senha;
                colaborador.IdColaborador = int.Parse(idColaborador);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }

        public void AdicionarUsuario()
        {
            cmd.CommandText = "insert into Usuario(codColaborador, usuario, senha) values (@codColaborador, @usuario, @senha) ";

            cmd.Parameters.AddWithValue("@codColaborador", login.CodColaborador );
            cmd.Parameters.AddWithValue("@usuario", login.Login);
            cmd.Parameters.AddWithValue("@senha", login.Senha);


            try
            {
                cmd.Connection = conexao.AbrirBanco();
                cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;

            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }
        }

    }
}
