using SistemaPDVBack.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack
{
    public partial class frmTelaPdv : Form
    {
        public frmTelaPdv()
        {
            InitializeComponent();
        }

        ControllerProdutoPedido controllerProdutoPedido;
        ControllerPedido controllerPedido;
        ControllerUsuario ControllerUsuario;


        private void frmTelaPdv_Load(object sender, EventArgs e)
        {

        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    frmFinalizarVenda frmFinalizar = new frmFinalizarVenda();
                    frmFinalizar.Show();
                    this.Hide();

                    break;
                case Keys.A:
                    Adicionar();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txbCodBarras_TextChanged(object sender, EventArgs e)
        {
            
            controllerProdutoPedido = new ControllerProdutoPedido(txbCodBarras.Text);
            txbPrecoUnit.Text = controllerProdutoPedido.VerificaProdutoPreco();
            txbDescricao.Text = controllerProdutoPedido.VerificaProdutoNome();

        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            decimal quantidade = 0;
            decimal preco = 0;
            decimal total = 0;


            if (txbPrecoUnit.Text != "" && txbQuantidade.Text != "")
            {
                quantidade = decimal.Parse(txbQuantidade.Text);
                preco = decimal.Parse(txbPrecoUnit.Text);

            }

            total = quantidade * preco;


            txbTotalRecebido.Text = total.ToString();
        }

        bool i = false;
    
        private void Adicionar()
        {
            if (i == false)
            {
                frmProduto frm = new frmProduto();
                frm.Show();
                i = true;
            }
         

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void txbDescricao_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
