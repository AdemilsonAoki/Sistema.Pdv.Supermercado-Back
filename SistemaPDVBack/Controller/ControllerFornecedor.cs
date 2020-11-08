﻿using MySql.Data.MySqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerFornecedor
    {
        private readonly MySqlCommand cmd = new MySqlCommand();
        private readonly string _inserir = "insert into Fornecedor(nomeFantasia,Cnpj, inscricaoEstadual, cepFornecedor, Rua, logradouro, uf, numero, complemento,bairro, cidade, statusAtivo ) " +
                                            "values(@nomeFantasia, @cnpj, @inscricaoEstadual, @cepFornecedor,@rua,@logradouro, @uf, @numero, @complemento, @bairro, @cidade, @statusAtivo)";
        private readonly string _alterar = "update Fornecedor set cnpj= @cnpj, inscricaoEstadual = @inscricaoEstadual, nomeFantasia = @nomeFantasia, logradouro = @logradouro , uf = @uf , numero = @numero, complemento = @complemento, bairro = @bairro,cidade = @cidade, cepFornecedor = @cepFornecedor, statusAtivo = @statusAtivo, rua = @rua where idFornecedor = @idFornecedor  ";
        private readonly string _listar = "select *from Fornecedor where statusAtivo = 1 ";


        Fornecedor fornecedor = new Fornecedor();
        Conexao conexao = new Conexao();
        string mensagem = "";
        public string Ds_Msg
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public ControllerFornecedor()
        {

        }
        public ControllerFornecedor(string nome)
        {
            fornecedor.NomeFantasia = nome;
        }
        public ControllerFornecedor(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string logradouro, string uf, string numero, string complemento, string bairro, string cidade,
                                    string cep, string statusAtivo, string rua, string cnpj )
        {
            ConverterValidar(idFornecedor, inscricaoEstadual, nomeFantasia, logradouro, uf, numero, complemento, bairro, cidade, cep, statusAtivo, rua, cnpj);
        }

        private void ConverterValidar(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string logradouro, string uf, string numero, string complemento, string bairro, string cidade, string cep, string statusAtivo, string rua, string cnpj)
        {
            if (mensagem == "")
            {


                try
                {

                    if(idFornecedor != "")
                    {
                        fornecedor.IdFornecedor = int.Parse(idFornecedor);

                    }
                    if (rua != "" && nomeFantasia != "" && bairro != "" && cidade != "" && uf != "")
                    {
                        fornecedor.Rua = rua;
                        fornecedor.NomeFantasia = nomeFantasia;
                        fornecedor.NumeroPessoa = numero;
                        fornecedor.BairroPessoa = bairro;
                        fornecedor.CidadePessoa = cidade;
                        fornecedor.UfPessoa = uf;
                    }
                    else
                    {
                        mensagem = "Preencha os campos";
                    }
                    fornecedor.Cnpj = cnpj;
                    fornecedor.StatusAtivo = int.Parse(statusAtivo);
                    fornecedor.InscricaoEstadual = int.Parse(inscricaoEstadual);
                    fornecedor.LogradouroPessoa = logradouro;
                    fornecedor.ComplementoPessoa = complemento;
                    fornecedor.CepFornecedor = int.Parse(cep);
                }
                catch (Exception e)
                {
                    mensagem = e.Message;
                }
            }


        }

        public void AdicionarFornecedor()
        {

            cmd.CommandText = _inserir;

            cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
            cmd.Parameters.AddWithValue("@statusAtivo", fornecedor.StatusAtivo);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@rua", fornecedor.Rua);
            cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@logradouro", fornecedor.LogradouroPessoa);
            cmd.Parameters.AddWithValue("@uf", fornecedor.UfPessoa);
            cmd.Parameters.AddWithValue("@numero", fornecedor.NumeroPessoa);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.ComplementoPessoa);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.BairroPessoa);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.CidadePessoa);
            cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);




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


        public void AlterarFornecedor()
        {
            cmd.CommandText = _alterar;
            cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.IdFornecedor);
            cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
            cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
            cmd.Parameters.AddWithValue("@logradouro", fornecedor.LogradouroPessoa);
            cmd.Parameters.AddWithValue("@uf", fornecedor.UfPessoa);
            cmd.Parameters.AddWithValue("@numero", fornecedor.NumeroPessoa);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.ComplementoPessoa);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.BairroPessoa);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.CidadePessoa);
            cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@rua", fornecedor.Rua);
            cmd.Parameters.AddWithValue("@statusAtivo", fornecedor.StatusAtivo);


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


        public DataTable ListarFornecedor()
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


        public DataTable PesquisaFornecedor()
        {
            try
            {
                cmd.CommandText = "select *from Fornecedor where nomeFantasia LIKE'%' @nomeFantasia '%' order by nomeFantasia";
                cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
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


        }
        public DataTable ListarTodosFornecedores()
        {
            cmd.CommandText = "select *from Fornecedor";
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
    }
}
