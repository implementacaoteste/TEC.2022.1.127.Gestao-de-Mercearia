namespace UIGestaoMercearia
{
    partial class FormeCadastroEstoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxQtdEstoque = new System.Windows.Forms.TextBox();
            this.textBoxEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.textBoxDataEntrada = new System.Windows.Forms.TextBox();
            this.textBoxEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.bindingSourceEstoque = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO ESTOQUE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 75);
            this.panel1.TabIndex = 1;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(41, 121);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(215, 27);
            this.textBoxNomeProduto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(354, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data de Entrada:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(354, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Saída:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEstoque, "DatadeSaida", true));
            this.textBox2.Location = new System.Drawing.Point(354, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 27);
            this.textBox2.TabIndex = 7;
            // 
            // textBoxQtdEstoque
            // 
            this.textBoxQtdEstoque.Location = new System.Drawing.Point(41, 206);
            this.textBoxQtdEstoque.Name = "textBoxQtdEstoque";
            this.textBoxQtdEstoque.Size = new System.Drawing.Size(215, 27);
            this.textBoxQtdEstoque.TabIndex = 8;
            // 
            // textBoxEstoqueMaximo
            // 
            this.textBoxEstoqueMaximo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEstoque, "EstoqueMaximo", true));
            this.textBoxEstoqueMaximo.Location = new System.Drawing.Point(41, 293);
            this.textBoxEstoqueMaximo.Name = "textBoxEstoqueMaximo";
            this.textBoxEstoqueMaximo.Size = new System.Drawing.Size(216, 27);
            this.textBoxEstoqueMaximo.TabIndex = 9;
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEstoque, "DatadeEntrada", true));
            this.textBoxDataEntrada.Location = new System.Drawing.Point(354, 206);
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(216, 27);
            this.textBoxDataEntrada.TabIndex = 10;
            // 
            // textBoxEstoqueMinimo
            // 
            this.textBoxEstoqueMinimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEstoque, "EstoqueMinimo", true));
            this.textBoxEstoqueMinimo.Location = new System.Drawing.Point(354, 293);
            this.textBoxEstoqueMinimo.Name = "textBoxEstoqueMinimo";
            this.textBoxEstoqueMinimo.Size = new System.Drawing.Size(215, 27);
            this.textBoxEstoqueMinimo.TabIndex = 11;
            this.textBoxEstoqueMinimo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(41, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estoque Máximo";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(354, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id do Produto";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(41, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantidade em Estoque";
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.Location = new System.Drawing.Point(262, 119);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(36, 29);
            this.buttonBuscarProduto.TabIndex = 17;
            this.buttonBuscarProduto.Text = "...";
            this.buttonBuscarProduto.UseVisualStyleBackColor = true;
            this.buttonBuscarProduto.Click += new System.EventHandler(this.buttonBuscarProduto_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(418, 350);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(518, 350);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // bindingSourceEstoque
            // 
            this.bindingSourceEstoque.DataSource = typeof(Models.Estoque);
            // 
            // FormeCadastroEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(155)))), ((int)(((byte)(205)))));
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBuscarProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEstoqueMinimo);
            this.Controls.Add(this.textBoxDataEntrada);
            this.Controls.Add(this.textBoxEstoqueMaximo);
            this.Controls.Add(this.textBoxQtdEstoque);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormeCadastroEstoque";
            this.ShowIcon = false;
//<<<<<<< Updated upstream
//=======
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//>>>>>>> Stashed changes
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBoxNomeProduto;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBoxQtdEstoque;
        private TextBox textBoxEstoqueMaximo;
        private TextBox textBoxDataEntrada;
        private TextBox textBoxEstoqueMinimo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonBuscarProduto;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private BindingSource bindingSourceEstoque;
    }
}