namespace UIGestaoMercearia
{
    partial class FormConsultaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaVenda));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonBuscar = new Button();
            textBoxVenda = new TextBox();
            comboBoxVenda = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            bindingSourceVenda = new BindingSource(components);
            vendaBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonExcluir);
            panel1.Controls.Add(buttonInserir);
            panel1.Controls.Add(buttonAlterar);
            panel1.Controls.Add(buttonBuscar);
            panel1.Controls.Add(textBoxVenda);
            panel1.Controls.Add(comboBoxVenda);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 165);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(302, 100);
            label3.Name = "label3";
            label3.Size = new Size(201, 18);
            label3.TabIndex = 8;
            label3.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 7;
            label2.Text = "BUSCAR POR:";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluir.Location = new Point(1008, 121);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInserir.Location = new Point(908, 121);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 5;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterar.Location = new Point(807, 121);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscar.Location = new Point(707, 121);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxVenda
            // 
            textBoxVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxVenda.Location = new Point(301, 123);
            textBoxVenda.Name = "textBoxVenda";
            textBoxVenda.Size = new Size(394, 27);
            textBoxVenda.TabIndex = 2;
            textBoxVenda.TextChanged += textBoxVenda_TextChanged;
            // 
            // comboBoxVenda
            // 
            comboBoxVenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxVenda.FormattingEnabled = true;
            comboBoxVenda.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxVenda.Location = new Point(12, 123);
            comboBoxVenda.Name = "comboBoxVenda";
            comboBoxVenda.Size = new Size(283, 28);
            comboBoxVenda.TabIndex = 1;
            comboBoxVenda.SelectedIndexChanged += comboBoxVenda_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(362, 22);
            label1.Name = "label1";
            label1.Size = new Size(409, 44);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA DE VENDAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 76);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(290, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(0, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1105, 338);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "IdFuncionario";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "IdCliente";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 140;
            // 
            // Column5
            // 
            Column5.HeaderText = "IdProduto";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.HeaderText = "Forma de Pagamento";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "DataVenda";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 140;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(890, 501);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(103, 29);
            buttonSelecionar.TabIndex = 10;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(999, 501);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.DataSource = typeof(Models.Venda);
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // FormConsultaVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1105, 536);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaVenda";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxVenda;
        private TextBox textBoxVenda;
        private Label label3;
        private Label label2;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button buttonSelecionar;
        private Button buttonCancelar;
        private BindingSource bindingSourceVenda;
        private BindingSource vendaBindingSource;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}