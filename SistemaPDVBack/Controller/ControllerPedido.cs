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

        public ControllerPedido(string status, string dataDoPedido)
        {
            // CarregaCpf();

            ConverterValidar(status, dataDoPedido);
        }


        private void ConverterValidar(string status, string dataDoPedido)
        {
            try
            {
                pedido.Status = int.Parse(status);
                pedido.DataDoPedido = dataDoPedido;
                pedido.CpfColaborador = CarregaUsuario.IdUser;



            }
            catch (Exception e)
            {
                throw;
            }

        }

        public ControllerPedido()
        {

        }


        public void AdicionarPedido()
        {
          

            cmd.CommandText = "insert into Pedido(cpfColaborador, codCliente, status,dataDoPedido,formaPagamento) values(@cpfColaborador,@codCliente, @status,@dataDoPedido, @formaPagamento)";

            cmd.Parameters.AddWithValue("@cpfColaborador", pedido.CpfColaborador);
            if (!pedido.CodCliente.Equals(null))
            {
                cmd.Parameters.AddWithValue("@codCliente", pedido.CodCliente);

            }
            else
            {
                cmd.Parameters.AddWithValue("@codCliente", pedido.CodCliente);

            }
            cmd.Parameters.AddWithValue("@status", pedido.Status);
            cmd.Parameters.AddWithValue("@dataDoPedido", pedido.DataDoPedido);
            cmd.Parameters.AddWithValue("@formaPagamento", pedido.FormaDePagamento);
            //  cmd.Parameters.AddWithValue("@tipoCliente", pedido.TipoCliente);




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

        public void CarregaCpf()
        {


            cmd.CommandText = "select idCliente from Cliente where idCliente= (select max(idCliente) from Cliente)";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        pedido.CodCliente = reader.GetInt32(0);
                    }


                }
                else
                {

                }

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




    }
}
