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
    public partial class frmFornecedor : Form
    {
        ControllerFornecedor controllerFornecedor;

        public frmFornecedor()
        {
            InitializeComponent();
            Listar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controllerFornecedor = new ControllerFornecedor(txbId.Text, txbInscricaoEstadual.Text, txbNomeFantasia.Text, txbLogradouro.Text, txbEstado.Text, txbNumero.Text,
                                                            txbComplemento.Text, txbBairro.Text, txbCidade.Text, txbCep.Text);
            controllerFornecedor.AdicionarFornecedor();
            Listar();
          
        }

        private void Listar()
        {
            //verificar
            controllerFornecedor = new ControllerFornecedor();
            dgvFornecedor.DataSource = controllerFornecedor.ListarFornecedor();
        }
    }
}
