﻿using System;
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
            components = new System.ComponentModel.Container();
            produtoBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBoxNome = new TextBox();
            label3 = new Label();
            textBoxDescricao = new TextBox();
            label6 = new Label();
            textBoxCodigoDeBarra = new TextBox();
            label7 = new Label();
            textBoxPreco = new TextBox();
            buttonSalvar = new Button();
            textBoxQtdEstoque = new TextBox();
            buttonCancelar = new Button();
            textBoxNomeFornecedor = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBoxNomeMarca = new TextBox();
            label4 = new Label();
            buttonBuscarFornecedor = new Button();
            buttonBuscarMarca = new Button();
            textBoxNomeCategoria = new TextBox();
            label5 = new Label();
            buttonBuscarCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Models.Produto);
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(705, 49);
            label1.TabIndex = 12;
            label1.Text = "CADASTRO DE PRODUTO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 13;
            label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.DataBindings.Add(new Binding("Text", produtoBindingSource, "Nome", true));
            textBoxNome.Location = new Point(12, 84);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(409, 27);
            textBoxNome.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(236, 163);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 15;
            label3.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Cursor = Cursors.IBeam;
            textBoxDescricao.DataBindings.Add(new Binding("Text", produtoBindingSource, "Preco", true));
            textBoxDescricao.Location = new Point(12, 137);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(152, 27);
            textBoxDescricao.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(236, 110);
            label6.Name = "label6";
            label6.Size = new Size(139, 18);
            label6.TabIndex = 21;
            label6.Text = "Codigo de barra";
            // 
            // textBoxCodigoDeBarra
            // 
            textBoxCodigoDeBarra.Cursor = Cursors.IBeam;
            textBoxCodigoDeBarra.DataBindings.Add(new Binding("Text", produtoBindingSource, "CodigoDeBarra", true));
            textBoxCodigoDeBarra.Location = new Point(236, 133);
            textBoxCodigoDeBarra.Name = "textBoxCodigoDeBarra";
            textBoxCodigoDeBarra.Size = new Size(423, 27);
            textBoxCodigoDeBarra.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 114);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 23;
            label7.Text = "Preço";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Cursor = Cursors.IBeam;
            textBoxPreco.DataBindings.Add(new Binding("Text", produtoBindingSource, "Descricao", true));
            textBoxPreco.Location = new Point(236, 187);
            textBoxPreco.Multiline = true;
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(423, 78);
            textBoxPreco.TabIndex = 24;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Azure;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(485, 316);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 28;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxQtdEstoque
            // 
            textBoxQtdEstoque.Cursor = Cursors.IBeam;
            textBoxQtdEstoque.DataBindings.Add(new Binding("Text", produtoBindingSource, "Quantidade", true));
            textBoxQtdEstoque.Location = new Point(427, 84);
            textBoxQtdEstoque.Name = "textBoxQtdEstoque";
            textBoxQtdEstoque.Size = new Size(232, 27);
            textBoxQtdEstoque.TabIndex = 27;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Azure;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = SystemColors.ControlText;
            buttonCancelar.Location = new Point(585, 316);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 28;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Cursor = Cursors.IBeam;
            textBoxNomeFornecedor.DataBindings.Add(new Binding("Text", produtoBindingSource, "NomeFornecedor", true));
            textBoxNomeFornecedor.Location = new Point(12, 186);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(152, 27);
            textBoxNomeFornecedor.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 163);
            label9.Name = "label9";
            label9.Size = new Size(101, 18);
            label9.TabIndex = 30;
            label9.Text = "Fornecedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(427, 61);
            label8.Name = "label8";
            label8.Size = new Size(101, 18);
            label8.TabIndex = 25;
            label8.Text = "Quantidade";
            // 
            // textBoxNomeMarca
            // 
            textBoxNomeMarca.Cursor = Cursors.IBeam;
            textBoxNomeMarca.DataBindings.Add(new Binding("Text", produtoBindingSource, "NomeMarca", true));
            textBoxNomeMarca.Location = new Point(12, 235);
            textBoxNomeMarca.Name = "textBoxNomeMarca";
            textBoxNomeMarca.Size = new Size(152, 27);
            textBoxNomeMarca.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 32;
            label4.Text = "Marca";
            // 
            // buttonBuscarFornecedor
            // 
            buttonBuscarFornecedor.Location = new Point(170, 186);
            buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            buttonBuscarFornecedor.Size = new Size(29, 29);
            buttonBuscarFornecedor.TabIndex = 33;
            buttonBuscarFornecedor.Text = "...";
            buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            buttonBuscarFornecedor.Click += buttonBuscarFornecedor_Click;
            // 
            // buttonBuscarMarca
            // 
            buttonBuscarMarca.Location = new Point(170, 235);
            buttonBuscarMarca.Name = "buttonBuscarMarca";
            buttonBuscarMarca.Size = new Size(29, 29);
            buttonBuscarMarca.TabIndex = 33;
            buttonBuscarMarca.Text = "...";
            buttonBuscarMarca.UseVisualStyleBackColor = true;
            buttonBuscarMarca.Click += buttonBuscarMarca_Click;
            // 
            // textBoxNomeCategoria
            // 
            textBoxNomeCategoria.DataBindings.Add(new Binding("Text", produtoBindingSource, "NomeCategoria", true));
            textBoxNomeCategoria.Location = new Point(12, 285);
            textBoxNomeCategoria.Name = "textBoxNomeCategoria";
            textBoxNomeCategoria.Size = new Size(152, 27);
            textBoxNomeCategoria.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(88, 18);
            label5.TabIndex = 35;
            label5.Text = "Categoria";
            // 
            // buttonBuscarCategoria
            // 
            buttonBuscarCategoria.Location = new Point(170, 283);
            buttonBuscarCategoria.Name = "buttonBuscarCategoria";
            buttonBuscarCategoria.Size = new Size(29, 29);
            buttonBuscarCategoria.TabIndex = 33;
            buttonBuscarCategoria.Text = "...";
            buttonBuscarCategoria.UseVisualStyleBackColor = true;
            buttonBuscarCategoria.Click += buttonBuscarCategoria_Click;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(705, 359);
            Controls.Add(label5);
            Controls.Add(textBoxNomeCategoria);
            Controls.Add(buttonBuscarCategoria);
            Controls.Add(buttonBuscarMarca);
            Controls.Add(buttonBuscarFornecedor);
            Controls.Add(label4);
            Controls.Add(textBoxNomeMarca);
            Controls.Add(label9);
            Controls.Add(textBoxNomeFornecedor);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxQtdEstoque);
            Controls.Add(label8);
            Controls.Add(textBoxPreco);
            Controls.Add(label7);
            Controls.Add(textBoxCodigoDeBarra);
            Controls.Add(label6);
            Controls.Add(textBoxDescricao);
            Controls.Add(label3);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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