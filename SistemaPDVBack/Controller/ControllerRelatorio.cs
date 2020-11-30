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
    class ControllerRelatorio
    {
        MySqlCommand cmd = new MySqlCommand();
        Conexao conexao = new Conexao();
        Relatorio relatorio = new Relatorio();

        public ControllerRelatorio(string dataInicial, string dataFinal)
        {

            relatorio.DataInicial = dataInicial;
            relatorio.DataFinal = dataFinal; 
        }

        public DataTable BuscarPorData()
        {
            try
            {
                cmd.CommandText = "SELECT idPedido, dataDoPedido, formaPagamento, totalPedido FROM pedido WHERE dataDoPedido like '%' and STR_TO_DATE(dataDoPedido, '%d/%m/%Y') BETWEEN STR_TO_DATE(@dataInicial, '%d/%m/%Y') AND STR_TO_DATE(@dataFinal, '%d/%m/%Y')";
                cmd.Parameters.AddWithValue("@dataInicial", relatorio.DataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", relatorio.DataFinal);
                cmd.Connection = conexao.AbrirBanco();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dtLista = new DataTable();


                da.Fill(dtLista);


                return (dtLista);
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
