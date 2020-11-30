using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPDVBack.Model;

namespace SistemaPDVBack.View
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblBoasVindas.Text = "Seja bem vindo(a)" + " "+  CarregaUsuario.Nome;
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
