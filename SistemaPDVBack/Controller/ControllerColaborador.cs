using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaPDVBack.Controller
{
    class ControllerColaborador
    {

        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Colaborador(cpfColaborador,nomeColaborador,  statusAtivo, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailCorporativo, idDepartamento)" +
                                            "values(@cpfColaborador, @nomeColaborador, @statusAtivo, @cargoColaborador, @telefoneColaborador,@emailPessoalColaborador, @emailCorporativo,@idDepartamento)";
        private readonly string _alterar = "update Colaborador set cpfColaborador = @cpfColaborador, nomeColaborador = @nomeColaborador,   statusAtivo = @statusAtivo, cargoColaborador = @cargoColaborador,telefoneColaborador = @telefoneColaborador,emailPessoalColaborador= @emailPessoalColaborador, emailCorporativo =@emailCorporativo, idDepartamento =@idDepartamento where idColaborador = @idColaborador";
        private readonly string _listar = "select c.idColaborador, c.nomeColaborador,c.cpfColaborador, d.nomeDepartamento,c.cargoColaborador, c.telefoneColaborador,c.emailCorporativo, c.emailPessoalColaborador, u.usuario, u.senha, c.statusAtivo from Colaborador c join departamento d on c.idDepartamento = d.idDepartamento join Usuario u on u.cpfColaborador = c.cpfColaborador where c.statusAtivo = 1 ";
        string mensagem = "";
        Colaborador colaborador = new Colaborador();
        Conexao conexao = new Conexao();
        public string Ds_Msg
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public ControllerColaborador()
        {

        }

        public ControllerColaborador(string nome)
        {
            if (nome != "")
            {
                colaborador.NomeColaborador = nome;
            }
          
        }

        public ControllerColaborador(string id, string nomeColaborador, string cpfColaborador, string codDepartamento, string statusAtivo, string cargoColaborador, string telefoneColaborador, string emailPessoalColaborador, string emailColaborador)
        {
            ConverterValidar(id ,nomeColaborador, cpfColaborador, codDepartamento, statusAtivo, cargoColaborador, telefoneColaborador, emailPessoalColaborador, emailColaborador);
        }
        public void ConverterValidar(string id, string nomeColaborador, string cpfColaborador, string codDepartamento, string statusAtivo, string cargoColaborador, string telefoneColaborador, string emailPessoalColaborador, string emailColaborador)
        {
            if (mensagem == "")
            {
                string validaEmail = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                string validaTelefone = "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[1-9])[0-9]{3}\\-?[0-9]{4}$";
                string validaNumero = "^[0-9]*$";
                try
                {
                    if (id != "")
                    {
                        colaborador.IdColaborador = int.Parse(id);

                    }
                    if (Regex.IsMatch(emailColaborador, validaEmail))
                    {
                        colaborador.EmailCorporativo = emailColaborador;


                    }
                    else
                    {
                        mensagem = "formato incorreto";
                    }
                    if (Regex.IsMatch(emailPessoalColaborador, validaEmail))
                    {

                        colaborador.EmailPessoalColaborador = emailPessoalColaborador;


                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
                    if (nomeColaborador != "" && cargoColaborador != "")
                    {
                        colaborador.NomeColaborador = nomeColaborador;
                        colaborador.CargoColaborador = cargoColaborador;


                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
                    if (Regex.IsMatch(telefoneColaborador, validaTelefone))
                    {
                        colaborador.TelefoneColaborador = telefoneColaborador;

                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
                    if (cpfColaborador.Length >= 14)
                    {
                        colaborador.CpfColaborador = cpfColaborador;

                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
                    if (Regex.IsMatch(codDepartamento, validaNumero))
                    {
                        colaborador.CodDepartamento = int.Parse(codDepartamento);

                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
                    if (Regex.IsMatch(statusAtivo, validaNumero))
                    {
                        colaborador.StatusAtivo = int.Parse(statusAtivo);

                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
                    if (Regex.IsMatch(codDepartamento, validaNumero))
                    {
                        colaborador.CodDepartamento = int.Parse(codDepartamento);

                    }
                    else
                    {
                        mensagem = "formato incorreto";

                    }
             


                }
                catch (Exception e)
                {
                    mensagem = e.Message;
                }
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
            cmd.Parameters.AddWithValue("@idDepartamento", colaborador.CodDepartamento);

            cmd.Parameters.AddWithValue("@idColaborador", colaborador.IdColaborador);

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

        public DataTable ListarTodosColaboradores()
        {
            cmd.CommandText = "select c.idColaborador, c.nomeColaborador,c.cpfColaborador, d.nomeDepartamento,c.cargoColaborador, c.telefoneColaborador,c.emailCorporativo, c.emailPessoalColaborador, u.usuario, u.senha, c.statusAtivo from Colaborador c join departamento d on c.idDepartamento = d.idDepartamento join Usuario u on u.cpfColaborador = c.cpfColaborador";
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


        public DataTable PesquisaColaborador()
        {
            try
            {
                cmd.CommandText = "select c.nomeColaborador,c.cpfColaborador, d.nomeDepartamento,c.cargoColaborador, c.telefoneColaborador,c.emailCorporativo, c.emailPessoalColaborador, u.usuario, u.senha, c.statusAtivo from Colaborador c join departamento d on c.idDepartamento = d.idDepartamento join Usuario u on u.cpfColaborador = c.cpfColaborador where nomeColaborador LIKE'%' @nomeColaborador '%' order by nomeColaborador";
                cmd.Parameters.AddWithValue("@nomeColaborador", colaborador.NomeColaborador);
                cmd.Connection = conexao.AbrirBanco();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;
            }
            catch(Exception e)
            {
                throw;
            }


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
