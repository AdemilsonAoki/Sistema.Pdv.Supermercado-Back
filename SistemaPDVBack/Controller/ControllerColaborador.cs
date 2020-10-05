using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Data;


namespace SistemaPDVBack.Controller
{
    class ControllerColaborador
    {

        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Colaborador(codDepartamento, cpfColaborador, ativoColaborador, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailCorporativo )" +
                                            "values(@codDepartamento, @cpfColaborador, @ativoColaborador, @cargoColaborador, @telefoneColaborador,@emailPessoalColaborador, @emailCorporativo)";
        private readonly string _alterar = "";
        private readonly string _listar = "";

        Colaborador colaborador = new Colaborador();
        Conexao conexao = new Conexao();

        public ControllerColaborador( )
        {

        }


        public void AdicionarColaborador()
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@codDepartamento", colaborador.CodDepartamento);
            cmd.Parameters.AddWithValue("@cpfColaborador", colaborador.CpfColaborador);
            cmd.Parameters.AddWithValue("@ativoColaborador", colaborador.AtivoColaborador);
            cmd.Parameters.AddWithValue("@cargoColaborador", colaborador.CargoColaborador);






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


        public void AlterarColaborador()
        {
            cmd.CommandText = _alterar;
            cmd.Parameters.AddWithValue("", colaborador.CargoColaborador);
      





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


        public DataTable ListarColaborador()
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


        public void PesquisaColaborador()
        {



        }
    }
}
