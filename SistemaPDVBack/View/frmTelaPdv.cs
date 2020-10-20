using MySqlX.XDevAPI.Relational;
using SistemaPDVBack.Controller;
using SistemaPDVBack.Model;

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
        ControllerUsuario controllerUsuario;


        private void frmTelaPdv_Load(object sender, EventArgs e)
        {
            CarregarUsuario();
            timerData.Start();
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
                    controllerProdutoPedido = new ControllerProdutoPedido(txbCodBarras.Text, txbQuantidade.Text, txbTotalRecebido.Text);
                    controllerProdutoPedido.AdicionarProdutoPedido();
                    dgvCarrinho.DataSource = controllerProdutoPedido.ListarProdutoPedido();



                    break;
            
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txbCodBarras_TextChanged(object sender, EventArgs e)
        {

            controllerProdutoPedido = new ControllerProdutoPedido(txbCodBarras.Text, txbQuantidade.Text, txbTotalRecebido.Text);
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
            string temp = "1";
            

            controllerPedido = new ControllerPedido(temp, lblData.Text + lblHora.Text);

            if (i == false)
            {
                const string message = "Deseja Colacar CPF na nota?";
                const string caption = "CPF?";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    frmCliente cliente = new frmCliente();
                    cliente.ShowDialog();
                    controllerPedido.CarregaCpf();
                    controllerPedido.AdicionarPedido();



                }


                else
                {
                    controllerPedido.AdicionarPedido();

                }
                i = true;

            }
        
        }

        private void CarregarUsuario()
        {

            lblNomeOperador.Text = CarregaUsuario.Nome;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void txbDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void msktCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }


        private void Remover()
        {
          

        }

        private void dgvCarrinho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCarrinho.CurrentRow.Selected = true;
            string temp = dgvCarrinho.CurrentRow.Cells[4].Value.ToString(); 

          //  temp = dgvCarrinho.CurrentRow.Cells[]

            string mensagem = "Deseja retirar da lista?";
            string fechar = "Retirado com sucesso!!";
            var result = MessageBox.Show(mensagem, fechar,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                controllerProdutoPedido = new ControllerProdutoPedido(temp);
                controllerProdutoPedido.DeeletarProdutoPedido();
                dgvCarrinho.DataSource = controllerProdutoPedido.ListarProdutoPedido();

            }

        }


        
    }
}
