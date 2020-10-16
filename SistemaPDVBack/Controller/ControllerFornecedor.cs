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
        private readonly string _inserir = "insert into Fornecedor(nomeFantasia,Cnpj, inscricaoEstadual, cepFornecedor, Rua, logradouro, uf, numero, complemento,bairro, cidade, statusAtivo ) " +
                                            "values(@nomeFantasia, @cnpj, @inscricaoEstadual, @cepFornecedor,@rua,@logradouro, @uf, @numero, @complemento, @bairro, @cidade, @statusAtivo)";
        private readonly string _alterar = "update Fornecedor set cnpj= @cnpj, inscricaoEstadual = @inscricaoEstadual, nomeFantasia = @nomeFantasia, logradouro = @logradouro , uf = @uf , numero = @numero, complemento = @complemento, bairro = @bairro,cidade = @cidade, cepFornecedor = @cepFornecedor, statusAtivo = @statusAtivo, rua = @rua where idFornecedor = @idFornecedor  ";
        private readonly string _listar = "select *from Fornecedor";


        Fornecedor fornecedor = new Fornecedor();
        Conexao conexao = new Conexao();
        string mensagem;

        public ControllerFornecedor()
        {

        }
        public ControllerFornecedor(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string logradouro, string uf, string numero, string complemento, string bairro, string cidade,
                                    string cep, string statusAtivo, string rua, string cnpj )
        {
            ConverterValidar(idFornecedor, inscricaoEstadual, nomeFantasia, logradouro, uf, numero, complemento, bairro, cidade, cep, statusAtivo, rua, cnpj);
        }

        private void ConverterValidar(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string logradouro, string uf, string numero, string complemento, string bairro, string cidade, string cep, string statusAtivo, string rua, string cnpj)
        {
            try
            {
                if (!idFornecedor.Equals(""))
                {
                    fornecedor.IdFornecedor = int.Parse(idFornecedor);
                }
                fornecedor.Rua = rua;
                fornecedor.Cnpj = cnpj;
                fornecedor.StatusAtivo = int.Parse(statusAtivo);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public void AdicionarFornecedor()
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
            cmd.Parameters.AddWithValue("@statusAtivo", fornecedor.StatusAtivo);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@rua", fornecedor.Rua);
            cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@logradouro", fornecedor.LogradouroPessoa);
            cmd.Parameters.AddWithValue("@uf", fornecedor.UfPessoa);
            cmd.Parameters.AddWithValue("@numero", fornecedor.NumeroPessoa);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.ComplementoPessoa);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.BairroPessoa);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.CidadePessoa);
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
            cmd.Parameters.AddWithValue("@logradouro", fornecedor.LogradouroPessoa);
            cmd.Parameters.AddWithValue("@uf", fornecedor.UfPessoa);
            cmd.Parameters.AddWithValue("@numero", fornecedor.NumeroPessoa);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.ComplementoPessoa);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.BairroPessoa);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.CidadePessoa);
            cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@rua", fornecedor.Rua);
            cmd.Parameters.AddWithValue("@statusAtivo", fornecedor.StatusAtivo);


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


        public void PesquisaFornecedor()
        {



        }
    }
}
