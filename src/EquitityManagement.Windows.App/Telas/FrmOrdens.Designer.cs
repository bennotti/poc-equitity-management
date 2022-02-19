namespace EquitityManagement.Windows.App.Telas
{
    partial class FrmOrdens
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvOrdens = new System.Windows.Forms.DataGridView();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bokerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderFileDocumentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVariacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecoAtual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoMedio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVolumeTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAtivoOperado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbBrokers = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDataRealizacao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDataAquisicao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustoAquisicao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecoExecutado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFileDocumentDtoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.dgvOrdens);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordens";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(541, 22);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(131, 25);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // dgvOrdens
            // 
            this.dgvOrdens.AllowUserToAddRows = false;
            this.dgvOrdens.AllowUserToDeleteRows = false;
            this.dgvOrdens.AllowUserToResizeColumns = false;
            this.dgvOrdens.AllowUserToResizeRows = false;
            this.dgvOrdens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdens.AutoGenerateColumns = false;
            this.dgvOrdens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.availableDateDataGridViewTextBoxColumn,
            this.bokerDataGridViewTextBoxColumn});
            this.dgvOrdens.DataSource = this.orderFileDocumentDtoBindingSource;
            this.dgvOrdens.Location = new System.Drawing.Point(6, 53);
            this.dgvOrdens.Name = "dgvOrdens";
            this.dgvOrdens.ReadOnly = true;
            this.dgvOrdens.RowHeadersVisible = false;
            this.dgvOrdens.RowTemplate.Height = 25;
            this.dgvOrdens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdens.Size = new System.Drawing.Size(666, 216);
            this.dgvOrdens.TabIndex = 0;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableDateDataGridViewTextBoxColumn
            // 
            this.availableDateDataGridViewTextBoxColumn.DataPropertyName = "AvailableDate";
            this.availableDateDataGridViewTextBoxColumn.HeaderText = "AvailableDate";
            this.availableDateDataGridViewTextBoxColumn.Name = "availableDateDataGridViewTextBoxColumn";
            this.availableDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bokerDataGridViewTextBoxColumn
            // 
            this.bokerDataGridViewTextBoxColumn.DataPropertyName = "Boker";
            this.bokerDataGridViewTextBoxColumn.HeaderText = "Boker";
            this.bokerDataGridViewTextBoxColumn.Name = "bokerDataGridViewTextBoxColumn";
            this.bokerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderFileDocumentDtoBindingSource
            // 
            this.orderFileDocumentDtoBindingSource.DataSource = typeof(EquitityManagement.Core.Dto.Order.OrderFileDocumentDto);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "NASDAQ";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mercado";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtVariacao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPrecoAtual);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrecoMedio);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVolumeTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAtivo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAtivoOperado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posição";
            // 
            // txtVariacao
            // 
            this.txtVariacao.Location = new System.Drawing.Point(602, 81);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.PlaceholderText = "0,00%";
            this.txtVariacao.ReadOnly = true;
            this.txtVariacao.Size = new System.Drawing.Size(70, 23);
            this.txtVariacao.TabIndex = 21;
            this.txtVariacao.TabStop = false;
            this.txtVariacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(602, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Variação";
            // 
            // txtPrecoAtual
            // 
            this.txtPrecoAtual.Location = new System.Drawing.Point(466, 81);
            this.txtPrecoAtual.Name = "txtPrecoAtual";
            this.txtPrecoAtual.PlaceholderText = "0.000.000.000.000,00";
            this.txtPrecoAtual.ReadOnly = true;
            this.txtPrecoAtual.Size = new System.Drawing.Size(130, 23);
            this.txtPrecoAtual.TabIndex = 19;
            this.txtPrecoAtual.TabStop = false;
            this.txtPrecoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Preço atual";
            // 
            // txtPrecoMedio
            // 
            this.txtPrecoMedio.Location = new System.Drawing.Point(330, 81);
            this.txtPrecoMedio.Name = "txtPrecoMedio";
            this.txtPrecoMedio.PlaceholderText = "0.000.000.000.000,00";
            this.txtPrecoMedio.ReadOnly = true;
            this.txtPrecoMedio.Size = new System.Drawing.Size(130, 23);
            this.txtPrecoMedio.TabIndex = 17;
            this.txtPrecoMedio.TabStop = false;
            this.txtPrecoMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preço médio";
            // 
            // txtVolumeTotal
            // 
            this.txtVolumeTotal.Location = new System.Drawing.Point(159, 81);
            this.txtVolumeTotal.Name = "txtVolumeTotal";
            this.txtVolumeTotal.PlaceholderText = "0.000.000.000.000,000000";
            this.txtVolumeTotal.ReadOnly = true;
            this.txtVolumeTotal.Size = new System.Drawing.Size(165, 23);
            this.txtVolumeTotal.TabIndex = 15;
            this.txtVolumeTotal.TabStop = false;
            this.txtVolumeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Volume total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "0.000.000.000.000,00";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(147, 23);
            this.textBox7.TabIndex = 13;
            this.textBox7.TabStop = false;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Custo total";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(542, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Janeiro - 00/00/0000";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(130, 23);
            this.textBox6.TabIndex = 11;
            this.textBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vencimento";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(318, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "USD";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(82, 23);
            this.textBox5.TabIndex = 9;
            this.textBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Moeda";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(406, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Ações no Exterior";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(130, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            // 
            // txtAtivo
            // 
            this.txtAtivo.Location = new System.Drawing.Point(94, 37);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.PlaceholderText = "XXYY";
            this.txtAtivo.ReadOnly = true;
            this.txtAtivo.Size = new System.Drawing.Size(82, 23);
            this.txtAtivo.TabIndex = 3;
            this.txtAtivo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ativo";
            // 
            // txtAtivoOperado
            // 
            this.txtAtivoOperado.Location = new System.Drawing.Point(6, 37);
            this.txtAtivoOperado.Name = "txtAtivoOperado";
            this.txtAtivoOperado.PlaceholderText = "XXYY";
            this.txtAtivoOperado.Size = new System.Drawing.Size(82, 23);
            this.txtAtivoOperado.TabIndex = 5;
            this.txtAtivoOperado.Leave += new System.EventHandler(this.txtAtivoOperado_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ativo operado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnAdicionar);
            this.groupBox3.Controls.Add(this.cbBrokers);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtDataRealizacao);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDataAquisicao);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtValorPago);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtCustoAquisicao);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtVolume);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtPrecoExecutado);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 156);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da ordem";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "0.000.000.000.000,00";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(160, 23);
            this.textBox2.TabIndex = 28;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Taxas";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(6, 113);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 37);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(541, 110);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(131, 37);
            this.btnAdicionar.TabIndex = 26;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbBrokers
            // 
            this.cbBrokers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrokers.FormattingEnabled = true;
            this.cbBrokers.Location = new System.Drawing.Point(358, 81);
            this.cbBrokers.Name = "cbBrokers";
            this.cbBrokers.Size = new System.Drawing.Size(314, 23);
            this.cbBrokers.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(358, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Broker";
            // 
            // txtDataRealizacao
            // 
            this.txtDataRealizacao.Location = new System.Drawing.Point(266, 81);
            this.txtDataRealizacao.Name = "txtDataRealizacao";
            this.txtDataRealizacao.PlaceholderText = "00/00/0000";
            this.txtDataRealizacao.Size = new System.Drawing.Size(86, 23);
            this.txtDataRealizacao.TabIndex = 21;
            this.txtDataRealizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(266, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Data realização";
            // 
            // txtDataAquisicao
            // 
            this.txtDataAquisicao.Location = new System.Drawing.Point(172, 81);
            this.txtDataAquisicao.Name = "txtDataAquisicao";
            this.txtDataAquisicao.PlaceholderText = "00/00/0000";
            this.txtDataAquisicao.Size = new System.Drawing.Size(88, 23);
            this.txtDataAquisicao.TabIndex = 19;
            this.txtDataAquisicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(172, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 20;
            this.label16.Text = "Data arquisição";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(512, 37);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.PlaceholderText = "0.000.000.000.000,00";
            this.txtValorPago.Size = new System.Drawing.Size(160, 23);
            this.txtValorPago.TabIndex = 17;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(512, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Valor Pago";
            // 
            // txtCustoAquisicao
            // 
            this.txtCustoAquisicao.Location = new System.Drawing.Point(346, 37);
            this.txtCustoAquisicao.Name = "txtCustoAquisicao";
            this.txtCustoAquisicao.PlaceholderText = "0.000.000.000.000,00";
            this.txtCustoAquisicao.Size = new System.Drawing.Size(160, 23);
            this.txtCustoAquisicao.TabIndex = 15;
            this.txtCustoAquisicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Custo arquisição";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(170, 37);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.PlaceholderText = "0.000.000.000.000,000000";
            this.txtVolume.Size = new System.Drawing.Size(170, 23);
            this.txtVolume.TabIndex = 7;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Volume";
            // 
            // txtPrecoExecutado
            // 
            this.txtPrecoExecutado.Location = new System.Drawing.Point(6, 37);
            this.txtPrecoExecutado.Name = "txtPrecoExecutado";
            this.txtPrecoExecutado.PlaceholderText = "0.000.000.000.000,00";
            this.txtPrecoExecutado.Size = new System.Drawing.Size(158, 23);
            this.txtPrecoExecutado.TabIndex = 5;
            this.txtPrecoExecutado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Preço executado";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(559, 579);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 37);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(422, 579);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 628);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdens";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordens";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFileDocumentDtoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrdens;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bokerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderFileDocumentDtoBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVariacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecoAtual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecoMedio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVolumeTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtivoOperado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecoExecutado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbBrokers;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDataRealizacao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDataAquisicao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustoAquisicao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
    }
}