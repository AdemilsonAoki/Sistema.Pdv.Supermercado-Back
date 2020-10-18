using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerColaborador
    {

        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Colaborador(nomeColaborador, cpfColaborador,idDepartamento, statusAtivo, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailCorporativo)" +
                                            "values(@nomeColaborador, @cpfColaborador, @idDepartamento, @statusAtivo, @cargoColaborador, @telefoneColaborador,@emailPessoalColaborador, @emailCorporativo)";
        private readonly string _alterar = "update Colaborador set nomeColaborador = @nomeColaborador, cpfColaborador = @cpfColaborador,idDepartamento =@idDepartamento,  statusAtivo = @statusAtivo, cargoColaborador = @cargoColaborador,telefoneColaborador = @telefoneColaborador,emailPessoalColaborador= @emailPessoalColaborador, emailCorporativo =@emailCorporativo where cpfColaborador = @cpfColaborador";
        private readonly string _listar = "select d.nomeDepartamento, c.nomeColaborador,c.cpfColaborador,c.cargoColaborador, c.telefoneColaborador,c.emailCorporativo, c.emailPessoalColaborador, u.usuario, u.senha, c.statusAtivo from Colaborador c join departamento d on c.idDepartamento = d.idDepartamento join Usuario u on u.cpfColaborador = c.cpfColaborador";
        string mensagem;
        Colaborador colaborador = new Colaborador();
        Conexao conexao = new Conexao();

        public ControllerColaborador()
        {

        }

        public ControllerColaborador(string nomeColaborador, string cpfColaborador, string codDepartamento, string statusAtivo, string cargoColaborador, string telefoneColaborador, string emailPessoalColaborador, string emailColaborador)
        {
            ConverterValidar(nomeColaborador, cpfColaborador, codDepartamento, statusAtivo, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailColaborador);
        }
        public void ConverterValidar(string nomeColaborador, string cpfColaborador, string codDepartamento, string statusAtivo, string cargoColaborador, string telefoneColaborador, string emailPessoalColaborador, string emailColaborador)
        {
            try
            {
                colaborador.NomeColaborador = nomeColaborador;
                colaborador.CpfColaborador = cpfColaborador;
                colaborador.CodDepartamento = int.Parse(codDepartamento);
                colaborador.StatusAtivo = int.Parse(statusAtivo);
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
            cmd.Parameters.AddWithValue("@idDepartamento", colaborador.CodDepartamento);
            cmd.Parameters.AddWithValue("@statusAtivo", colaborador.StatusAtivo);
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
            cmd.Parameters.AddWithValue("@idDepartamento", colaborador.CodDepartamento);
            cmd.Parameters.AddWithValue("@cpfColaborador", colaborador.CpfColaborador);
            cmd.Parameters.AddWithValue("@statusAtivo", colaborador.StatusAtivo);
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
        public DataTable PreencherDepartamento()
        {

            MySqlDataAdapter da = new MySqlDataAdapter();
            cmd.CommandText = "select *from Departamento";


            try
            {
                cmd.Connection = conexao.AbrirBanco();
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                return dt;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();

            }

        }
    }
}
