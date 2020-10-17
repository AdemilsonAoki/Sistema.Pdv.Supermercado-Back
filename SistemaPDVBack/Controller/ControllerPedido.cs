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
    class ControllerPedido
    {

        MySqlCommand cmd = new MySqlCommand();
        Pedido pedido = new Pedido();
        Conexao conexao = new Conexao();
        private MySqlDataReader reader;




        public ControllerPedido()
        {

        }


        public void AdicionarPedido()
        {

            cmd.CommandText = "insert into Pedido(codColaborador, cpf_cnpj, status,dataDoPedido,formaPagamento) values(@codColaborador,@codCliente, @status,@dataDoPedido, @formaPagamento)";

            cmd.Parameters.AddWithValue("@codColaborador", pedido.CodColaborador );
            cmd.Parameters.AddWithValue("@cpf_cnpj", pedido);
            cmd.Parameters.AddWithValue("@status", pedido.Status);
            cmd.Parameters.AddWithValue("dataDoPedido", pedido.DataDoPedido);
            cmd.Parameters.AddWithValue("formaPagamento", pedido.FormaDePagamento);



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




    }
}
