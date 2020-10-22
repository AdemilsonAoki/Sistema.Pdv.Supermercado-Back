using SistemaPDVBack.Controller;
using SistemaPDVBack.View;
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
    public partial class frmFinalizarVenda : Form
    {
        public frmFinalizarVenda()
        {
            InitializeComponent();
        }
        ControllerPedido controllerPedido = new ControllerPedido();

     

        private void frmFinalizarVenda_Load(object sender, EventArgs e)
        {
            ControllerPedido controllerPedido = new ControllerPedido();
            lblTotal.Text = controllerPedido.CarregaTotal();
            lblTotalApagar.Text = lblTotal.Text;
            lblSaldo.Text = lblTotal.Text;
            btnConfirmar.Enabled = false;


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(lblSaldo.Text != "0.00")
            {
                MessageBox.Show("Falta receber");
            }
            else
            {
                this.Close();

            }

           
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            btnCartaoCred.Enabled = false;
            btnCartaoDeb.Enabled = false;
            btnConfirmar.Enabled = true;

            using (var dinheiro = new frmDinheiro())
            {
              

                dinheiro.ShowDialog();
                lblValorPago.Text = dinheiro.Parametro;
                CalulaValores(lblValorPago.Text, lblSaldo.Text);




            }


            controllerPedido.AtualizaFormaPagamento(btnDinheiro.Text);
        }

        private void btnCartaoCred_Click(object sender, EventArgs e)
        {
            btnCartaoDeb.Enabled = false;
            btnDinheiro.Enabled = false;
            btnConfirmar.Enabled = true;
            lblSaldo.Text = "0.00";
            controllerPedido.AtualizaFormaPagamento(btnCartaoCred.Text);
        }

        private void btnCartaoDeb_Click(object sender, EventArgs e)
        {
            controllerPedido.AtualizaFormaPagamento(btnCartaoDeb.Text);

        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            controllerPedido.AtualizaFormaPagamento(btnCartaoDeb.Text);

        }

        private void CalulaValores( string valorpago , string total)
        
        {
            
       
            decimal valorRecebido= decimal.Parse(valorpago);
            decimal totalDaVenda= decimal.Parse(total);

            if(totalDaVenda > valorRecebido)
            {
                totalDaVenda = totalDaVenda - valorRecebido;
                lblSaldo.Text = totalDaVenda.ToString();


            }
            else
            {
                totalDaVenda = valorRecebido - totalDaVenda;

                lblTroco.Text = totalDaVenda.ToString();

                lblSaldo.Text = "0.00";
            }



        }

     
    }
}
