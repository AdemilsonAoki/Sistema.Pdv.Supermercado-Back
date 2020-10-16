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
        string _ativo;

        public frmFornecedor()
        {
            InitializeComponent();
            Listar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AtribuirValorRb();

            controllerFornecedor = new ControllerFornecedor(txbId.Text, txbInscricaoEstadual.Text, txbNomeFantasia.Text, txbLogradouro.Text, txbEstado.Text, txbNumero.Text,
                                                            txbComplemento.Text, txbBairro.Text, txbCidade.Text, txbCep.Text, _ativo, txbRua.Text, mskTxbCnpj.Text);
            controllerFornecedor.AdicionarFornecedor();
            Listar();

        }

        private void Listar()
        {
            //verificar
            controllerFornecedor = new ControllerFornecedor();
            dgvFornecedor.DataSource = controllerFornecedor.ListarFornecedor();
            DefinirCabecalhos(new List<string>() { "Id", "Nome", "CNPJ", "Inscrição Estadual", "CEP", "Rua", "Logradouro", "Estado", "Numero","Complemnto","Bairro","Cidade", "Ativo" });
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string _temp;

            txbId.Text = this.dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            txbNomeFantasia.Text = this.dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            mskTxbCnpj.Text = this.dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            txbInscricaoEstadual.Text = this.dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txbCep.Text = this.dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            txbRua.Text = this.dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
            txbLogradouro.Text = this.dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
            txbEstado.Text = this.dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
            txbNumero.Text = this.dgvFornecedor.CurrentRow.Cells[8].Value.ToString();
            txbComplemento.Text = this.dgvFornecedor.CurrentRow.Cells[9].Value.ToString();
            txbBairro.Text = this.dgvFornecedor.CurrentRow.Cells[10].Value.ToString();
            txbCidade.Text = this.dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
            _temp = this.dgvFornecedor.CurrentRow.Cells[12].Value.ToString();

            bool _temp2 = bool.Parse(_temp);
            if (_temp2 == true)
                rbFornecedorAtivo.Checked = true;
            else
                rbFornecedorInativo.Checked = true;






        }

        private void gbEndereco_Enter(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtribuirValorRb();
            controllerFornecedor = new ControllerFornecedor(txbId.Text, txbInscricaoEstadual.Text, txbNomeFantasia.Text, txbLogradouro.Text, txbEstado.Text, txbNumero.Text,
                                                            txbComplemento.Text, txbBairro.Text, txbCidade.Text, txbCep.Text, _ativo, txbRua.Text, mskTxbCnpj.Text);

            controllerFornecedor.AlterarFornecedor();
            Listar();
        }


        private void AtribuirValorRb()
        {

            
            if (rbFornecedorAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }


        }
        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index =0;

            foreach (DataGridViewColumn coluna in dgvFornecedor.Columns)
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
