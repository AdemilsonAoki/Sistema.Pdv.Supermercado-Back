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

namespace SistemaPDVBack.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();



        }
        bool teste = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(teste == false)
            {
                dgvTeste.Columns.Add("Nome", "Nome");
                dgvTeste.Columns.Add("Codigo", "Codigo");
                dgvTeste.Columns.Add("Valor", "Valor");
            }


            teste = true;
            dgvTeste.Rows.Add(txbNome.Text, txbCodigo.Text, textBox1.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dgvTeste.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int cont = 0;
            int idex = 0;
            List<string> nome = new List<string>();

            foreach (DataGridViewRow coluna in dgvTeste.Rows)
            {

                if (coluna.Visible)
                {
                    if (coluna.DefaultCellStyle.BackColor == Color.Yellow)
                    {
                        for (int i = 0; dgvTeste.ColumnCount > i; i++)
                        {
                            label2.Text += this.dgvTeste.Rows[idex].Cells[i].Value.ToString();


                           
                        }
                       
                     

                        //  coluna.Selected


                        cont++;
                    }
                    else
                    {
                        if (dgvTeste.Rows[idex].Cells[cont].Value != null)
                        {
                            label3.Text += this.dgvTeste.Rows[idex].Cells[0].Value.ToString();

                        }
                    }
                    idex++;

                }

            }

          
            
        }
    }
}
