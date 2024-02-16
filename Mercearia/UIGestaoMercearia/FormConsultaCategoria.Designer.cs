namespace UIGestaoMercearia
{
    partial class FormConsultaCategoria
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
            panel1 = new Panel();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonBuscar = new Button();
            textBoxBuscarPor = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            dataGridViewCategoria = new DataGridView();
            bindingSourceCategoria = new BindingSource(components);
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            panel3 = new Panel();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategoria).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 83);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 83);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(50, 153, 204);
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Dock = DockStyle.Top;
            label7.Enabled = false;
            label7.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(579, 61);
            label7.TabIndex = 10;
            label7.Text = "INSIRA A INFORMAÇÃO";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 18);
            label4.Name = "label4";
            label4.Size = new Size(423, 44);
            label4.TabIndex = 9;
            label4.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 18);
            label3.Name = "label3";
            label3.Size = new Size(423, 44);
            label3.TabIndex = 9;
            label3.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(50, 153, 204);
            label2.Location = new Point(156, 95);
            label2.Name = "label2";
            label2.Size = new Size(201, 18);
            label2.TabIndex = 4;
            label2.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 153, 204);
            label1.Location = new Point(14, 95);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 3;
            label1.Text = "BUSCAR POR:";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ButtonHighlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Location = new Point(471, 118);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscarPor.Cursor = Cursors.IBeam;
            textBoxBuscarPor.Location = new Point(156, 120);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(309, 27);
            textBoxBuscarPor.TabIndex = 1;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(14, 118);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(136, 28);
            comboBoxBuscarPor.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = SystemColors.ButtonHighlight;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Location = new Point(317, 8);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(96, 29);
            buttonExcluir.TabIndex = 2;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.BackColor = SystemColors.ButtonHighlight;
            buttonInserir.FlatStyle = FlatStyle.Flat;
            buttonInserir.Location = new Point(113, 8);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(96, 29);
            buttonInserir.TabIndex = 2;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = false;
            buttonInserir.Click += buttonInserir_Click_1;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = SystemColors.ButtonHighlight;
            buttonAlterar.FlatStyle = FlatStyle.Flat;
            buttonAlterar.Location = new Point(215, 8);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(96, 29);
            buttonAlterar.TabIndex = 2;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click_1;
            // 
            // dataGridViewCategoria
            // 
            dataGridViewCategoria.AllowUserToAddRows = false;
            dataGridViewCategoria.AllowUserToDeleteRows = false;
            dataGridViewCategoria.AllowUserToOrderColumns = true;
            dataGridViewCategoria.AutoGenerateColumns = false;
            dataGridViewCategoria.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoria.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1 });
            dataGridViewCategoria.DataSource = bindingSourceCategoria;
            dataGridViewCategoria.Location = new Point(12, 151);
            dataGridViewCategoria.Name = "dataGridViewCategoria";
            dataGridViewCategoria.ReadOnly = true;
            dataGridViewCategoria.RowHeadersWidth = 51;
            dataGridViewCategoria.RowTemplate.Height = 29;
            dataGridViewCategoria.Size = new Size(553, 387);
            dataGridViewCategoria.TabIndex = 7;
            dataGridViewCategoria.DoubleClick += dataGridViewCategoria_DoubleClick;
            // 
            // bindingSourceCategoria
            // 
            bindingSourceCategoria.DataSource = typeof(Models.Categoria);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.BackColor = SystemColors.ButtonHighlight;
            buttonSelecionar.Location = new Point(11, 8);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(96, 29);
            buttonSelecionar.TabIndex = 1;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = false;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(469, 8);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(96, 29);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(buttonInserir);
            panel3.Controls.Add(buttonCancelar);
            panel3.Controls.Add(buttonExcluir);
            panel3.Controls.Add(buttonSelecionar);
            panel3.Controls.Add(buttonAlterar);
            panel3.Location = new Point(0, 544);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 50);
            panel3.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 180;
            // 
            // FormConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            CancelButton = buttonCancelar;
            ClientSize = new Size(579, 593);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(panel2);
            Controls.Add(dataGridViewCategoria);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaCategoria";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaCategoria_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategoria).EndInit();
            panel3.ResumeLayout(false);
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
        private DataGridView dataGridViewCategoria;
        private BindingSource bindingSourceCategoria;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Label label2;
        private Label label1;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label label7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}