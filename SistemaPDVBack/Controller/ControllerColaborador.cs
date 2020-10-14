using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Data;


namespace SistemaPDVBack.Controller
{
    class ControllerColaborador
    {

        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Colaborador(nomeColaborador, cpfColaborador,idDepartamento, ativoColaborador, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailCorporativo )" +
                                            "values(@cpfColaborador, @ativoColaborador, @cargoColaborador, @telefoneColaborador,@emailPessoalColaborador, @emailCorporativo)";
        private readonly string _alterar = "update Colaborador set cpfColaborador = @cpfColaborador,idDepartamento =@idDepartamento,  ativoColaborador = @ativoColaborador, cargoColaborador = @cargoColaborador,telefoneColaborador = @telefoneColaborador,emailPessoalColaborador= @emailPessoalColaborador, emailCorporativo =@emailCorporativo where idColaborador = @idColaborador";
        private readonly string _listar = "select *from Colaborador";
        string mensagem;
        Colaborador colaborador = new Colaborador();
        Conexao conexao = new Conexao();

        public ControllerColaborador()
        {

        }

        public ControllerColaborador(string nomeColaborador, string cpfColaborador, string codDepartamento, string ativoColaborador, string cargoColaborador, string telefoneColaborador, string emailPessoalColaborador, string emailColaborador)
        {
            ConverterValidar(nomeColaborador, cpfColaborador, codDepartamento, ativoColaborador, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailColaborador);
        }
        public void ConverterValidar(string nomeColaborador, string cpfColaborador, string codDepartamento, string ativoColaborador, string cargoColaborador, string telefoneColaborador, string emailPessoalColaborador, string emailColaborador)
        {
            try
            {
                colaborador.CpfColaborador = cpfColaborador;
                colaborador.CodDepartamento.IdDEpartamento = int.Parse(codDepartamento);
                colaborador.AtivoColaborador = int.Parse(ativoColaborador);
                colaborador.CargoColaborador = cargoColaborador;
                colaborador.TelefoneColaborador = telefoneColaborador;
                colaborador.EmailCorporativo = emailColaborador;
                colaborador.EmailPessoalColaborador = emailPessoalColaborador;

            }
            catch (Exception e)
            {
                mensagem = e.Message;
            }

        }

        public void AdicionarColaborador()
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@cpfColaborador", colaborador.CpfColaborador);
            cmd.Parameters.AddWithValue("@nomeColaborador", colaborador.NomeColaborador);
            cmd.Parameters.AddWithValue("@idDepartamento", colaborador.CodDepartamento.IdDEpartamento);
            cmd.Parameters.AddWithValue("@ativoColaborador", colaborador.AtivoColaborador);
            cmd.Parameters.AddWithValue("@cargoColaborador", colaborador.CargoColaborador);
            cmd.Parameters.AddWithValue("@telefoneColaborador", colaborador.TelefoneColaborador);
            cmd.Parameters.AddWithValue("@emailPessoalColaborador", colaborador.EmailPessoalColaborador);
            cmd.Parameters.AddWithValue("@emailCorporativo", colaborador.EmailCorporativo);

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
            cmd.Parameters.AddWithValue("@idColaborador", colaborador.IdColaborador);
            cmd.Parameters.AddWithValue("@idDepartamento", colaborador.CodDepartamento);
            cmd.Parameters.AddWithValue("@cpfColaborador", colaborador.CpfColaborador);
            cmd.Parameters.AddWithValue("@ativoColaborador", colaborador.AtivoColaborador);
            cmd.Parameters.AddWithValue("@cargoColaborador", colaborador.CargoColaborador);
            cmd.Parameters.AddWithValue("@telefoneColaborador", colaborador.TelefoneColaborador);
            cmd.Parameters.AddWithValue("@emailPessoalColaborador", colaborador.EmailPessoalColaborador);
            cmd.Parameters.AddWithValue("@emailCorporativo", colaborador.EmailCorporativo);


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
