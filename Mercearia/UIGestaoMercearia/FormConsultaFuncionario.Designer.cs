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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            comboBoxBuscarPor = new ComboBox();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonAlterar = new Button();
            buttonInserir = new Button();
            buttonExcluir = new Button();
            funcionarioDataGridView = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ativoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            funcionarioBindingSource = new BindingSource(components);
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)funcionarioDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(742, 36);
            label1.TabIndex = 3;
            label1.Text = "CONSULTA FUNCIONÁRIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 47);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "BUSCAR POR:";
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Nome", "Todos" });
            comboBoxBuscarPor.Location = new Point(10, 64);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(126, 23);
            comboBoxBuscarPor.TabIndex = 7;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Cursor = Cursors.IBeam;
            textBoxBuscar.Location = new Point(142, 64);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(306, 23);
            textBoxBuscar.TabIndex = 8;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(452, 64);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(66, 22);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(523, 64);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(66, 22);
            buttonAlterar.TabIndex = 10;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(594, 64);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(66, 22);
            buttonInserir.TabIndex = 11;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(665, 64);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(66, 22);
            buttonExcluir.TabIndex = 12;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // funcionarioDataGridView
            // 
            funcionarioDataGridView.AllowUserToAddRows = false;
            funcionarioDataGridView.AllowUserToDeleteRows = false;
            funcionarioDataGridView.AllowUserToOrderColumns = true;
            funcionarioDataGridView.AutoGenerateColumns = false;
            funcionarioDataGridView.BackgroundColor = Color.White;
            funcionarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            funcionarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, profissaoDataGridViewTextBoxColumn, Telefone, salarioDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, ativoDataGridViewCheckBoxColumn });
            funcionarioDataGridView.DataSource = funcionarioBindingSource;
            funcionarioDataGridView.Location = new Point(10, 90);
            funcionarioDataGridView.Margin = new Padding(3, 2, 3, 2);
            funcionarioDataGridView.Name = "funcionarioDataGridView";
            funcionarioDataGridView.ReadOnly = true;
            funcionarioDataGridView.RowHeadersWidth = 51;
            funcionarioDataGridView.RowTemplate.Height = 29;
            funcionarioDataGridView.Size = new Size(720, 214);
            funcionarioDataGridView.TabIndex = 13;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 225;
            // 
            // profissaoDataGridViewTextBoxColumn
            // 
            profissaoDataGridViewTextBoxColumn.DataPropertyName = "Profissao";
            profissaoDataGridViewTextBoxColumn.HeaderText = "Profissao";
            profissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            profissaoDataGridViewTextBoxColumn.Name = "profissaoDataGridViewTextBoxColumn";
            profissaoDataGridViewTextBoxColumn.ReadOnly = true;
            profissaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 165;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.ReadOnly = true;
            salarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            ativoDataGridViewCheckBoxColumn.Width = 50;
            // 
            // funcionarioBindingSource
            // 
            funcionarioBindingSource.DataSource = typeof(Models.Funcionario);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(580, 310);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(80, 22);
            buttonSelecionar.TabIndex = 14;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(665, 310);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(66, 22);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(142, 47);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 16;
            label3.Text = "INSIRA AS INFORMAÇÕES:";
            // 
            // FormConsultaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(742, 342);
            Controls.Add(label3);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSelecionar);
            Controls.Add(funcionarioDataGridView);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaFuncionario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaFuncionario_Load;
            KeyDown += FormConsultaFuncionario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)funcionarioDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private BindingSource funcionarioBindingSource;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private Label label3;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}