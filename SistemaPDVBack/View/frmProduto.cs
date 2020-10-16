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

namespace SistemaPDVBack
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        ControllerProduto controllerProduto;
        string _perecivel = "";
        string _ativo = "";


        private void frmProduto_Load(object sender, EventArgs e)
        {
            Listar();
            rbPerecivel.Checked = true;
            rbProdutoAtivo.Checked = true;

        }
        private void Listar()
        {
            controllerProduto = new ControllerProduto();
            dgvProduto.DataSource = controllerProduto.ListarProduto();
            cmbFornecedor.DataSource = controllerProduto.PreencherFornecedor();
            cmbFornecedor.ValueMember = "idFornecedor";
            cmbFornecedor.DisplayMember = "nomeFantasia";
            DefinirCabecalhos(new List<string>() { "Código de barras", "Nome", "Fornecedor", "Descrição", "Quantidade", "Preço de Custo","Margem", "Preço de Venda", "Data Fabricação", "Data Vencimento", "Categoria", "Ativo" });

        }

        private void InseriValorRb()
        {
            if (rbPerecivel.Checked == true)
            {
                _perecivel = rbPerecivel.Text;
            }
            else
            {
                _perecivel = rbNaoPerecivel.Text;
            }
            if (rbProdutoAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            InseriValorRb();



            controllerProduto = new ControllerProduto(txbCodigoBarras.Text, cmbFornecedor.SelectedValue.ToString(), txbNome.Text, rtbDescricao.Text, txbPrecoCusto.Text, txbPrecoDeVenda.Text,
                                                        txbMargemDeLucro.Text, dtpDataFabricacao.Text, dtpDataVencimento.Text, txbQuantidadeEstoque.Text, _perecivel, _ativo);

            controllerProduto.AdicionarProduto();
            Listar();
        }

        private void txbMargemDeLucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPrecoDeVenda_TextChanged(object sender, EventArgs e)
        {
            float porcentagem = 0;
            float total = 0;

            float precoCusto = 0;
            if (txbMargemDeLucro.Text != "")
            {
                porcentagem = float.Parse(txbMargemDeLucro.Text);
            }
            if (txbPrecoCusto.Text != "")
            {

                precoCusto = float.Parse(txbPrecoCusto.Text);
            }

            //decimal precoVenda = 0;
            //decimal porcentagem = 0;


            //decimal precoCusto = 0;
            //decimal total = 0;

            //    if (txbPrecoDeVenda.Text != "" && txbPrecoCusto.Text != "" && txbPrecoDeVenda.Text != "0" && txbPrecoCusto.Text != "0")
            //    {
            //        precoVenda = decimal.Parse(txbPrecoDeVenda.Text);
            //        precoCusto = decimal.Parse(txbPrecoCusto.Text);

            //    }
            //    total = (((precoVenda - precoCusto) / precoVenda)) * 200;
            //    txbMargemDeLucro.Text = total.ToString("F2");


        }

        private void txbPrecoCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMargemDeLucro_MouseLeave(object sender, EventArgs e)
        {


        }

        private void txbMargemDeLucro_TextChanged_1(object sender, EventArgs e)
        {
            float porcentagem = 0;
            float total = 0;

            float precoCusto = 0;

            if (txbPrecoCusto.Text != "" && txbMargemDeLucro.Text != "")
            {
                porcentagem = float.Parse(txbMargemDeLucro.Text);
                precoCusto = float.Parse(txbPrecoCusto.Text);
            }


            porcentagem += 100;
            total = (porcentagem / 100) * precoCusto;

            txbPrecoDeVenda.Text = total.ToString("F2");



        }

        private void txbPrecoDeVenda_MouseLeave(object sender, EventArgs e)
        {






        }

        private void PrecoVendaMargem()
        {


            decimal precoVenda = 0;
            decimal porcentagem = 0;


            decimal precoCusto = 0;
            decimal total = 0;



            if (txbPrecoDeVenda.Focus() != true)
            {
                if (txbPrecoDeVenda.Text != "" && txbPrecoCusto.Text != "" && txbPrecoDeVenda.Text != "0" && txbPrecoCusto.Text != "0")
                {
                    precoVenda = decimal.Parse(txbPrecoDeVenda.Text);
                    precoCusto = decimal.Parse(txbPrecoCusto.Text);
                    total = (((precoVenda - precoCusto) / precoVenda)) * 200;
                    txbMargemDeLucro.Text = total.ToString("F2");
                }
            }

            else if (txbMargemDeLucro.Focus() != true)
            {
                if (txbMargemDeLucro.Text != "" && txbPrecoCusto.Text != "")
                {
                    porcentagem = decimal.Parse(txbMargemDeLucro.Text);
                    precoCusto = decimal.Parse(txbPrecoCusto.Text);
                    porcentagem += 100;
                    total = (porcentagem / 100) * precoCusto;

                    txbPrecoDeVenda.Text = total.ToString();
                }

            }

        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _tempAtivo;
            string _tempPerecivel;

            txbCodigoBarras.Text = this.dgvProduto.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = this.dgvProduto.CurrentRow.Cells[1].Value.ToString();
            cmbFornecedor.Text = this.dgvProduto.CurrentRow.Cells[2].Value.ToString();
            rtbDescricao.Text = this.dgvProduto.CurrentRow.Cells[3].Value.ToString();
            txbQuantidadeEstoque.Text = this.dgvProduto.CurrentRow.Cells[4].Value.ToString();
            txbPrecoCusto.Text = this.dgvProduto.CurrentRow.Cells[5].Value.ToString();
            txbMargemDeLucro.Text = this.dgvProduto.CurrentRow.Cells[6].Value.ToString();
            txbPrecoDeVenda.Text = this.dgvProduto.CurrentRow.Cells[7].Value.ToString();
            dtpDataFabricacao.Text = this.dgvProduto.CurrentRow.Cells[8].Value.ToString();
            dtpDataVencimento.Text = this.dgvProduto.CurrentRow.Cells[9].Value.ToString();
            _tempPerecivel = this.dgvProduto.CurrentRow.Cells[10].Value.ToString();
            _tempAtivo = this.dgvProduto.CurrentRow.Cells[11].Value.ToString();

            bool _tempAtivoV = bool.Parse(_tempAtivo);

            if (_tempAtivoV == true)
                rbProdutoAtivo.Checked = true;
            else
                rbProdutoInativo.Checked = true;

            if (_tempPerecivel == "Perecível")
                rbPerecivel.Checked = true;
            else
                rbNaoPerecivel.Checked = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            InseriValorRb();



            controllerProduto = new ControllerProduto(txbCodigoBarras.Text, cmbFornecedor.SelectedValue.ToString(), txbNome.Text, rtbDescricao.Text, txbPrecoCusto.Text, txbPrecoDeVenda.Text,
                                                        txbMargemDeLucro.Text, dtpDataFabricacao.Text, dtpDataVencimento.Text, txbQuantidadeEstoque.Text, _perecivel, _ativo);

            controllerProduto.AlterarProduto();
            Listar();
        }

        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvProduto.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = ListaCabecalhos[_index];
                    _index++;
                }
            }
        }
    }
}
