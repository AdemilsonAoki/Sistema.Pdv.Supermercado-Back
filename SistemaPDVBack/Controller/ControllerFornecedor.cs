using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Controller
{
    class ControllerFornecedor
    {
        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "";
        private readonly string _alterar = "";
        private readonly string _listar = "";


        Conexao conexao = new Conexao();


        public void AdicionarFornecedor(Fornecedor fornecedor)
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("", fornecedor.InscricaoEstadual);
            cmd.Parameters.AddWithValue("", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("", fornecedor.IdEndereco);


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


        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            cmd.CommandText = _alterar;
            cmd.Parameters.AddWithValue("", fornecedor.IdFornecedor);
            cmd.Parameters.AddWithValue("", fornecedor.NomeFantasia);
           




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


        public DataTable ListarFornecedor()
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


        public void PesquisaFornecedor(Fornecedor fornecedor)
        {



        }
    }
}
