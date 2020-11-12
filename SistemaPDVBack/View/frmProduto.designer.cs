namespace SistemaPDVBack
{
    partial class frmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txbCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.gpCategoria = new System.Windows.Forms.GroupBox();
            this.rbNaoPerecivel = new System.Windows.Forms.RadioButton();
            this.rbPerecivel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbMargemDeLucro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrecoDeVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.txbPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.rbProdutoInativo = new System.Windows.Forms.RadioButton();
            this.rbProdutoAtivo = new System.Windows.Forms.RadioButton();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbInativo = new System.Windows.Forms.CheckBox();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.msktDataFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.msktDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpCategoria.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.Color.Black;
            this.lblCodBarras.Location = new System.Drawing.Point(89, 18);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(118, 15);
            this.lblCodBarras.TabIndex = 0;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // txbCodigoBarras
            // 
            this.txbCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCodigoBarras.Location = new System.Drawing.Point(92, 36);
            this.txbCodigoBarras.Name = "txbCodigoBarras";
            this.txbCodigoBarras.Size = new System.Drawing.Size(264, 20);
            this.txbCodigoBarras.TabIndex = 1;
            this.txbCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodigoBarras_KeyPress);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.Black;
            this.lblFornecedor.Location = new System.Drawing.Point(371, 18);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(83, 15);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbFornecedor.Location = new System.Drawing.Point(374, 36);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(195, 21);
            this.cmbFornecedor.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtbDescricao);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Location = new System.Drawing.Point(24, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescricao.Location = new System.Drawing.Point(6, 75);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(519, 92);
            this.rtbDescricao.TabIndex = 13;
            this.rtbDescricao.Text = "";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 15);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.Location = new System.Drawing.Point(6, 34);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(519, 20);
            this.txbNome.TabIndex = 11;
            // 
            // gpCategoria
            // 
            this.gpCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCategoria.Controls.Add(this.rbNaoPerecivel);
            this.gpCategoria.Controls.Add(this.rbPerecivel);
            this.gpCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCategoria.Location = new System.Drawing.Point(580, 4);
            this.gpCategoria.Name = "gpCategoria";
            this.gpCategoria.Size = new System.Drawing.Size(125, 69);
            this.gpCategoria.TabIndex = 10;
            this.gpCategoria.TabStop = false;
            // 
            // rbNaoPerecivel
            // 
            this.rbNaoPerecivel.AutoSize = true;
            this.rbNaoPerecivel.Location = new System.Drawing.Point(7, 40);
            this.rbNaoPerecivel.Name = "rbNaoPerecivel";
            this.rbNaoPerecivel.Size = new System.Drawing.Size(116, 19);
            this.rbNaoPerecivel.TabIndex = 1;
            this.rbNaoPerecivel.TabStop = true;
            this.rbNaoPerecivel.Text = "Não Perecível";
            this.rbNaoPerecivel.UseVisualStyleBackColor = true;
            this.rbNaoPerecivel.CheckedChanged += new System.EventHandler(this.rbNaoPerecivel_CheckedChanged);
            // 
            // rbPerecivel
            // 
            this.rbPerecivel.AutoSize = true;
            this.rbPerecivel.Location = new System.Drawing.Point(6, 16);
            this.rbPerecivel.Name = "rbPerecivel";
            this.rbPerecivel.Size = new System.Drawing.Size(87, 19);
            this.rbPerecivel.TabIndex = 0;
            this.rbPerecivel.TabStop = true;
            this.rbPerecivel.Text = "Perecível";
            this.rbPerecivel.UseVisualStyleBackColor = true;
            this.rbPerecivel.CheckedChanged += new System.EventHandler(this.rbPerecivel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txbMargemDeLucro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbPrecoDeVenda);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbQuantidadeEstoque);
            this.groupBox2.Controls.Add(this.txbPrecoCusto);
            this.groupBox2.Controls.Add(this.lblPrecoCusto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(580, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 207);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txbMargemDeLucro
            // 
            this.txbMargemDeLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMargemDeLucro.Enabled = false;
            this.txbMargemDeLucro.Location = new System.Drawing.Point(12, 119);
            this.txbMargemDeLucro.Name = "txbMargemDeLucro";
            this.txbMargemDeLucro.Size = new System.Drawing.Size(242, 20);
            this.txbMargemDeLucro.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Margem de Lucro";
            // 
            // txbPrecoDeVenda
            // 
            this.txbPrecoDeVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecoDeVenda.Location = new System.Drawing.Point(12, 170);
            this.txbPrecoDeVenda.Name = "txbPrecoDeVenda";
            this.txbPrecoDeVenda.Size = new System.Drawing.Size(242, 20);
            this.txbPrecoDeVenda.TabIndex = 5;
            this.txbPrecoDeVenda.TextChanged += new System.EventHandler(this.txbPrecoDeVenda_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Quantidade";
            // 
            // txbQuantidadeEstoque
            // 
            this.txbQuantidadeEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuantidadeEstoque.Location = new System.Drawing.Point(12, 37);
            this.txbQuantidadeEstoque.Name = "txbQuantidadeEstoque";
            this.txbQuantidadeEstoque.Size = new System.Drawing.Size(242, 20);
            this.txbQuantidadeEstoque.TabIndex = 25;
            // 
            // txbPrecoCusto
            // 
            this.txbPrecoCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecoCusto.Location = new System.Drawing.Point(12, 78);
            this.txbPrecoCusto.Name = "txbPrecoCusto";
            this.txbPrecoCusto.Size = new System.Drawing.Size(242, 20);
            this.txbPrecoCusto.TabIndex = 3;
            this.txbPrecoCusto.TextChanged += new System.EventHandler(this.txbPrecoCusto_TextChanged);
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCusto.ForeColor = System.Drawing.Color.Black;
            this.lblPrecoCusto.Location = new System.Drawing.Point(9, 60);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(106, 15);
            this.lblPrecoCusto.TabIndex = 2;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço de Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data de Fabricação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(185, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data de Vencimento";
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
            this.btnAlterar.Location = new System.Drawing.Point(167, 319);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Rotation = 0D;
            this.btnAlterar.Size = new System.Drawing.Size(127, 35);
            this.btnAlterar.TabIndex = 20;
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
            this.btnAdicionar.Location = new System.Drawing.Point(24, 319);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Rotation = 0D;
            this.btnAdicionar.Size = new System.Drawing.Size(127, 35);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // rbProdutoInativo
            // 
            this.rbProdutoInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbProdutoInativo.AutoSize = true;
            this.rbProdutoInativo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProdutoInativo.Location = new System.Drawing.Point(15, 40);
            this.rbProdutoInativo.Name = "rbProdutoInativo";
            this.rbProdutoInativo.Size = new System.Drawing.Size(124, 19);
            this.rbProdutoInativo.TabIndex = 23;
            this.rbProdutoInativo.TabStop = true;
            this.rbProdutoInativo.Text = "Produto inativo";
            this.rbProdutoInativo.UseVisualStyleBackColor = true;
            // 
            // rbProdutoAtivo
            // 
            this.rbProdutoAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbProdutoAtivo.AutoSize = true;
            this.rbProdutoAtivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProdutoAtivo.Location = new System.Drawing.Point(14, 14);
            this.rbProdutoAtivo.Name = "rbProdutoAtivo";
            this.rbProdutoAtivo.Size = new System.Drawing.Size(113, 19);
            this.rbProdutoAtivo.TabIndex = 22;
            this.rbProdutoAtivo.TabStop = true;
            this.rbProdutoAtivo.Text = "Produto Ativo";
            this.rbProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.ColumnHeadersHeight = 30;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduto.EnableHeadersVisualStyles = false;
            this.dgvProduto.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvProduto.Location = new System.Drawing.Point(20, 360);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduto.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(836, 153);
            this.dgvProduto.TabIndex = 24;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rbProdutoAtivo);
            this.groupBox3.Controls.Add(this.rbProdutoInativo);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(711, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 69);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // ckbInativo
            // 
            this.ckbInativo.AutoSize = true;
            this.ckbInativo.Location = new System.Drawing.Point(457, 329);
            this.ckbInativo.Name = "ckbInativo";
            this.ckbInativo.Size = new System.Drawing.Size(58, 17);
            this.ckbInativo.TabIndex = 28;
            this.ckbInativo.Text = "Inativo";
            this.ckbInativo.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Azure;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.Green;
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsulta.IconColor = System.Drawing.Color.Green;
            this.btnConsulta.IconSize = 32;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsulta.Location = new System.Drawing.Point(312, 319);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Rotation = 0D;
            this.btnConsulta.Size = new System.Drawing.Size(127, 35);
            this.btnConsulta.TabIndex = 29;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // msktDataFabricacao
            // 
            this.msktDataFabricacao.Location = new System.Drawing.Point(24, 281);
            this.msktDataFabricacao.Mask = "00/00/0000";
            this.msktDataFabricacao.Name = "msktDataFabricacao";
            this.msktDataFabricacao.Size = new System.Drawing.Size(85, 20);
            this.msktDataFabricacao.TabIndex = 30;
            // 
            // msktDataVencimento
            // 
            this.msktDataVencimento.Location = new System.Drawing.Point(188, 281);
            this.msktDataVencimento.Mask = "00/00/0000";
            this.msktDataVencimento.Name = "msktDataVencimento";
            this.msktDataVencimento.Size = new System.Drawing.Size(100, 20);
            this.msktDataVencimento.TabIndex = 31;
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(19, 36);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(54, 20);
            this.txbId.TabIndex = 45;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(17, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "ID";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.msktDataVencimento);
            this.Controls.Add(this.msktDataFabricacao);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.ckbInativo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpCategoria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txbCodigoBarras);
            this.Controls.Add(this.lblCodBarras);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpCategoria.ResumeLayout(false);
            this.gpCategoria.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txbCodigoBarras;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox gpCategoria;
        private System.Windows.Forms.RadioButton rbNaoPerecivel;
        private System.Windows.Forms.RadioButton rbPerecivel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbMargemDeLucro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPrecoDeVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrecoCusto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private System.Windows.Forms.RadioButton rbProdutoInativo;
        private System.Windows.Forms.RadioButton rbProdutoAtivo;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txbQuantidadeEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbInativo;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private System.Windows.Forms.MaskedTextBox msktDataFabricacao;
        private System.Windows.Forms.MaskedTextBox msktDataVencimento;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
    }
}