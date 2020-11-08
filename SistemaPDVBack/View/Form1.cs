
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPDVBack.Controller;
using SistemaPDVBack.Model;


namespace SistemaPDVBack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        ControllerCupom cupom = new ControllerCupom();

        bool verificador = false;
        public void CumpomImpresso(string codItem, string codBarras, string descricao, string quantidade, string valorUnit, string Total, string Status, string cpf, string totalVendido, string codVenda, string data, string hora, string caixa)
        {
            listBox1.Clear();
            if(verificador == false)
            {
                cupom.ImprimirCupom("", "", "Total", "", "", totalVendido, "", "", "", "","", "");
                verificador = true;
            }
            cupom.ImprimirCupom(codItem, codBarras, descricao, quantidade,valorUnit, Total, Status , cpf,codVenda, data , hora, caixa);
            foreach (string obj in cupom.Layout)
            {
                listBox1.Items.Add(obj);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

