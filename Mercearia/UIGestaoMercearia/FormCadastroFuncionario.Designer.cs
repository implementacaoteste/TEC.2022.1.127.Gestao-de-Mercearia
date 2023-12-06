namespace UIGestaoMercearia
{
    partial class FormCadastroFuncionario
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSourceCadastrarFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFuncionario)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(631, 61);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Funcionario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFuncionario, "Nome", true));
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 27);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bindingSourceCadastrarFuncionario
            // 
            this.bindingSourceCadastrarFuncionario.DataSource = typeof(Models.Funcionario);
            this.bindingSourceCadastrarFuncionario.CurrentChanged += new System.EventHandler(this.bindingSourceCadastrarFuncionario_CurrentChanged);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFuncionario, "Telefone", true));
            this.textBox2.Location = new System.Drawing.Point(335, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 27);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(335, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Profissão";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFuncionario, "Profissao", true));
            this.textBox3.Location = new System.Drawing.Point(12, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(360, 27);
            this.textBox3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Salario";
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFuncionario, "Salario", true));
            this.textBox4.Location = new System.Drawing.Point(12, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 27);
            this.textBox4.TabIndex = 24;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCadastrarFuncionario, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ativoCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ativoCheckBox.Location = new System.Drawing.Point(562, 156);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(69, 24);
            this.ativoCheckBox.TabIndex = 26;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(429, 276);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 27;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(529, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(631, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroFuncionario";
            this.Text = "FormCadastroFuncionario";
            this.Load += new System.EventHandler(this.FormCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private CheckBox ativoCheckBox;
        private Button buttonSalvar;
        private Button button2;
        private BindingSource bindingSourceCadastrarFuncionario;
    }
}