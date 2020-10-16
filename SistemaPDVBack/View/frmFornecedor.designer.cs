namespace SistemaPDVBack
{
    partial class frmFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.gbDadosForncedor = new System.Windows.Forms.GroupBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.rbFornecedorInativo = new System.Windows.Forms.RadioButton();
            this.rbFornecedorAtivo = new System.Windows.Forms.RadioButton();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.mskTxbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txbNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txbInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.lblInscricaoEstadual = new System.Windows.Forms.Label();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbEndereco.SuspendLayout();
            this.gbDadosForncedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEndereco
            // 
            this.gbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEndereco.Controls.Add(this.txbLogradouro);
            this.gbEndereco.Controls.Add(this.lblLogradouro);
            this.gbEndereco.Controls.Add(this.txbNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txbComplemento);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.txbEstado);
            this.gbEndereco.Controls.Add(this.lblEstado);
            this.gbEndereco.Controls.Add(this.txbCidade);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.txbBairro);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.txbRua);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.txbCep);
            this.gbEndereco.Controls.Add(this.lblCep);
            this.gbEndereco.Location = new System.Drawing.Point(21, 149);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(824, 116);
            this.gbEndereco.TabIndex = 6;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Enter += new System.EventHandler(this.gbEndereco_Enter);
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLogradouro.Location = new System.Drawing.Point(613, 84);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(192, 20);
            this.txbLogradouro.TabIndex = 21;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.ForeColor = System.Drawing.Color.Black;
            this.lblLogradouro.Location = new System.Drawing.Point(610, 66);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(83, 15);
            this.lblLogradouro.TabIndex = 20;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txbNumero
            // 
            this.txbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNumero.Location = new System.Drawing.Point(663, 34);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(142, 20);
            this.txbNumero.TabIndex = 19;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Black;
            this.lblNumero.Location = new System.Drawing.Point(660, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(59, 15);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Numero";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbComplemento.Location = new System.Drawing.Point(433, 84);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(164, 20);
            this.txbComplemento.TabIndex = 17;
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.Black;
            this.lblComplemento.Location = new System.Drawing.Point(430, 66);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(98, 15);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento";
            // 
            // txbEstado
            // 
            this.txbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEstado.Location = new System.Drawing.Point(319, 84);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(105, 20);
            this.txbEstado.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(316, 66);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 15);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // txbCidade
            // 
            this.txbCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCidade.Location = new System.Drawing.Point(190, 84);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(113, 20);
            this.txbCidade.TabIndex = 13;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(187, 66);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(53, 15);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // txbBairro
            // 
            this.txbBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBairro.Location = new System.Drawing.Point(9, 84);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(166, 20);
            this.txbBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(6, 66);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 15);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro";
            // 
            // txbRua
            // 
            this.txbRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRua.Location = new System.Drawing.Point(190, 34);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(457, 20);
            this.txbRua.TabIndex = 9;
            // 
            // lblRua
            // 
            this.lblRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.Black;
            this.lblRua.Location = new System.Drawing.Point(187, 16);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(32, 15);
            this.lblRua.TabIndex = 8;
            this.lblRua.Text = "Rua";
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(9, 34);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(161, 20);
            this.txbCep.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.Black;
            this.lblCep.Location = new System.Drawing.Point(6, 16);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 15);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP";
            // 
            // gbDadosForncedor
            // 
            this.gbDadosForncedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosForncedor.Controls.Add(this.txbId);
            this.gbDadosForncedor.Controls.Add(this.lblId);
            this.gbDadosForncedor.Controls.Add(this.rbFornecedorInativo);
            this.gbDadosForncedor.Controls.Add(this.rbFornecedorAtivo);
            this.gbDadosForncedor.Controls.Add(this.lblCnpj);
            this.gbDadosForncedor.Controls.Add(this.mskTxbCnpj);
            this.gbDadosForncedor.Controls.Add(this.txbNomeFantasia);
            this.gbDadosForncedor.Controls.Add(this.lblNomeFantasia);
            this.gbDadosForncedor.Controls.Add(this.txbInscricaoEstadual);
            this.gbDadosForncedor.Controls.Add(this.lblInscricaoEstadual);
            this.gbDadosForncedor.Location = new System.Drawing.Point(21, 12);
            this.gbDadosForncedor.Name = "gbDadosForncedor";
            this.gbDadosForncedor.Size = new System.Drawing.Size(824, 120);
            this.gbDadosForncedor.TabIndex = 7;
            this.gbDadosForncedor.TabStop = false;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(8, 33);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(54, 20);
            this.txbId.TabIndex = 43;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(6, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 42;
            this.lblId.Text = "ID";
            // 
            // rbFornecedorInativo
            // 
            this.rbFornecedorInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFornecedorInativo.AutoSize = true;
            this.rbFornecedorInativo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFornecedorInativo.Location = new System.Drawing.Point(654, 88);
            this.rbFornecedorInativo.Name = "rbFornecedorInativo";
            this.rbFornecedorInativo.Size = new System.Drawing.Size(151, 19);
            this.rbFornecedorInativo.TabIndex = 31;
            this.rbFornecedorInativo.TabStop = true;
            this.rbFornecedorInativo.Text = "Fornecedor  inativo";
            this.rbFornecedorInativo.UseVisualStyleBackColor = true;
            // 
            // rbFornecedorAtivo
            // 
            this.rbFornecedorAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFornecedorAtivo.AutoSize = true;
            this.rbFornecedorAtivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFornecedorAtivo.Location = new System.Drawing.Point(423, 88);
            this.rbFornecedorAtivo.Name = "rbFornecedorAtivo";
            this.rbFornecedorAtivo.Size = new System.Drawing.Size(137, 19);
            this.rbFornecedorAtivo.TabIndex = 30;
            this.rbFornecedorAtivo.TabStop = true;
            this.rbFornecedorAtivo.Text = "Fornecedor Ativo";
            this.rbFornecedorAtivo.UseVisualStyleBackColor = true;
            // 
            // lblCnpj
            // 
            this.lblCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.Black;
            this.lblCnpj.Location = new System.Drawing.Point(218, 69);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(43, 15);
            this.lblCnpj.TabIndex = 13;
            this.lblCnpj.Text = "CNPJ";
            // 
            // mskTxbCnpj
            // 
            this.mskTxbCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTxbCnpj.Location = new System.Drawing.Point(221, 87);
            this.mskTxbCnpj.Mask = "99,999,999/9999-99";
            this.mskTxbCnpj.Name = "mskTxbCnpj";
            this.mskTxbCnpj.Size = new System.Drawing.Size(110, 20);
            this.mskTxbCnpj.TabIndex = 12;
            // 
            // txbNomeFantasia
            // 
            this.txbNomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomeFantasia.Location = new System.Drawing.Point(74, 34);
            this.txbNomeFantasia.Name = "txbNomeFantasia";
            this.txbNomeFantasia.Size = new System.Drawing.Size(731, 20);
            this.txbNomeFantasia.TabIndex = 11;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.ForeColor = System.Drawing.Color.Black;
            this.lblNomeFantasia.Location = new System.Drawing.Point(71, 16);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(104, 15);
            this.lblNomeFantasia.TabIndex = 10;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            this.lblNomeFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbInscricaoEstadual
            // 
            this.txbInscricaoEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbInscricaoEstadual.Location = new System.Drawing.Point(9, 87);
            this.txbInscricaoEstadual.Name = "txbInscricaoEstadual";
            this.txbInscricaoEstadual.Size = new System.Drawing.Size(183, 20);
            this.txbInscricaoEstadual.TabIndex = 9;
            // 
            // lblInscricaoEstadual
            // 
            this.lblInscricaoEstadual.AutoSize = true;
            this.lblInscricaoEstadual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricaoEstadual.ForeColor = System.Drawing.Color.Black;
            this.lblInscricaoEstadual.Location = new System.Drawing.Point(6, 69);
            this.lblInscricaoEstadual.Name = "lblInscricaoEstadual";
            this.lblInscricaoEstadual.Size = new System.Drawing.Size(128, 15);
            this.lblInscricaoEstadual.TabIndex = 8;
            this.lblInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Azure;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnAlterar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.IconSize = 32;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(152, 282);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Rotation = 0D;
            this.btnAlterar.Size = new System.Drawing.Size(127, 35);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Azure;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Green;
            this.btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAdicionar.IconColor = System.Drawing.Color.Green;
            this.btnAdicionar.IconSize = 32;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(19, 282);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Rotation = 0D;
            this.btnAdicionar.Size = new System.Drawing.Size(127, 35);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFornecedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFornecedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFornecedor.ColumnHeadersHeight = 30;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFornecedor.EnableHeadersVisualStyles = false;
            this.dgvFornecedor.GridColor = System.Drawing.Color.Yellow;
            this.dgvFornecedor.Location = new System.Drawing.Point(21, 323);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFornecedor.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(824, 187);
            this.dgvFornecedor.TabIndex = 28;
            this.dgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellDoubleClick);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.gbDadosForncedor);
            this.Controls.Add(this.gbEndereco);
            this.Name = "frmFornecedor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedor";
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbDadosForncedor.ResumeLayout(false);
            this.gbDadosForncedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.GroupBox gbDadosForncedor;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox mskTxbCnpj;
        private System.Windows.Forms.TextBox txbNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txbInscricaoEstadual;
        private System.Windows.Forms.Label lblInscricaoEstadual;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.RadioButton rbFornecedorInativo;
        private System.Windows.Forms.RadioButton rbFornecedorAtivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
    }
}