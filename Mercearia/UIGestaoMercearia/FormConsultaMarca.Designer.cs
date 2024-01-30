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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            buttonBuscar = new Button();
            textBoxBuscarPor = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            dataGridViewMarca = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSourceMarca = new BindingSource(components);
            labelGerenProd = new Label();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMarca).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelGerenProd);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 75);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(150, 87);
            label2.Name = "label2";
            label2.Size = new Size(201, 18);
            label2.TabIndex = 3;
            label2.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 3;
            label1.Text = "BUSCAR POR";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ButtonHighlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Location = new Point(449, 109);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(107, 29);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(150, 111);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(293, 27);
            textBoxBuscarPor.TabIndex = 1;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(14, 110);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(131, 28);
            comboBoxBuscarPor.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = SystemColors.ButtonHighlight;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Location = new Point(235, 530);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 2;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.BackColor = SystemColors.ButtonHighlight;
            buttonInserir.FlatStyle = FlatStyle.Flat;
            buttonInserir.Location = new Point(124, 530);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 2;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = false;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = SystemColors.ButtonHighlight;
            buttonAlterar.FlatStyle = FlatStyle.Flat;
            buttonAlterar.Location = new Point(14, 530);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 2;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // dataGridViewMarca
            // 
            dataGridViewMarca.AllowUserToAddRows = false;
            dataGridViewMarca.AllowUserToDeleteRows = false;
            dataGridViewMarca.AllowUserToOrderColumns = true;
            dataGridViewMarca.AutoGenerateColumns = false;
            dataGridViewMarca.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarca.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn });
            dataGridViewMarca.DataSource = bindingSourceMarca;
            dataGridViewMarca.Location = new Point(13, 144);
            dataGridViewMarca.Name = "dataGridViewMarca";
            dataGridViewMarca.ReadOnly = true;
            dataGridViewMarca.RowHeadersWidth = 51;
            dataGridViewMarca.RowTemplate.Height = 29;
            dataGridViewMarca.Size = new Size(543, 380);
            dataGridViewMarca.TabIndex = 10;
            dataGridViewMarca.DoubleClick += dataGridViewMarca_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 350;
            // 
            // bindingSourceMarca
            // 
            bindingSourceMarca.DataSource = typeof(Models.Marca);
            // 
            // labelGerenProd
            // 
            labelGerenProd.AutoSize = true;
            labelGerenProd.BackColor = Color.Transparent;
            labelGerenProd.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelGerenProd.ForeColor = Color.FromArgb(50, 153, 204);
            labelGerenProd.Location = new Point(46, 18);
            labelGerenProd.Name = "labelGerenProd";
            labelGerenProd.Size = new Size(480, 44);
            labelGerenProd.TabIndex = 0;
            labelGerenProd.Text = "Gerenciamento de Marcas";
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.BackColor = SystemColors.ButtonHighlight;
            buttonSelecionar.FlatStyle = FlatStyle.Flat;
            buttonSelecionar.Location = new Point(348, 530);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 1;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = false;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(462, 530);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormConsultaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(568, 574);
            Controls.Add(buttonCancelar);
            Controls.Add(label2);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonAlterar);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonInserir);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonExcluir);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(panel2);
            Controls.Add(dataGridViewMarca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaMarca";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaMarca_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label labelGerenProd;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Label label2;
        private Label label1;
        private Button buttonSelecionar;
        private Button buttonCancelar;
    }
}