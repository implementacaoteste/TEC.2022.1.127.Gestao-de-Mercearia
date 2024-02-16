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
            DataVenda = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            IdFormaPagamento = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bindingSourceVenda = new BindingSource(components);
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 124);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(264, 75);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 8;
            label3.Text = "INSIRA A INFORMAÇÃO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 75);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 7;
            label2.Text = "BUSCAR POR:";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluir.Location = new Point(882, 91);
            buttonExcluir.Margin = new Padding(3, 2, 3, 2);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(82, 22);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInserir.Location = new Point(794, 91);
            buttonInserir.Margin = new Padding(3, 2, 3, 2);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(82, 22);
            buttonInserir.TabIndex = 5;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterar.Location = new Point(706, 91);
            buttonAlterar.Margin = new Padding(3, 2, 3, 2);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(82, 22);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscar.Location = new Point(619, 91);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(82, 22);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxVenda
            // 
            textBoxVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxVenda.Location = new Point(263, 92);
            textBoxVenda.Margin = new Padding(3, 2, 3, 2);
            textBoxVenda.Name = "textBoxVenda";
            textBoxVenda.Size = new Size(345, 23);
            textBoxVenda.TabIndex = 2;
            // 
            // comboBoxVenda
            // 
            comboBoxVenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxVenda.FormattingEnabled = true;
            comboBoxVenda.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxVenda.Location = new Point(10, 92);
            comboBoxVenda.Margin = new Padding(3, 2, 3, 2);
            comboBoxVenda.Name = "comboBoxVenda";
            comboBoxVenda.Size = new Size(248, 23);
            comboBoxVenda.TabIndex = 1;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(317, 16);
            label1.Name = "label1";
            label1.Size = new Size(328, 36);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA DE VENDAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 58);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(254, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 40);
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataVenda, Total, IdFormaPagamento, IdUsuario, dataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = bindingSourceVenda;
            dataGridView1.Location = new Point(0, 118);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(967, 254);
            dataGridView1.TabIndex = 1;
            // 
            // DataVenda
            // 
            DataVenda.DataPropertyName = "DataVenda";
            DataVenda.HeaderText = "DataVenda";
            DataVenda.MinimumWidth = 6;
            DataVenda.Name = "DataVenda";
            DataVenda.ReadOnly = true;
            DataVenda.Width = 250;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // IdFormaPagamento
            // 
            IdFormaPagamento.DataPropertyName = "IdFormaPagamento";
            IdFormaPagamento.HeaderText = "IdFormaPagamento";
            IdFormaPagamento.MinimumWidth = 6;
            IdFormaPagamento.Name = "IdFormaPagamento";
            IdFormaPagamento.ReadOnly = true;
            IdFormaPagamento.Width = 175;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Width = 175;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.DataSource = typeof(Models.Venda);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(779, 376);
            buttonSelecionar.Margin = new Padding(3, 2, 3, 2);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(90, 22);
            buttonSelecionar.TabIndex = 10;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(874, 376);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 22);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // FormConsultaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(967, 402);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaVenda";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaVenda_Load;
            KeyDown += FormConsultaVenda_KeyDown;
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
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn IdFormaPagamento;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}