using System;
using System.Windows.Forms;
namespace UIGestaoMercearia
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

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
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxQtdEstoque = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNomeMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBuscarFornecedor = new System.Windows.Forms.Button();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.textBoxNomeCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Models.Produto);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 61);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 84);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(409, 27);
            this.textBoxNome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(236, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Preco", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(12, 137);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(152, 27);
            this.textBoxDescricao.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(236, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codigo de barra";
            // 
            // textBoxCodigoDeBarra
            // 
            this.textBoxCodigoDeBarra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCodigoDeBarra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "CodigoDeBarra", true));
            this.textBoxCodigoDeBarra.Location = new System.Drawing.Point(236, 133);
            this.textBoxCodigoDeBarra.Name = "textBoxCodigoDeBarra";
            this.textBoxCodigoDeBarra.Size = new System.Drawing.Size(423, 27);
            this.textBoxCodigoDeBarra.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Preço";
            
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Descricao", true));
            this.textBoxPreco.Location = new System.Drawing.Point(236, 187);
            this.textBoxPreco.Multiline = true;
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(423, 78);
            this.textBoxPreco.TabIndex = 24;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Azure;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(465, 281);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxQtdEstoque
            // 
            this.textBoxQtdEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQtdEstoque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Quantidade", true));
            this.textBoxQtdEstoque.Location = new System.Drawing.Point(427, 84);
            this.textBoxQtdEstoque.Name = "textBoxQtdEstoque";
            this.textBoxQtdEstoque.Size = new System.Drawing.Size(232, 27);
            this.textBoxQtdEstoque.TabIndex = 27;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Azure;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Location = new System.Drawing.Point(565, 281);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 28;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNomeFornecedor
            // 
            this.textBoxNomeFornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNomeFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "NomeFornecedor", true));
            this.textBoxNomeFornecedor.Location = new System.Drawing.Point(12, 186);
            this.textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            this.textBoxNomeFornecedor.Size = new System.Drawing.Size(152, 27);
            this.textBoxNomeFornecedor.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fornecedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(427, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quantidade";
            // 
            // textBoxNomeMarca
            // 
            this.textBoxNomeMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNomeMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "NomeMarca", true));
            this.textBoxNomeMarca.Location = new System.Drawing.Point(12, 235);
            this.textBoxNomeMarca.Name = "textBoxNomeMarca";
            this.textBoxNomeMarca.Size = new System.Drawing.Size(152, 27);
            this.textBoxNomeMarca.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Marca";
            // 
            // buttonBuscarFornecedor
            // 
            this.buttonBuscarFornecedor.Location = new System.Drawing.Point(170, 186);
            this.buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            this.buttonBuscarFornecedor.Size = new System.Drawing.Size(29, 29);
            this.buttonBuscarFornecedor.TabIndex = 33;
            this.buttonBuscarFornecedor.Text = "...";
            this.buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            this.buttonBuscarFornecedor.Click += new System.EventHandler(this.buttonBuscarFornecedor_Click);
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.Location = new System.Drawing.Point(170, 235);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(29, 29);
            this.buttonBuscarMarca.TabIndex = 33;
            this.buttonBuscarMarca.Text = "...";
            this.buttonBuscarMarca.UseVisualStyleBackColor = true;
            this.buttonBuscarMarca.Click += new System.EventHandler(this.buttonBuscarMarca_Click);
            // 
            // textBoxNomeCategoria
            // 
            this.textBoxNomeCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "NomeCategoria", true));
            this.textBoxNomeCategoria.Location = new System.Drawing.Point(12, 285);
            this.textBoxNomeCategoria.Name = "textBoxNomeCategoria";
            this.textBoxNomeCategoria.Size = new System.Drawing.Size(152, 27);
            this.textBoxNomeCategoria.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Categoria";
            // 
            // buttonBuscarCategoria
            // 
            this.buttonBuscarCategoria.Location = new System.Drawing.Point(170, 283);
            this.buttonBuscarCategoria.Name = "buttonBuscarCategoria";
            this.buttonBuscarCategoria.Size = new System.Drawing.Size(29, 29);
            this.buttonBuscarCategoria.TabIndex = 33;
            this.buttonBuscarCategoria.Text = "...";
            this.buttonBuscarCategoria.UseVisualStyleBackColor = true;
            this.buttonBuscarCategoria.Click += new System.EventHandler(this.buttonBuscarCategoria_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(672, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNomeCategoria);
            this.Controls.Add(this.buttonBuscarCategoria);
            this.Controls.Add(this.buttonBuscarMarca);
            this.Controls.Add(this.buttonBuscarFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomeMarca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNomeFornecedor);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxQtdEstoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCodigoDeBarra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource produtoBindingSource;
        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxDescricao;
        private Label label6;
        private TextBox textBoxCodigoDeBarra;
        private Label label7;
        private TextBox textBoxPreco;
        private Button buttonSalvar;
        private TextBox textBoxQtdEstoque;
        private Button buttonCancelar;
        private TextBox textBoxNomeFornecedor;
        private Label label9;
        private Label label8;
        private TextBox textBoxNomeMarca;
        private Label label4;
        private Button buttonBuscarFornecedor;
        private Button buttonBuscarMarca;
        private TextBox textBoxNomeCategoria;
        private Label label5;
        private Button buttonBuscarCategoria;

        public int ComboBoxProdutos_SelectedIndexChanged { get; private set; }
    }
}