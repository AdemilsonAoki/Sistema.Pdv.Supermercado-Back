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
    

        public void CarregarRelatorio()
        {
            try
            {
                // Abre banco
                cmd.CommandText = "Select * from Vendas";
                conexao.AbrirBanco();

                MySqlDataAdapter mDtAd = new MySqlDataAdapter(cmd);

             //   mDtAd.Fill(mDts, "Retorno");
            }

            catch (Exception e)
            {
                throw;
            }
            finally
            {

                // fecha banco
                conexao.FecharBanco();
            }


        }
    }
}
