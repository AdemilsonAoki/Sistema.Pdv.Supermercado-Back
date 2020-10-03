using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Data;


namespace SistemaPDVBack.Controller
{
    class ControllerProduto
    {
        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Produto(codBarras, codFornecedor, nomeProduto, descricaoProduto,precoCusto,precoVenda,margemLucro,dataFabricacao,dataVencimento, quantidadeEstoqueProduto, categoria, ativoProduto)" +
                                            "value(@codBarras, @codFornecedor, @nomeProduto, @descricaoProduto, @precoCusto, @precoVenda, @margemLucro, @dataFabricacao, @dataVencimento, @quantidadeEstoqueProduto, @categoria, @ativoProduto ) ";

        private readonly string _alterar = "update Produto set codFornecedor = @codFornecedor , nomeProduto = @nomeProduto, descricaoProduto = @descricaoProduto, precoCusto =@precoCusto, precoVenda = @precoVenda, margemLucro = @margemLucro, dataFabricao = @dataFabricacao, dataVencimento = @dataVencimento, quantidadeEstoqueProduto = @quantidadeEstoqueProduto, categoria = @categoria, ativoProduto = @ativoProduto where codBarras = @codBarras ";
        private readonly string _listar = "select *from Produto";


        Conexao conexao = new Conexao();


        public void AdicionarProduto(Produto produto)
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            cmd.Parameters.AddWithValue("@codFornecedor", produto.CodFornecedor);
            cmd.Parameters.AddWithValue("@nomeProduto", produto.DescricaoProduto);
            cmd.Parameters.AddWithValue("@descricaoProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@precoCusto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@precoVenda", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@margemLucro", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@dataFabricacao", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@dataVencimento", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@quantidadeEstoqueProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@categoria", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@ativoProduto", produto.NomeProduto);

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
            cmd.Parameters.AddWithValue("@codFornecedor", produto.CodFornecedor);
            cmd.Parameters.AddWithValue("@nomeProduto", produto.DescricaoProduto);
            cmd.Parameters.AddWithValue("@descricaoProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@precoCusto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@precoVenda", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@margemLucro", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@dataFabricacao", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@dataVencimento", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@quantidadeEstoqueProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@categoria", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@ativoProduto", produto.NomeProduto);






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
