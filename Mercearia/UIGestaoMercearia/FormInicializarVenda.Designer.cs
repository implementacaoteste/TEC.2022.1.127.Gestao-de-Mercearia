namespace UIGestaoMercearia
{
    partial class FormInicializarVenda
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            bindingSourceVenda = new BindingSource(components);
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label12 = new Label();
            textBoxCodigodeBarras = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(588, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 44);
            label1.TabIndex = 0;
            label1.Text = "INICIAR VENDA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(352, 10);
            label2.Name = "label2";
            label2.Size = new Size(377, 47);
            label2.TabIndex = 1;
            label2.Text = "Nome do Produto";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(407, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 73);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(404, 827);
            panel3.Name = "panel3";
            panel3.Size = new Size(1062, 126);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(48, 17);
            label10.Name = "label10";
            label10.Size = new Size(69, 28);
            label10.TabIndex = 5;
            label10.Text = "Troco:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(48, 45);
            label8.Name = "label8";
            label8.Size = new Size(232, 59);
            label8.TabIndex = 4;
            label8.Text = "1.000,00";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(929, 17);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 3;
            label4.Text = "Subtotal:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(806, 45);
            label3.Name = "label3";
            label3.Size = new Size(232, 59);
            label3.TabIndex = 2;
            label3.Text = "1.000,00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(736, 724);
            label11.Name = "label11";
            label11.Size = new Size(194, 28);
            label11.TabIndex = 13;
            label11.Text = "CÓDIGO DE BARRA";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(454, 695);
            label5.Name = "label5";
            label5.Size = new Size(200, 31);
            label5.TabIndex = 4;
            label5.Text = "PREÇO UNITÁRIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(454, 140);
            label6.Name = "label6";
            label6.Size = new Size(163, 31);
            label6.TabIndex = 5;
            label6.Text = "QUANTIDADE";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1230, 146);
            label7.Name = "label7";
            label7.Size = new Size(155, 31);
            label7.TabIndex = 6;
            label7.Text = "VALOR PAGO";
            label7.Click += label7_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.LimeGreen;
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvar.ForeColor = SystemColors.ButtonHighlight;
            buttonSalvar.Location = new Point(1280, 763);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(147, 42);
            buttonSalvar.TabIndex = 8;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextAlign = ContentAlignment.TopCenter;
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.Red;
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ButtonHighlight;
            buttonCancelar.Location = new Point(1127, 763);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(147, 42);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Location = new Point(3, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 889);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(454, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(973, 408);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.CurrentChanged += bindingSourceVenda_CurrentChanged_1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(454, 724);
            label9.Name = "label9";
            label9.Size = new Size(191, 81);
            label9.TabIndex = 14;
            label9.Text = "100,0";
            label9.Click += label9_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(454, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 87);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(1186, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 87);
            textBox2.TabIndex = 16;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(846, 146);
            label12.Name = "label12";
            label12.Size = new Size(219, 31);
            label12.TabIndex = 18;
            label12.Text = "CÓDIGO DE BARRA";
            label12.Click += label12_Click;
            // 
            // textBoxCodigodeBarras
            // 
            textBoxCodigodeBarras.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCodigodeBarras.Location = new Point(761, 177);
            textBoxCodigodeBarras.Name = "textBoxCodigodeBarras";
            textBoxCodigodeBarras.Size = new Size(303, 65);
            textBoxCodigodeBarras.TabIndex = 19;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1070, 179);
            button1.Name = "button1";
            button1.Size = new Size(68, 63);
            button1.TabIndex = 20;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.KeyDown += button1_KeyDown;
            // 
            // FormInicializarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1466, 954);
            Controls.Add(button1);
            Controls.Add(textBoxCodigodeBarras);
            Controls.Add(label12);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInicializarVenda";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormInicializarVenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label label11;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private BindingSource bindingSourceVenda;
        private EventHandler bindingSourceVenda_CurrentChanged;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label10;
        private Label label8;
        private Label label12;
        private TextBox textBoxCodigodeBarras;
        private Button button1;
    }
}