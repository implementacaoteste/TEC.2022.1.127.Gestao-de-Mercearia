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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.datadeEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEstoque = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.labelGerenProd = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.buttonInserir);
            this.panel2.Controls.Add(this.buttonAlterar);
            this.panel2.Controls.Add(this.buttonBuscar);
            this.panel2.Controls.Add(this.textBoxBuscarPor);
            this.panel2.Controls.Add(this.comboBoxBuscarPor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 53);
            this.panel2.TabIndex = 5;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(885, 15);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(789, 15);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 29);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(689, 15);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(589, 15);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(181, 17);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(402, 27);
            this.textBoxBuscarPor.TabIndex = 1;
            this.textBoxBuscarPor.TextChanged += new System.EventHandler(this.textBoxBuscarPor_TextChanged);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(24, 17);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxBuscarPor.TabIndex = 0;
            this.comboBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarPor_SelectedIndexChanged);
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
            this.dataGridViewEstoque.Location = new System.Drawing.Point(181, 50);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.RowHeadersWidth = 51;
            this.dataGridViewEstoque.RowTemplate.Height = 29;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(982, 407);
            this.dataGridViewEstoque.TabIndex = 4;
            this.dataGridViewEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstoque_CellContentClick);
            // 
            // datadeEntradaDataGridViewTextBoxColumn
            // 
            this.datadeEntradaDataGridViewTextBoxColumn.DataPropertyName = "DatadeEntrada";
            this.datadeEntradaDataGridViewTextBoxColumn.HeaderText = "DatadeEntrada";
            this.datadeEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datadeEntradaDataGridViewTextBoxColumn.Name = "datadeEntradaDataGridViewTextBoxColumn";
            this.datadeEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datadeSaidaDataGridViewTextBoxColumn
            // 
            this.datadeSaidaDataGridViewTextBoxColumn.DataPropertyName = "DatadeSaida";
            this.datadeSaidaDataGridViewTextBoxColumn.HeaderText = "DatadeSaida";
            this.datadeSaidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datadeSaidaDataGridViewTextBoxColumn.Name = "datadeSaidaDataGridViewTextBoxColumn";
            this.datadeSaidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueMinimoDataGridViewTextBoxColumn
            // 
            this.estoqueMinimoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.HeaderText = "EstoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueMinimoDataGridViewTextBoxColumn.Name = "estoqueMinimoDataGridViewTextBoxColumn";
            this.estoqueMinimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueMaximoDataGridViewTextBoxColumn
            // 
            this.estoqueMaximoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMaximo";
            this.estoqueMaximoDataGridViewTextBoxColumn.HeaderText = "EstoqueMaximo";
            this.estoqueMaximoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueMaximoDataGridViewTextBoxColumn.Name = "estoqueMaximoDataGridViewTextBoxColumn";
            this.estoqueMaximoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceEstoque
            // 
            this.bindingSourceEstoque.DataSource = typeof(Models.Estoque);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSelecionar);
            this.panel1.Controls.Add(this.labelGerenProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 81);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(876, 29);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(776, 29);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 1;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click_1);
            // 
            // labelGerenProd
            // 
            this.labelGerenProd.AutoSize = true;
            this.labelGerenProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.labelGerenProd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGerenProd.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGerenProd.Location = new System.Drawing.Point(12, 26);
            this.labelGerenProd.Name = "labelGerenProd";
            this.labelGerenProd.Size = new System.Drawing.Size(259, 28);
            this.labelGerenProd.TabIndex = 0;
            this.labelGerenProd.Text = "Gerenciamento de Estoque";
            this.labelGerenProd.Click += new System.EventHandler(this.labelGerenProd_Click);
            // 
            // FormConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(982, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsultaEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormConsultaEstoque_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private TextBox textBoxBuscarPor;
        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewEstoque;
        private Panel panel1;
        private Label labelGerenProd;
        private Button buttonCancelar;
        private Button buttonSelecionar;
        private BindingSource bindingSourceEstoque;
        private DataGridViewTextBoxColumn datadeEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datadeSaidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueMinimoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
    }
}