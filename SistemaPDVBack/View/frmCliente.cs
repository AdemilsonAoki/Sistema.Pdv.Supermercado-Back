﻿using SistemaPDVBack.Controller;
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
        public string Parametro
        {
            get { return msktCnpjCpf.Text; }
            set { msktCnpjCpf.Text = value; }
        }
        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {

            msktCnpjCpf.Text = "";
            msktCnpjCpf.Mask = "000,000,000-00";
            msktCnpjCpf.ReadOnly = false;
            btnAdicionar.Enabled = true;


        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            msktCnpjCpf.Text = "";
            msktCnpjCpf.Mask = "00,000,000/0000-00";
            btnAdicionar.Enabled = true;


        }
        string cpf = "";
        string cnpj = "";
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //ControllerCliente cliente = new ControllerCliente(msktCnpjCpf.Text);
            //cliente.AdicionarCliente();
          
            if (rbCpf.Checked)
            {
                cpf = msktCnpjCpf.Text.Replace(".", "").Replace("-", "");

            }
            else
            {
               cnpj = msktCnpjCpf.Text.Replace(".", "").Replace("-", "").Replace("/", ""); ;

            }


            if (msktCnpjCpf.Text != "   .   .   -" && msktCnpjCpf.Text != "  .   .   /    -")
            {
                if (cpf.Length == 11 || cnpj.Length == 14)  
                {
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Digite um cpf/cnpj valido!!");
                }

            }
            else
            {
                MessageBox.Show("Por favor digite um valor!!");
            }

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = false;
            msktCnpjCpf.ReadOnly = true;

            msktCnpjCpf.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            msktCnpjCpf.Text = "";
            msktCnpjCpf.Mask = null;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {

                case Keys.Enter:
                    btnAdicionar.Focus();
                    break;
                case Keys.Escape:
                    msktCnpjCpf.Text = "";
                    msktCnpjCpf.Mask = null;
                    this.Close();
                    break;
                case Keys.D1:

                    rbCpf.Focus();
                    btnAdicionar.Focus();
                    msktCnpjCpf.Focus();


                    msktCnpjCpf.ReadOnly = false;
                    msktCnpjCpf.Text = "";
                    if (rbCpf.Checked == false)
                    {
                        msktCnpjCpf.ReadOnly = true;
                    }

                    break;
                case Keys.D2:

                    rbCNPJ.Focus();
                    btnAdicionar.Focus();

                    msktCnpjCpf.Focus();


                    msktCnpjCpf.ReadOnly = false;
                    msktCnpjCpf.Text = "";

                    msktCnpjCpf.ReadOnly = true;



                    break;



            }

            return base.ProcessCmdKey(ref msg, keyData);


        }

        private void msktCnpjCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          

        }
    }

}

