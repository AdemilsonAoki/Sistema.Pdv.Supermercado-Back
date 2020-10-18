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

            controllerColaborador = new ControllerColaborador (txbNome.Text, msktCpf.Text, cmbDepartamento.SelectedValue.ToString(), _ativo, txtCargo.Text, mskTxtCelular.Text, txbEmail.Text, txbEmailCorporativo.Text);
            controllerColaborador.AdicionarColaborador();

            controllerUsuario = new ControllerUsuario(txbUsuario.Text, txbSenha.Text, msktCpf.Text, _ativo);
            controllerUsuario.AdicionarUsuario();

            controllerColaborador.ListarColaborador();


        }

        private void Listar()
        {
            //verificar
            controllerColaborador = new ControllerColaborador();
            dgvColaborador.DataSource = controllerColaborador.ListarColaborador();
            cmbDepartamento.DataSource = controllerColaborador.PreencherDepartamento();
            cmbDepartamento.DisplayMember = "nomeDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }

        private void frmColaborador_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvColaborador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _temp;
            cmbDepartamento.Text = this.dgvColaborador.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = this.dgvColaborador.CurrentRow.Cells[1].Value.ToString();
            msktCpf.Text = this.dgvColaborador.CurrentRow.Cells[2].Value.ToString();
            txtCargo.Text = this.dgvColaborador.CurrentRow.Cells[3].Value.ToString();
            mskTxtCelular.Text = this.dgvColaborador.CurrentRow.Cells[4].Value.ToString();
            txbEmailCorporativo.Text = this.dgvColaborador.CurrentRow.Cells[5].Value.ToString();
            txbEmail.Text = this.dgvColaborador.CurrentRow.Cells[6].Value.ToString();
            txbUsuario.Text = this.dgvColaborador.CurrentRow.Cells[7].Value.ToString();
            txbSenha.Text = this.dgvColaborador.CurrentRow.Cells[8].Value.ToString();
            _temp = this.dgvColaborador.CurrentRow.Cells[9].Value.ToString();

            bool _tempV = bool.Parse(_temp);
            if (_tempV == true)
                rbColaboradorAtivo.Checked = true;
            else
                rbColaboradorInativo.Checked = true;
        }
        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvColaborador.Columns)
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
