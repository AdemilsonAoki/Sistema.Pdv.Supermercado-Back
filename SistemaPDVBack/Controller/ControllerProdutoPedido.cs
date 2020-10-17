using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Controller
{
    class ControllerProdutoPedido
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        Conexao conexao = new Conexao();
        ProdutoPedido produtoPedido = new ProdutoPedido();
      
        public ControllerProdutoPedido()
        {

        }
        public ControllerProdutoPedido(string codBarras)
        {
            ConverterValidar(codBarras);
        }





        private void ConverterValidar(string codBarras)
        {
            //Verificar
            if (!codBarras.Equals(""))
            {
                produtoPedido.CodPedido = int.Parse(codBarras);

            }



        }

        public string VerificaProdutoPreco()
        {


            cmd.CommandText = "select *from Produto where codBarras = @codBarras";
            cmd.Parameters.AddWithValue("@codBarras", produtoPedido.CodPedido);

            string venda = ""; 
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    venda = reader.GetString(6);
              
                }
                return venda;


            }
            catch (Exception e)
            {
                throw;
                //MessageBox.Show(e.Message);

            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();

            }

        }

        public string VerificaProdutoNome()
        {


            cmd.CommandText = "select *from Produto where codBarras = @codBarras";
            cmd.Parameters.AddWithValue("@codBarras", produtoPedido.CodPedido);

            string nome = "";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    nome = reader.GetString(3);

                }
                return nome;


            }
            catch (Exception e)
            {
                throw;
                //MessageBox.Show(e.Message);

            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();
            }

        }

    }
}
