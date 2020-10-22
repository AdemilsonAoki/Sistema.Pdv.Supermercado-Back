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

        public ControllerPedido(string status, string dataDoPedido, string total)
        {
            // CarregaCpf();

            ConverterValidar(status, dataDoPedido, total);
        }
        public ControllerPedido(string total)
        {
            CarregaPedido();

            pedido.TotalPedido = decimal.Parse(total);
           
        }

        private void ConverterValidar(string status, string dataDoPedido, string total)
        {
            try
            {
                pedido.Status = int.Parse(status);
                pedido.DataDoPedido = dataDoPedido;
                pedido.CpfColaborador = CarregaUsuario.IdUser;
                pedido.TotalPedido = decimal.Parse(total);


            }
            catch (Exception e)
            {
                throw;
            }

        }

        public ControllerPedido()
        {
            CarregaPedido();

        }


        public void AdicionarPedido()
        {


            cmd.CommandText = "insert into Pedido(cpfColaborador, codCliente, status,dataDoPedido,formaPagamento, totalPedido) values(@cpfColaborador,@codCliente, @status,@dataDoPedido, @formaPagamento, @totalPedido)";

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
            cmd.Parameters.AddWithValue("@totalPedido", pedido.TotalPedido);

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


        public void AtualizaValorPedido()
        {

            cmd.CommandText = "update Pedido set totalPedido = @totalPedido where idPedido = @idPedido";
            cmd.Parameters.AddWithValue("@totalPedido", pedido.TotalPedido);
            cmd.Parameters.AddWithValue("@idPedido", pedido.IdPedido);




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

        public void CarregaPedido()
        {


            cmd.CommandText = "select idPedido from Pedido where idPedido= (select max(idPedido) from Pedido)";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        pedido.IdPedido = reader.GetInt32(0);
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

        public string CarregaTotal()
        {
            cmd.CommandText = "select *from Pedido where idPedido = @idPedido";
            cmd.Parameters.AddWithValue("@idPedido", pedido.IdPedido);

            string total = "";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        total = reader.GetString(6);
                        

                    }
                }
                return total;


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

        public void AtualizaFormaPagamento(string formaPagamento)
        {

            pedido.FormaDePagamento = formaPagamento;
            cmd.CommandText = "update Pedido set formaPagamento = @formaPagamento where idPedido = @idPedido";
            cmd.Parameters.AddWithValue("@formaPagamento", pedido.FormaDePagamento);
            cmd.Parameters.AddWithValue("@idPedido", pedido.IdPedido);




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
