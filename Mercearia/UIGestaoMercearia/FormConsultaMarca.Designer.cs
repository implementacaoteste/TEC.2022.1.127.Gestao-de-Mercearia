namespace UIGestaoMercearia
{
    partial class FormConsultaMarca
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceMarca = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.labelGerenProd = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMarca)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.buttonBuscar);
            this.panel2.Controls.Add(this.textBoxBuscarPor);
            this.panel2.Controls.Add(this.comboBoxBuscarPor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 53);
            this.panel2.TabIndex = 11;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(573, 13);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(149, 16);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(382, 27);
            this.textBoxBuscarPor.TabIndex = 1;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 15);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(131, 28);
            this.comboBoxBuscarPor.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(573, 417);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(573, 372);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 29);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Location = new System.Drawing.Point(573, 321);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.AllowUserToDeleteRows = false;
            this.dataGridViewMarca.AllowUserToOrderColumns = true;
            this.dataGridViewMarca.AutoGenerateColumns = false;
            this.dataGridViewMarca.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridViewMarca.DataSource = this.bindingSourceMarca;
            this.dataGridViewMarca.Location = new System.Drawing.Point(3, 59);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.ReadOnly = true;
            this.dataGridViewMarca.RowHeadersWidth = 51;
            this.dataGridViewMarca.RowTemplate.Height = 29;
            this.dataGridViewMarca.Size = new System.Drawing.Size(529, 387);
            this.dataGridViewMarca.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 350;
            // 
            // bindingSourceMarca
            // 
            this.bindingSourceMarca.DataSource = typeof(Models.Marca);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSelecionar);
            this.panel1.Controls.Add(this.labelGerenProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 81);
            this.panel1.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(573, 29);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar.Location = new System.Drawing.Point(457, 29);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 1;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = false;
            // 
            // labelGerenProd
            // 
            this.labelGerenProd.AutoSize = true;
            this.labelGerenProd.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelGerenProd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGerenProd.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGerenProd.Location = new System.Drawing.Point(12, 26);
            this.labelGerenProd.Name = "labelGerenProd";
            this.labelGerenProd.Size = new System.Drawing.Size(249, 28);
            this.labelGerenProd.TabIndex = 0;
            this.labelGerenProd.Text = "Gerenciamento de Marcas";
            // 
            // FormConsultaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(693, 553);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewMarca);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaMarca";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMarca)).EndInit();
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
        private DataGridView dataGridViewMarca;
        private BindingSource bindingSourceMarca;
        private Panel panel1;
        private Button buttonCancelar;
        private Button buttonSelecionar;
        private Label labelGerenProd;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}