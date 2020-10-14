using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerFornecedor
    {
        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Fornecedor(inscricaoEstadual, nomeFantasia,logradouroPessoa, ufPessoa,numeroPessoa,complementoPessoa,bairroPessoa,cidadePessoa,cepFornecedor ) " +
                                            "values(@inscricaoEstadual, @nomeFantasia, @logradouroPessoa, @ufPessoa,@numeroPessoa,@complementoPessoa, @bairroPessoa, @bairroPessoa, @cepFornecedor)";
        private readonly string _alterar = "update Fornecedor set inscricaoEstadual = @inscricaoEstadual, nomeFantasia = @nomeFantasia, logradouroPessoa = @logradouroPessoa , ufPessoa = @ufPessoa , numeroPessoa = @numeroPessoa, complementoPessoa = @complementoPessoa, bairroPessoa = @bairroPessoa,cidadePessoa = @cidadePessoa, cepFornecedor = @cepFornecedor where idFornecedor = @idFornecedor  ";
        private readonly string _listar = "select *from Fornecedor";


        Fornecedor fornecedor = new Fornecedor();
        Conexao conexao = new Conexao();
        string mensagem;

        public ControllerFornecedor()
        {

        }
        public ControllerFornecedor(string idFornecedor,string inscricaoEstadual, string nomeFantasia, string logradouro, string uf, string numero, string complemento, string bairro, string cidade, string cep )
        {
            ConverterValidar(idFornecedor, inscricaoEstadual, nomeFantasia, logradouro, uf, numero, complemento, bairro, cidade, cep);
        }

        private void ConverterValidar(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string logradouro, string uf, string numero, string complemento, string bairro, string cidade, string cep)
        {
            try
            {
                if (!idFornecedor.Equals(""))
                {
                    fornecedor.IdFornecedor = int.Parse(idFornecedor);
                }
                fornecedor.InscricaoEstadual = int.Parse(inscricaoEstadual);
                fornecedor.NomeFantasia = nomeFantasia;
                fornecedor.LogradouroPessoa = logradouro;
                fornecedor.UfPessoa = uf;
                fornecedor.NumeroPessoa = numero;
                fornecedor.ComplementoPessoa = complemento;
                fornecedor.BairroPessoa = bairro;
                fornecedor.CidadePessoa = cidade;
                fornecedor.CepFornecedor = int.Parse(cep);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
          

        }

        public void AdicionarFornecedor()
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
            cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@logradouroPessoa", fornecedor.LogradouroPessoa);
            cmd.Parameters.AddWithValue("@ufPessoa", fornecedor.UfPessoa);
            cmd.Parameters.AddWithValue("@numeroPessoa", fornecedor.NumeroPessoa);
            cmd.Parameters.AddWithValue("@complementoPessoa", fornecedor.ComplementoPessoa);
            cmd.Parameters.AddWithValue("@bairroPessoa", fornecedor.BairroPessoa);
            cmd.Parameters.AddWithValue("@cidadePessoa", fornecedor.CidadePessoa);
            cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);




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


        public void AlterarFornecedor()
        {
            cmd.CommandText = _alterar;
            cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.IdFornecedor);
            cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
            cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@logradouroPessoa", fornecedor.LogradouroPessoa);
            cmd.Parameters.AddWithValue("@ufPessoa", fornecedor.UfPessoa);
            cmd.Parameters.AddWithValue("@numeroPessoa", fornecedor.NumeroPessoa);
            cmd.Parameters.AddWithValue("@complementoPessoa", fornecedor.ComplementoPessoa);
            cmd.Parameters.AddWithValue("@bairroPessoa", fornecedor.BairroPessoa);
            cmd.Parameters.AddWithValue("@cidadePessoa", fornecedor.CidadePessoa);
            cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);

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
