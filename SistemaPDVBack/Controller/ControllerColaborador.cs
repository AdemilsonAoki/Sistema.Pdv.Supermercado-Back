using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Data;


namespace SistemaPDVBack.Controller
{
    class ControllerColaborador
    {

        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "";
        private readonly string _alterar = "";
        private readonly string _listar = "";


        Conexao conexao = new Conexao();


        public void AdicionarColaborador(Colaborador colaborador)
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("", colaborador);
         


            try
            {
                cmd.Connection = conexao.AbrirBanco();
                cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw;

            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }


        }


        public void AlterarProduto(Produto produto)
        {
            cmd.CommandText = _alterar;
            cmd.Parameters.AddWithValue("", produto.CodFornecedor);
      





            try
            {
                cmd.Connection = conexao.AbrirBanco();
                cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw;

            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }



        }


        public DataTable ListarProduto()
        {
            cmd.CommandText = _listar;
            try
            {
                cmd.Connection = conexao.AbrirBanco();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }


        public void PesquisaProduto(Produto produto)
        {



        }
    }
}
