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
    public partial class frmColaborador : Form
    {
        public frmColaborador()
        {
            InitializeComponent();
        }
        ControllerColaborador controllerColaborador;
        ControllerUsuario controllerUsuario;


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string _ativo = "";
            if (rbColaboradorAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }

            controllerColaborador = new ControllerColaborador(txbNome.Text, msktCpf.Text, cmbDepartamento.SelectedValue.ToString(), _ativo, cmbCargo.SelectedValue.ToString(), mskTxtCelular.Text, txbEmail.Text, txbEmailCorporativo.Text);
            controllerColaborador.AdicionarColaborador();

            controllerUsuario = new ControllerUsuario(txbUsuario.Text, txbSenha.Text, txbId.Text);
            controllerUsuario.AdicionarUsuario();


        }

        private void Listar()
        {
            //verificar
            controllerColaborador = new ControllerColaborador();
            dgvColaborador.DataSource = controllerColaborador.ListarColaborador();
        }

        private void frmColaborador_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
