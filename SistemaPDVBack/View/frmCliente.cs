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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {

            msktCnpjCpf.Text = "";
            msktCnpjCpf.Mask = "000,000,000-00";
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            msktCnpjCpf.Text = "";
            msktCnpjCpf.Mask = "00,000,000/0000-00";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ControllerCliente cliente = new ControllerCliente(msktCnpjCpf.Text);
            cliente.AdicionarCliente();

            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
