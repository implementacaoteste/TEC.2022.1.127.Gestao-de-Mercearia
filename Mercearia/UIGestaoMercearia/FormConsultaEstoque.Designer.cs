namespace UIGestaoMercearia
{
    partial class FormConsultaEstoque
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
            this.bindingSourceEstoque = new System.Windows.Forms.BindingSource(this.components);
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.labelGerenProd = new System.Windows.Forms.Label();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceEstoque
            // 
            this.bindingSourceEstoque.DataSource = typeof(Models.Estoque);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueMaximoDataGridViewTextBoxColumn
            // 
            this.estoqueMaximoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMaximo";
            this.estoqueMaximoDataGridViewTextBoxColumn.HeaderText = "EstoqueMaximo";
            this.estoqueMaximoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueMaximoDataGridViewTextBoxColumn.Name = "estoqueMaximoDataGridViewTextBoxColumn";
            this.estoqueMaximoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueMinimoDataGridViewTextBoxColumn
            // 
            this.estoqueMinimoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.HeaderText = "EstoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueMinimoDataGridViewTextBoxColumn.Name = "estoqueMinimoDataGridViewTextBoxColumn";
            this.estoqueMinimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // datadeSaidaDataGridViewTextBoxColumn
            // 
            this.datadeSaidaDataGridViewTextBoxColumn.DataPropertyName = "DatadeSaida";
            this.datadeSaidaDataGridViewTextBoxColumn.HeaderText = "DatadeSaida";
            this.datadeSaidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datadeSaidaDataGridViewTextBoxColumn.Name = "datadeSaidaDataGridViewTextBoxColumn";
            this.datadeSaidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datadeEntradaDataGridViewTextBoxColumn
            // 
            this.datadeEntradaDataGridViewTextBoxColumn.DataPropertyName = "DatadeEntrada";
            this.datadeEntradaDataGridViewTextBoxColumn.HeaderText = "DatadeEntrada";
            this.datadeEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datadeEntradaDataGridViewTextBoxColumn.Name = "datadeEntradaDataGridViewTextBoxColumn";
            this.datadeEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AutoGenerateColumns = false;
            this.dataGridViewEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datadeEntradaDataGridViewTextBoxColumn,
            this.datadeSaidaDataGridViewTextBoxColumn,
            this.estoqueMinimoDataGridViewTextBoxColumn,
            this.estoqueMaximoDataGridViewTextBoxColumn,
            this.idProdutoDataGridViewTextBoxColumn});
            this.dataGridViewEstoque.DataSource = this.bindingSourceEstoque;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(0, 149);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.RowHeadersWidth = 51;
            this.dataGridViewEstoque.RowTemplate.Height = 29;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(982, 417);
            this.dataGridViewEstoque.TabIndex = 4;
            this.dataGridViewEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstoque_CellContentClick);
            // 
            // labelGerenProd
            // 
            this.labelGerenProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGerenProd.AutoSize = true;
            this.labelGerenProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.labelGerenProd.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGerenProd.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGerenProd.Location = new System.Drawing.Point(234, 9);
            this.labelGerenProd.Name = "labelGerenProd";
            this.labelGerenProd.Size = new System.Drawing.Size(493, 44);
            this.labelGerenProd.TabIndex = 0;
            this.labelGerenProd.Text = "Gerenciamento de Estoque";
            this.labelGerenProd.Click += new System.EventHandler(this.labelGerenProd_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonSelecionar.Location = new System.Drawing.Point(774, 10);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 38);
            this.buttonSelecionar.TabIndex = 1;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click_1);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonCancelar.Location = new System.Drawing.Point(876, 10);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 38);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSelecionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 60);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(10, 107);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxBuscarPor.TabIndex = 0;
            this.comboBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarPor_SelectedIndexChanged);
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(167, 107);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(402, 27);
            this.textBoxBuscarPor.TabIndex = 1;
            this.textBoxBuscarPor.TextChanged += new System.EventHandler(this.textBoxBuscarPor_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(575, 96);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 38);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(675, 96);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 38);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(775, 96);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 38);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(871, 96);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 38);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridViewEstoque);
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.labelGerenProd);
            this.panel2.Controls.Add(this.buttonInserir);
            this.panel2.Controls.Add(this.buttonAlterar);
            this.panel2.Controls.Add(this.buttonBuscar);
            this.panel2.Controls.Add(this.textBoxBuscarPor);
            this.panel2.Controls.Add(this.comboBoxBuscarPor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 576);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Por:";
            // 
            // FormConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(982, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsultaEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormConsultaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bindingSourceEstoque;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueMinimoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datadeSaidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datadeEntradaDataGridViewTextBoxColumn;
        private DataGridView dataGridViewEstoque;
        private Label labelGerenProd;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private Panel panel1;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscarPor;
        private Button buttonBuscar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private Button buttonExcluir;
        private Panel panel2;
        private Label label1;
    }
}