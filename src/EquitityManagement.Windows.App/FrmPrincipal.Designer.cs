namespace EquitityManagement.Windows.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNovoDocumento = new System.Windows.Forms.Button();
            this.btnAbrirDocumento = new System.Windows.Forms.Button();
            this.btnSalvarDocumento = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPainelPreco = new System.Windows.Forms.Button();
            this.dgvPosicoes = new System.Windows.Forms.DataGridView();
            this.positionFileDocumentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovaOrdem = new System.Windows.Forms.Button();
            this.btnNovaTransacao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRebaixamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJurosDividendos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalRetorno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorização = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAlocado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalLivre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalRisco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDistribuicao = new System.Windows.Forms.DataGridView();
            this.groupAssetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCurrencyEquitityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retornoCurrencyEquitityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distruibuicaoFileDocumentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAtivos = new System.Windows.Forms.Button();
            this.btnTiposAtivos = new System.Windows.Forms.Button();
            this.btnDadosExemplo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.assetTradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentRiskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degradationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCurrencyEquitityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionFileDocumentDtoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribuicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distruibuicaoFileDocumentDtoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoDocumento
            // 
            this.btnNovoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoDocumento.Location = new System.Drawing.Point(12, 12);
            this.btnNovoDocumento.Name = "btnNovoDocumento";
            this.btnNovoDocumento.Size = new System.Drawing.Size(131, 37);
            this.btnNovoDocumento.TabIndex = 0;
            this.btnNovoDocumento.Text = "Novo";
            this.btnNovoDocumento.UseVisualStyleBackColor = true;
            this.btnNovoDocumento.Click += new System.EventHandler(this.btnNovoDocumento_Click);
            // 
            // btnAbrirDocumento
            // 
            this.btnAbrirDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirDocumento.Location = new System.Drawing.Point(149, 12);
            this.btnAbrirDocumento.Name = "btnAbrirDocumento";
            this.btnAbrirDocumento.Size = new System.Drawing.Size(131, 37);
            this.btnAbrirDocumento.TabIndex = 1;
            this.btnAbrirDocumento.Text = "Abrir";
            this.btnAbrirDocumento.UseVisualStyleBackColor = true;
            this.btnAbrirDocumento.Click += new System.EventHandler(this.btnAbrirDocumento_Click);
            // 
            // btnSalvarDocumento
            // 
            this.btnSalvarDocumento.Enabled = false;
            this.btnSalvarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarDocumento.Location = new System.Drawing.Point(286, 12);
            this.btnSalvarDocumento.Name = "btnSalvarDocumento";
            this.btnSalvarDocumento.Size = new System.Drawing.Size(131, 37);
            this.btnSalvarDocumento.TabIndex = 2;
            this.btnSalvarDocumento.Text = "Salvar";
            this.btnSalvarDocumento.UseVisualStyleBackColor = true;
            this.btnSalvarDocumento.Click += new System.EventHandler(this.btnSalvarDocumento_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(697, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 37);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPainelPreco
            // 
            this.btnPainelPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPainelPreco.Enabled = false;
            this.btnPainelPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainelPreco.Location = new System.Drawing.Point(504, 462);
            this.btnPainelPreco.Name = "btnPainelPreco";
            this.btnPainelPreco.Size = new System.Drawing.Size(131, 37);
            this.btnPainelPreco.TabIndex = 6;
            this.btnPainelPreco.Text = "Painel de preços";
            this.btnPainelPreco.UseVisualStyleBackColor = true;
            this.btnPainelPreco.Click += new System.EventHandler(this.btnPainelPreco_Click);
            // 
            // dgvPosicoes
            // 
            this.dgvPosicoes.AllowUserToAddRows = false;
            this.dgvPosicoes.AllowUserToDeleteRows = false;
            this.dgvPosicoes.AllowUserToResizeColumns = false;
            this.dgvPosicoes.AllowUserToResizeRows = false;
            this.dgvPosicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosicoes.AutoGenerateColumns = false;
            this.dgvPosicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetTradeDataGridViewTextBoxColumn,
            this.percentRiskDataGridViewTextBoxColumn,
            this.currentPriceDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.degradationDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.costCurrencyDataGridViewTextBoxColumn,
            this.costCurrencyEquitityDataGridViewTextBoxColumn});
            this.dgvPosicoes.DataSource = this.positionFileDocumentDtoBindingSource;
            this.dgvPosicoes.Enabled = false;
            this.dgvPosicoes.Location = new System.Drawing.Point(6, 22);
            this.dgvPosicoes.MultiSelect = false;
            this.dgvPosicoes.Name = "dgvPosicoes";
            this.dgvPosicoes.ReadOnly = true;
            this.dgvPosicoes.RowHeadersVisible = false;
            this.dgvPosicoes.RowTemplate.Height = 25;
            this.dgvPosicoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosicoes.Size = new System.Drawing.Size(748, 199);
            this.dgvPosicoes.TabIndex = 0;
            this.dgvPosicoes.DoubleClick += new System.EventHandler(this.dgvPosicoes_DoubleClick);
            // 
            // positionFileDocumentDtoBindingSource
            // 
            this.positionFileDocumentDtoBindingSource.DataSource = typeof(EquitityManagement.Core.Dto.Position.PositionFileDocumentDto);
            // 
            // btnNovaOrdem
            // 
            this.btnNovaOrdem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaOrdem.Enabled = false;
            this.btnNovaOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOrdem.Location = new System.Drawing.Point(504, 591);
            this.btnNovaOrdem.Name = "btnNovaOrdem";
            this.btnNovaOrdem.Size = new System.Drawing.Size(268, 37);
            this.btnNovaOrdem.TabIndex = 11;
            this.btnNovaOrdem.Text = "Ordens";
            this.btnNovaOrdem.UseVisualStyleBackColor = true;
            this.btnNovaOrdem.Click += new System.EventHandler(this.btnNovaOrdem_Click);
            // 
            // btnNovaTransacao
            // 
            this.btnNovaTransacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaTransacao.Enabled = false;
            this.btnNovaTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaTransacao.Location = new System.Drawing.Point(504, 548);
            this.btnNovaTransacao.Name = "btnNovaTransacao";
            this.btnNovaTransacao.Size = new System.Drawing.Size(268, 37);
            this.btnNovaTransacao.TabIndex = 10;
            this.btnNovaTransacao.Text = "Juros/dividendos";
            this.btnNovaTransacao.UseVisualStyleBackColor = true;
            this.btnNovaTransacao.Click += new System.EventHandler(this.btnNovaTransacao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtRebaixamento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtJurosDividendos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.totalRetorno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRetorno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValorização);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalAlocado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotalLivre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.totalRisco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMoeda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // txtRebaixamento
            // 
            this.txtRebaixamento.Location = new System.Drawing.Point(167, 81);
            this.txtRebaixamento.Name = "txtRebaixamento";
            this.txtRebaixamento.PlaceholderText = "0.000.000.000.000,00";
            this.txtRebaixamento.ReadOnly = true;
            this.txtRebaixamento.Size = new System.Drawing.Size(155, 23);
            this.txtRebaixamento.TabIndex = 4;
            this.txtRebaixamento.TabStop = false;
            this.txtRebaixamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rebaixamento";
            // 
            // txtJurosDividendos
            // 
            this.txtJurosDividendos.Location = new System.Drawing.Point(167, 125);
            this.txtJurosDividendos.Name = "txtJurosDividendos";
            this.txtJurosDividendos.PlaceholderText = "0.000.000.000.000,00";
            this.txtJurosDividendos.ReadOnly = true;
            this.txtJurosDividendos.Size = new System.Drawing.Size(155, 23);
            this.txtJurosDividendos.TabIndex = 5;
            this.txtJurosDividendos.TabStop = false;
            this.txtJurosDividendos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Retorno";
            // 
            // totalRetorno
            // 
            this.totalRetorno.Location = new System.Drawing.Point(328, 37);
            this.totalRetorno.Name = "totalRetorno";
            this.totalRetorno.PlaceholderText = "0.000.000.000.000,00";
            this.totalRetorno.ReadOnly = true;
            this.totalRetorno.Size = new System.Drawing.Size(152, 23);
            this.totalRetorno.TabIndex = 6;
            this.totalRetorno.TabStop = false;
            this.totalRetorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Risco";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(328, 81);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.PlaceholderText = "0.000.000.000.000,00";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.Size = new System.Drawing.Size(152, 23);
            this.txtRetorno.TabIndex = 7;
            this.txtRetorno.TabStop = false;
            this.txtRetorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total livre";
            // 
            // txtValorização
            // 
            this.txtValorização.Location = new System.Drawing.Point(328, 125);
            this.txtValorização.Name = "txtValorização";
            this.txtValorização.PlaceholderText = "0,00 %";
            this.txtValorização.ReadOnly = true;
            this.txtValorização.Size = new System.Drawing.Size(152, 23);
            this.txtValorização.TabIndex = 8;
            this.txtValorização.TabStop = false;
            this.txtValorização.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valorização";
            // 
            // txtTotalAlocado
            // 
            this.txtTotalAlocado.Location = new System.Drawing.Point(167, 37);
            this.txtTotalAlocado.Name = "txtTotalAlocado";
            this.txtTotalAlocado.PlaceholderText = "0.000.000.000.000,00";
            this.txtTotalAlocado.ReadOnly = true;
            this.txtTotalAlocado.Size = new System.Drawing.Size(155, 23);
            this.txtTotalAlocado.TabIndex = 3;
            this.txtTotalAlocado.TabStop = false;
            this.txtTotalAlocado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total alocado";
            // 
            // txtTotalLivre
            // 
            this.txtTotalLivre.Location = new System.Drawing.Point(6, 125);
            this.txtTotalLivre.Name = "txtTotalLivre";
            this.txtTotalLivre.PlaceholderText = "0.000.000.000.000,00";
            this.txtTotalLivre.ReadOnly = true;
            this.txtTotalLivre.Size = new System.Drawing.Size(155, 23);
            this.txtTotalLivre.TabIndex = 2;
            this.txtTotalLivre.TabStop = false;
            this.txtTotalLivre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Juros/Dividendos";
            // 
            // totalRisco
            // 
            this.totalRisco.Location = new System.Drawing.Point(6, 81);
            this.totalRisco.Name = "totalRisco";
            this.totalRisco.PlaceholderText = "10 %";
            this.totalRisco.ReadOnly = true;
            this.totalRisco.Size = new System.Drawing.Size(155, 23);
            this.totalRisco.TabIndex = 1;
            this.totalRisco.TabStop = false;
            this.totalRisco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retorno";
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(6, 37);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.PlaceholderText = "BRL";
            this.txtMoeda.ReadOnly = true;
            this.txtMoeda.Size = new System.Drawing.Size(155, 23);
            this.txtMoeda.TabIndex = 0;
            this.txtMoeda.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moeda";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDistribuicao);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 167);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribuição";
            // 
            // dgvDistribuicao
            // 
            this.dgvDistribuicao.AllowUserToAddRows = false;
            this.dgvDistribuicao.AllowUserToDeleteRows = false;
            this.dgvDistribuicao.AllowUserToResizeColumns = false;
            this.dgvDistribuicao.AllowUserToResizeRows = false;
            this.dgvDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDistribuicao.AutoGenerateColumns = false;
            this.dgvDistribuicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistribuicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistribuicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupAssetNameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.costCurrencyEquitityDataGridViewTextBoxColumn1,
            this.retornoDataGridViewTextBoxColumn,
            this.retornoCurrencyEquitityDataGridViewTextBoxColumn,
            this.variacaoDataGridViewTextBoxColumn});
            this.dgvDistribuicao.DataSource = this.distruibuicaoFileDocumentDtoBindingSource;
            this.dgvDistribuicao.Enabled = false;
            this.dgvDistribuicao.Location = new System.Drawing.Point(6, 22);
            this.dgvDistribuicao.MultiSelect = false;
            this.dgvDistribuicao.Name = "dgvDistribuicao";
            this.dgvDistribuicao.ReadOnly = true;
            this.dgvDistribuicao.RowHeadersVisible = false;
            this.dgvDistribuicao.RowTemplate.Height = 25;
            this.dgvDistribuicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistribuicao.Size = new System.Drawing.Size(748, 135);
            this.dgvDistribuicao.TabIndex = 0;
            // 
            // groupAssetNameDataGridViewTextBoxColumn
            // 
            this.groupAssetNameDataGridViewTextBoxColumn.DataPropertyName = "GroupAssetName";
            this.groupAssetNameDataGridViewTextBoxColumn.HeaderText = "GroupAssetName";
            this.groupAssetNameDataGridViewTextBoxColumn.Name = "groupAssetNameDataGridViewTextBoxColumn";
            this.groupAssetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costCurrencyEquitityDataGridViewTextBoxColumn1
            // 
            this.costCurrencyEquitityDataGridViewTextBoxColumn1.DataPropertyName = "CostCurrencyEquitity";
            this.costCurrencyEquitityDataGridViewTextBoxColumn1.HeaderText = "CostCurrencyEquitity";
            this.costCurrencyEquitityDataGridViewTextBoxColumn1.Name = "costCurrencyEquitityDataGridViewTextBoxColumn1";
            this.costCurrencyEquitityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // retornoDataGridViewTextBoxColumn
            // 
            this.retornoDataGridViewTextBoxColumn.DataPropertyName = "Retorno";
            this.retornoDataGridViewTextBoxColumn.HeaderText = "Retorno";
            this.retornoDataGridViewTextBoxColumn.Name = "retornoDataGridViewTextBoxColumn";
            this.retornoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retornoCurrencyEquitityDataGridViewTextBoxColumn
            // 
            this.retornoCurrencyEquitityDataGridViewTextBoxColumn.DataPropertyName = "RetornoCurrencyEquitity";
            this.retornoCurrencyEquitityDataGridViewTextBoxColumn.HeaderText = "RetornoCurrencyEquitity";
            this.retornoCurrencyEquitityDataGridViewTextBoxColumn.Name = "retornoCurrencyEquitityDataGridViewTextBoxColumn";
            this.retornoCurrencyEquitityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // variacaoDataGridViewTextBoxColumn
            // 
            this.variacaoDataGridViewTextBoxColumn.DataPropertyName = "Variacao";
            this.variacaoDataGridViewTextBoxColumn.HeaderText = "Variacao";
            this.variacaoDataGridViewTextBoxColumn.Name = "variacaoDataGridViewTextBoxColumn";
            this.variacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distruibuicaoFileDocumentDtoBindingSource
            // 
            this.distruibuicaoFileDocumentDtoBindingSource.DataSource = typeof(EquitityManagement.Core.Dto.Distribuicao.DistruibuicaoFileDocumentDto);
            // 
            // btnAtivos
            // 
            this.btnAtivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtivos.Enabled = false;
            this.btnAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivos.Location = new System.Drawing.Point(504, 505);
            this.btnAtivos.Name = "btnAtivos";
            this.btnAtivos.Size = new System.Drawing.Size(131, 37);
            this.btnAtivos.TabIndex = 8;
            this.btnAtivos.Text = "Ativos";
            this.btnAtivos.UseVisualStyleBackColor = true;
            this.btnAtivos.Click += new System.EventHandler(this.btnAtivos_Click);
            // 
            // btnTiposAtivos
            // 
            this.btnTiposAtivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTiposAtivos.Enabled = false;
            this.btnTiposAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposAtivos.Location = new System.Drawing.Point(641, 462);
            this.btnTiposAtivos.Name = "btnTiposAtivos";
            this.btnTiposAtivos.Size = new System.Drawing.Size(131, 37);
            this.btnTiposAtivos.TabIndex = 7;
            this.btnTiposAtivos.Text = "Grupo de Ativos";
            this.btnTiposAtivos.UseVisualStyleBackColor = true;
            this.btnTiposAtivos.Click += new System.EventHandler(this.btnTiposAtivos_Click);
            // 
            // btnDadosExemplo
            // 
            this.btnDadosExemplo.Enabled = false;
            this.btnDadosExemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosExemplo.Location = new System.Drawing.Point(641, 505);
            this.btnDadosExemplo.Name = "btnDadosExemplo";
            this.btnDadosExemplo.Size = new System.Drawing.Size(131, 37);
            this.btnDadosExemplo.TabIndex = 9;
            this.btnDadosExemplo.Text = "Dados exemplo";
            this.btnDadosExemplo.UseVisualStyleBackColor = true;
            this.btnDadosExemplo.Click += new System.EventHandler(this.btnDadosExemplo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(616, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 37);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvPosicoes);
            this.groupBox3.Location = new System.Drawing.Point(12, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 227);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Posições";
            // 
            // assetTradeDataGridViewTextBoxColumn
            // 
            this.assetTradeDataGridViewTextBoxColumn.DataPropertyName = "AssetTrade";
            this.assetTradeDataGridViewTextBoxColumn.HeaderText = "AssetTrade";
            this.assetTradeDataGridViewTextBoxColumn.Name = "assetTradeDataGridViewTextBoxColumn";
            this.assetTradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentRiskDataGridViewTextBoxColumn
            // 
            this.percentRiskDataGridViewTextBoxColumn.DataPropertyName = "PercentRisk";
            this.percentRiskDataGridViewTextBoxColumn.HeaderText = "PercentRisk";
            this.percentRiskDataGridViewTextBoxColumn.Name = "percentRiskDataGridViewTextBoxColumn";
            this.percentRiskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentPriceDataGridViewTextBoxColumn
            // 
            this.currentPriceDataGridViewTextBoxColumn.DataPropertyName = "CurrentPrice";
            this.currentPriceDataGridViewTextBoxColumn.HeaderText = "CurrentPrice";
            this.currentPriceDataGridViewTextBoxColumn.Name = "currentPriceDataGridViewTextBoxColumn";
            this.currentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degradationDataGridViewTextBoxColumn
            // 
            this.degradationDataGridViewTextBoxColumn.DataPropertyName = "Degradation";
            this.degradationDataGridViewTextBoxColumn.HeaderText = "Degradation";
            this.degradationDataGridViewTextBoxColumn.Name = "degradationDataGridViewTextBoxColumn";
            this.degradationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costCurrencyDataGridViewTextBoxColumn
            // 
            this.costCurrencyDataGridViewTextBoxColumn.DataPropertyName = "CostCurrency";
            this.costCurrencyDataGridViewTextBoxColumn.HeaderText = "CostCurrency";
            this.costCurrencyDataGridViewTextBoxColumn.Name = "costCurrencyDataGridViewTextBoxColumn";
            this.costCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costCurrencyEquitityDataGridViewTextBoxColumn
            // 
            this.costCurrencyEquitityDataGridViewTextBoxColumn.DataPropertyName = "CostCurrencyEquitity";
            this.costCurrencyEquitityDataGridViewTextBoxColumn.HeaderText = "CostCurrencyEquitity";
            this.costCurrencyEquitityDataGridViewTextBoxColumn.Name = "costCurrencyEquitityDataGridViewTextBoxColumn";
            this.costCurrencyEquitityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnDadosExemplo);
            this.Controls.Add(this.btnTiposAtivos);
            this.Controls.Add(this.btnAtivos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovaTransacao);
            this.Controls.Add(this.btnNovaOrdem);
            this.Controls.Add(this.btnPainelPreco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvarDocumento);
            this.Controls.Add(this.btnAbrirDocumento);
            this.Controls.Add(this.btnNovoDocumento);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equitity Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionFileDocumentDtoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribuicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distruibuicaoFileDocumentDtoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoDocumento;
        private System.Windows.Forms.Button btnAbrirDocumento;
        private System.Windows.Forms.Button btnSalvarDocumento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPainelPreco;
        private System.Windows.Forms.DataGridView dgvPosicoes;
        private System.Windows.Forms.Button btnNovaOrdem;
        private System.Windows.Forms.Button btnNovaTransacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAtivos;
        private System.Windows.Forms.Button btnTiposAtivos;
        private System.Windows.Forms.BindingSource positionFileDocumentDtoBindingSource;
        private System.Windows.Forms.Button btnDadosExemplo;
        private System.Windows.Forms.DataGridView dgvDistribuicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupAssetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCurrencyEquitityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn retornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retornoCurrencyEquitityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource distruibuicaoFileDocumentDtoBindingSource;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtTotalAlocado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalLivre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalRisco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRebaixamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJurosDividendos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalRetorno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorização;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetTradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentRiskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degradationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCurrencyEquitityDataGridViewTextBoxColumn;
    }
}
