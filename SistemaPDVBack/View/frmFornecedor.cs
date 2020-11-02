using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPDVBack.Controller;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;

namespace SistemaPDVBack
{
    public partial class frmFornecedor : Form
    {
        ControllerFornecedor controllerFornecedor;
        string _ativo;

        public frmFornecedor()
        {
            InitializeComponent();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AtribuirValorRb();

            controllerFornecedor = new ControllerFornecedor(txbId.Text, txbInscricaoEstadual.Text, txbNomeFantasia.Text, txbLogradouro.Text, txbEstado.Text, txbNumero.Text,
                                                            txbComplemento.Text, txbBairro.Text, txbCidade.Text, txbCep.Text, _ativo, txbRua.Text, mskTxbCnpj.Text);
            if (controllerFornecedor.Ds_Msg != "")
            {
                // Exibir erro!

                const string caption = "Ocorreu um erro?";
                var result = MessageBox.Show(controllerFornecedor.Ds_Msg, caption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);

            }
            else
            {
                // Tudo certinho!
                controllerFornecedor.AdicionarFornecedor();
                LimpaCampos();

                Listar();

            }


        }

        private void Listar()
        {
            //verificar
            controllerFornecedor = new ControllerFornecedor();
            dgvFornecedor.DataSource = controllerFornecedor.ListarFornecedor();
            DefinirCabecalhos(new List<string>() { "Id", "Nome", "CNPJ", "Insc. Estadual", "CEP", "Rua", "Logradouro", "Estado", "Numero", "Complemnto", "Bairro", "Cidade", "Ativo" });
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string _temp;

            txbId.Text = this.dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            txbNomeFantasia.Text = this.dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            mskTxbCnpj.Text = this.dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            txbInscricaoEstadual.Text = this.dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txbCep.Text = this.dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            txbRua.Text = this.dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
            txbLogradouro.Text = this.dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
            txbEstado.Text = this.dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
            txbNumero.Text = this.dgvFornecedor.CurrentRow.Cells[8].Value.ToString();
            txbComplemento.Text = this.dgvFornecedor.CurrentRow.Cells[9].Value.ToString();
            txbBairro.Text = this.dgvFornecedor.CurrentRow.Cells[10].Value.ToString();
            txbCidade.Text = this.dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
            _temp = this.dgvFornecedor.CurrentRow.Cells[12].Value.ToString();

            bool _temp2 = bool.Parse(_temp);
            if (_temp2 == true)
                rbFornecedorAtivo.Checked = true;
            else
                rbFornecedorInativo.Checked = true;
        }

        private void gbEndereco_Enter(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtribuirValorRb();
            controllerFornecedor = new ControllerFornecedor(txbId.Text, txbInscricaoEstadual.Text, txbNomeFantasia.Text, txbLogradouro.Text, txbEstado.Text, txbNumero.Text,
                                                            txbComplemento.Text, txbBairro.Text, txbCidade.Text, txbCep.Text, _ativo, txbRua.Text, mskTxbCnpj.Text);

            if (controllerFornecedor.Ds_Msg != "")
            {
                // Exibir erro!

                const string caption = "Ocorreu um erro?";
                var result = MessageBox.Show(controllerFornecedor.Ds_Msg, caption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);

            }
            else
            {
                // Tudo certinho!
                controllerFornecedor.AlterarFornecedor();
                LimpaCampos();

                Listar();

            }
        }


        private void AtribuirValorRb()
        {

            if (rbFornecedorAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }


        }
        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvFornecedor.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = ListaCabecalhos[_index];
                    _index++;
                }
            }
        }




        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txbCep.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível");
                return; // Sai da rotina
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {



                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    txbCep.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txbRua.Text = valor[1];
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txbComplemento.Text = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txbBairro.Text = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txbCidade.Text = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txbEstado.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }

            }

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            rbFornecedorAtivo.Checked = true;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            controllerFornecedor = new ControllerFornecedor(txbNomeFantasia.Text);
            if (txbNomeFantasia.Text != "")
            {
                dgvFornecedor.DataSource = controllerFornecedor.PesquisaFornecedor();

            }
            else
            {
                if (ckbInativo.Checked)
                {
                    dgvFornecedor.DataSource = controllerFornecedor.ListarTodosFornecedores();
                }
                else
                {
                    Listar();
                }
            }
        }
        private void LimpaCampos()
        {
            rbFornecedorAtivo.Checked = true;
            txbBairro.Clear();
            txbCep.Clear();
            txbCidade.Clear();
            txbComplemento.Clear();
            txbEstado.Clear();
            txbId.Clear();
            txbInscricaoEstadual.Clear();
            txbLogradouro.Clear();
            txbNomeFantasia.Clear();
            txbNumero.Clear();
            txbRua.Clear();
            mskTxbCnpj.Text = "";

        }
    }
}
