﻿namespace SistemaPDVBack.View
{
    partial class frmDinheiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbValorRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotalValor = new System.Windows.Forms.Label();
            this.lblValorTroco = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblValorAReceber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbValorRecebido
            // 
            this.txbValorRecebido.Location = new System.Drawing.Point(12, 59);
            this.txbValorRecebido.Name = "txbValorRecebido";
            this.txbValorRecebido.Size = new System.Drawing.Size(199, 20);
            this.txbValorRecebido.TabIndex = 0;
            this.txbValorRecebido.Text = "0";
            this.txbValorRecebido.TextChanged += new System.EventHandler(this.txbValorRecebido_TextChanged);
            this.txbValorRecebido.Leave += new System.EventHandler(this.txbValorRecebido_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Recebido";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 265);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK (Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblSubTotalValor
            // 
            this.lblSubTotalValor.AutoSize = true;
            this.lblSubTotalValor.Location = new System.Drawing.Point(94, 107);
            this.lblSubTotalValor.Name = "lblSubTotalValor";
            this.lblSubTotalValor.Size = new System.Drawing.Size(28, 13);
            this.lblSubTotalValor.TabIndex = 5;
            this.lblSubTotalValor.Text = "0,00";
            // 
            // lblValorTroco
            // 
            this.lblValorTroco.AutoSize = true;
            this.lblValorTroco.Location = new System.Drawing.Point(94, 178);
            this.lblValorTroco.Name = "lblValorTroco";
            this.lblValorTroco.Size = new System.Drawing.Size(28, 13);
            this.lblValorTroco.TabIndex = 7;
            this.lblValorTroco.Text = "0,00";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(12, 178);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(35, 13);
            this.lblTroco.TabIndex = 6;
            this.lblTroco.Text = "Troco";
            // 
            // lblValorAReceber
            // 
            this.lblValorAReceber.AutoSize = true;
            this.lblValorAReceber.Location = new System.Drawing.Point(94, 142);
            this.lblValorAReceber.Name = "lblValorAReceber";
            this.lblValorAReceber.Size = new System.Drawing.Size(28, 13);
            this.lblValorAReceber.TabIndex = 9;
            this.lblValorAReceber.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor a receber";
            // 
            // frmDinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 300);
            this.Controls.Add(this.lblValorAReceber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorTroco);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblSubTotalValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbValorRecebido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDinheiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDinheiro";
            this.Load += new System.EventHandler(this.frmDinheiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValorRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotalValor;
        private System.Windows.Forms.Label lblValorTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblValorAReceber;
        private System.Windows.Forms.Label label3;
    }
}