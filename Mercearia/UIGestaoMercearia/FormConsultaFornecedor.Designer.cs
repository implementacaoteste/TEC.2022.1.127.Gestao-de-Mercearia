namespace UIGestaoMercearia
{
    partial class FormConsultaFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.bindingSourceFornecedor = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Fornecedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.RowHeadersWidth = 51;
            this.dataGridViewFornecedor.RowTemplate.Height = 29;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(824, 424);
            this.dataGridViewFornecedor.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(440, 78);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(540, 78);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(636, 78);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 29);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(736, 78);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(636, 543);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 3;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(736, 543);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(151, 77);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(283, 27);
            this.textBoxBuscarPor.TabIndex = 4;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Nome",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 76);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(133, 28);
            this.comboBoxBuscarPor.TabIndex = 5;
            // 
            // bindingSourceFornecedor
            // 
            this.bindingSourceFornecedor.DataSource = typeof(Models.Fornecedor);
            // 
            // FormConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(848, 588);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormConsultaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewFornecedor;
        private Button buttonBuscar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private Button buttonExcluir;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private ComboBox comboBoxBuscarPor;
        private BindingSource bindingSourceFornecedor;
    }
}