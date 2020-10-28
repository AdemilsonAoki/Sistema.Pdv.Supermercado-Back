using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;


using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerProduto
    {
        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Produto(codBarras, codFornecedor, nomeProduto, descricaoProduto,precoCusto,precoVenda,margemLucro,dataFabricacao,dataVencimento, quantidadeEstoqueProduto, categoria, statusAtivo)" +
                                            "values(@codBarras, @codFornecedor, @nomeProduto, @descricaoProduto, @precoCusto, @precoVenda, @margemLucro, @dataFabricacao, @dataVencimento, @quantidadeEstoqueProduto, @categoria, @statusAtivo ) ";

        private readonly string _alterar = "update Produto set codFornecedor = @codFornecedor , nomeProduto = @nomeProduto, descricaoProduto = @descricaoProduto, precoCusto =@precoCusto, precoVenda = @precoVenda, margemLucro = @margemLucro, dataFabricacao = @dataFabricacao, dataVencimento = @dataVencimento, quantidadeEstoqueProduto = @quantidadeEstoqueProduto, categoria = @categoria, statusAtivo = @statusAtivo where codBarras = @codBarras ";
        private readonly string _listar = "select p.codBarras, p.nomeProduto, f.nomeFantasia, p.descricaoProduto,p.quantidadeEstoqueProduto, p.precoCusto, p.margemLucro, p.precoVenda, p.dataFabricacao, p.dataVencimento, p.categoria, p.statusAtivo  From Produto p join Fornecedor f on p.codFornecedor = f.idFornecedor where p.statusAtivo = 1";
        string mensagem = "";

        public string Ds_Msg
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        Conexao conexao = new Conexao();
        Produto produto = new Produto();
        Regex r;
        public ControllerProduto()
        {

        }
        public ControllerProduto(string nome)
        {
            if (nome != "")
            {
                produto.NomeProduto = nome;

            }
        }



        public ControllerProduto(string codBarras, string codFornecedor, string nomeProduto, string descricaoProduto, string precoCusto, string precoVenda, string margemLucro, string dataFabricacao, string dataVencimento, string quantidadeEstoqueProduto, string categoria, string statusAtivo)
        {

            ConverterValidar(codBarras, codFornecedor, nomeProduto, descricaoProduto, precoCusto, precoVenda, margemLucro, dataFabricacao, dataVencimento, quantidadeEstoqueProduto, categoria, statusAtivo);


        }
        private void ConverterValidar(string codBarras, string codFornecedor, string nomeProduto, string descricaoProduto, string precoCusto, string precoVenda, string margemLucro, string dataFabricacao, string dataVencimento, string quantidadeEstoqueProduto, string categoria, string statusAtivo)
        {
            string validaNumero = "^[0-9]*$";
            string validar = "Preencha os produtos";
            if (mensagem == "")
            {
                try
                {

                    produto.CodBarras = int.Parse(codBarras);

                    if (nomeProduto != "" && descricaoProduto != "" && dataFabricacao != "" && dataVencimento != "" && categoria != "")
                    {
                        produto.DescricaoProduto = descricaoProduto;
                        produto.NomeProduto = nomeProduto;
                        produto.DataFabricacao = dataFabricacao;
                        produto.DataVencimento = dataVencimento;
                        produto.Categoria = categoria;

                    }
                    else
                    {
                        mensagem = validar;

                    }


                    produto.CodFornecedor = int.Parse(codFornecedor);
                    produto.PrecoCusto = decimal.Parse(precoCusto);
                    produto.PrecoVenda = decimal.Parse(precoVenda);
                    produto.MargemLucro = decimal.Parse(margemLucro);
                    produto.QuantidadeEstoqueProduto = int.Parse(quantidadeEstoqueProduto);
                    produto.StatusAtivo = int.Parse(statusAtivo);



                }


                catch (Exception e)
                {
                    mensagem = e.Message;
                }
            }
        }

        public void AdicionarProduto()
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            cmd.Parameters.AddWithValue("@codFornecedor", produto.CodFornecedor);
            cmd.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@descricaoProduto", produto.DescricaoProduto);
            cmd.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            cmd.Parameters.AddWithValue("@margemLucro", produto.MargemLucro);
            cmd.Parameters.AddWithValue("@dataFabricacao", produto.DataFabricacao);
            cmd.Parameters.AddWithValue("@dataVencimento", produto.DataVencimento);
            cmd.Parameters.AddWithValue("@quantidadeEstoqueProduto", produto.QuantidadeEstoqueProduto);
            cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
            cmd.Parameters.AddWithValue("@statusAtivo", produto.StatusAtivo);

            try
            {
                cmd.Connection = conexao.AbrirBanco();
                cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                mensagem = e.Message;

            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }

        }


        public void AlterarProduto()
        {
            cmd.CommandText = _alterar;

            cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            cmd.Parameters.AddWithValue("@codFornecedor", produto.CodFornecedor);
            cmd.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@descricaoProduto", produto.DescricaoProduto);
            cmd.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            cmd.Parameters.AddWithValue("@margemLucro", produto.MargemLucro);
            cmd.Parameters.AddWithValue("@dataFabricacao", produto.DataFabricacao);
            cmd.Parameters.AddWithValue("@dataVencimento", produto.DataVencimento);
            cmd.Parameters.AddWithValue("@quantidadeEstoqueProduto", produto.QuantidadeEstoqueProduto);
            cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
            cmd.Parameters.AddWithValue("@statusAtivo", produto.StatusAtivo);




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
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }


        public DataTable PesquisaProduto()
        {
            cmd.CommandText = "select p.codBarras, p.nomeProduto, f.nomeFantasia, p.descricaoProduto,p.quantidadeEstoqueProduto, p.precoCusto, p.margemLucro, p.precoVenda, p.dataFabricacao, p.dataVencimento, p.categoria, p.statusAtivo  From Produto p join Fornecedor f on p.codFornecedor = f.idFornecedor where nomeProduto LIKE'%' @nomeProduto '%' order by nomeProduto";
            cmd.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
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
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }
        public DataTable PreencherFornecedor()
        {
            cmd.CommandText = "Select *from Fornecedor";
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
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }

        public DataTable ListarTodosProdutos()
        {
            cmd.CommandText = "select p.codBarras, p.nomeProduto, f.nomeFantasia, p.descricaoProduto,p.quantidadeEstoqueProduto, p.precoCusto, p.margemLucro, p.precoVenda, p.dataFabricacao, p.dataVencimento, p.categoria, p.statusAtivo  From Produto p join Fornecedor f on p.codFornecedor = f.idFornecedor ";
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
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }
        }


    }
}
