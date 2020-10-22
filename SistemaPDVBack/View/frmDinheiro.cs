using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.View
{
    public partial class frmDinheiro : Form
    {
        public frmDinheiro()
        {
            InitializeComponent();
        }
        public string Parametro
        {
            get { return txbValorRecebido.Text; }
            set {txbValorRecebido.Text = value; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();

        }



    }
}
