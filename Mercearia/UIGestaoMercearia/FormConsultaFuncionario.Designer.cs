namespace UIGestaoMercearia
{
    partial class FormConsultaFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.profissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(839, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta funcionario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bucar por";
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "CPF",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 85);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(144, 28);
            this.comboBoxBuscarPor.TabIndex = 7;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBuscar.Location = new System.Drawing.Point(162, 86);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(349, 27);
            this.textBoxBuscar.TabIndex = 8;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(517, 86);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 29);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(598, 86);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 29);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(679, 86);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 29);
            this.buttonInserir.TabIndex = 11;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(760, 86);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 29);
            this.buttonExcluir.TabIndex = 12;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            this.funcionarioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.funcionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.profissaoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn});
            this.funcionarioDataGridView.DataSource = this.funcionarioBindingSource;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(12, 120);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.RowHeadersWidth = 51;
            this.funcionarioDataGridView.RowTemplate.Height = 29;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(823, 286);
            this.funcionarioDataGridView.TabIndex = 13;
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
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // profissaoDataGridViewTextBoxColumn
            // 
            this.profissaoDataGridViewTextBoxColumn.DataPropertyName = "Profissao";
            this.profissaoDataGridViewTextBoxColumn.HeaderText = "Profissao";
            this.profissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profissaoDataGridViewTextBoxColumn.Name = "profissaoDataGridViewTextBoxColumn";
            this.profissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.profissaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Models.Funcionario);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(663, 413);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(91, 29);
            this.buttonSelecionar.TabIndex = 14;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(760, 413);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 29);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(839, 439);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.funcionarioDataGridView);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaFuncionario";
            this.Text = "FormConsultaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private Button buttonExcluir;
        private DataGridView funcionarioDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn profissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private BindingSource funcionarioBindingSource;
        private Button buttonSelecionar;
        private Button buttonCancelar;
    }
}