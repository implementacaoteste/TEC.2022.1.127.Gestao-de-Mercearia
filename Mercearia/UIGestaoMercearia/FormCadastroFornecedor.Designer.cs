namespace UIGestaoMercearia
{
    partial class FormCadastroFornecedor
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(563, 61);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de fornecedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 94);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(539, 27);
            this.textBoxNome.TabIndex = 15;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Email", true));
            this.textBoxEmail.Location = new System.Drawing.Point(288, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(263, 27);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(288, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail";
            // 
            // textBoxFone
            // 
            this.textBoxFone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Fone", true));
            this.textBoxFone.Location = new System.Drawing.Point(12, 147);
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(270, 27);
            this.textBoxFone.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "CEP";
            // 
            // textBoxCep
            // 
            this.textBoxCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "CEP", true));
            this.textBoxCep.Location = new System.Drawing.Point(12, 209);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(131, 27);
            this.textBoxCep.TabIndex = 21;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalvar.Location = new System.Drawing.Point(388, 290);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 29);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(469, 290);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 29);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Endereco", true));
            this.textBoxEndereco.Location = new System.Drawing.Point(149, 209);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(402, 27);
            this.textBoxEndereco.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(149, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bairro";
            // 
            // FormCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(563, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormCadastroFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxFone;
        private Label label5;
        private TextBox textBoxCep;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource fornecedorBindingSource;
        private TextBox textBoxEndereco;
        private Label label6;
    }
}