namespace UIGestaoMercearia
{
    partial class FormCadastroProduto
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
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQtdEstoque = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(671, 61);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 84);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(409, 27);
            this.textBoxNome.TabIndex = 14;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Models.Produto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(170, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(12, 137);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(152, 27);
            this.textBoxDescricao.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "Marca", true));
            this.textBoxMarca.Location = new System.Drawing.Point(12, 190);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(409, 27);
            this.textBoxMarca.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Categoria";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "Categoria", true));
            this.textBoxCategoria.Location = new System.Drawing.Point(12, 243);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(409, 27);
            this.textBoxCategoria.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(427, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codigo de barra";
            // 
            // textBoxCodigoDeBarra
            // 
            this.textBoxCodigoDeBarra.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "CodigoDeBarra", true));
            this.textBoxCodigoDeBarra.Location = new System.Drawing.Point(427, 84);
            this.textBoxCodigoDeBarra.Name = "textBoxCodigoDeBarra";
            this.textBoxCodigoDeBarra.Size = new System.Drawing.Size(232, 27);
            this.textBoxCodigoDeBarra.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "Preco", true));
            this.textBoxPreco.Location = new System.Drawing.Point(170, 137);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(489, 27);
            this.textBoxPreco.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(427, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quantidade em estoque";
            // 
            // textBoxQtdEstoque
            // 
            this.textBoxQtdEstoque.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "QuantidadeEmEstoque", true));
            this.textBoxQtdEstoque.Location = new System.Drawing.Point(427, 190);
            this.textBoxQtdEstoque.Name = "textBoxQtdEstoque";
            this.textBoxQtdEstoque.Size = new System.Drawing.Size(232, 27);
            this.textBoxQtdEstoque.TabIndex = 27;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Azure;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(451, 337);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtoBindingSource, "IdFornecedor", true));
            this.textBox1.Location = new System.Drawing.Point(12, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "IdFornecedor";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(551, 337);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 28;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(671, 378);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxQtdEstoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCodigoDeBarra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroProduto";
            this.Text = "FormCadastroProduto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxDescricao;
        private Label label4;
        private TextBox textBoxMarca;
        private Label label5;
        private TextBox textBoxCategoria;
        private Label label6;
        private TextBox textBoxCodigoDeBarra;
        private Label label7;
        private TextBox textBoxPreco;
        private Label label8;
        private TextBox textBoxQtdEstoque;
        private BindingSource produtoBindingSource;
        private Button buttonSalvar;
        private TextBox textBox1;
        private Label label9;
        private Button buttonCancelar;
    }
}