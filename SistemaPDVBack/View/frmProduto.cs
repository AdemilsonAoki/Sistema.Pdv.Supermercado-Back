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


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string _perecivel = "";
            string _ativo = "";



            if (rbPerecivel.Checked == true)
            {
                _perecivel = rbPerecivel.Text;
            }
            else
            {
                _perecivel = rbPerecivel.Text;
            }
            if (rbProdutoAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }



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
    }
}
