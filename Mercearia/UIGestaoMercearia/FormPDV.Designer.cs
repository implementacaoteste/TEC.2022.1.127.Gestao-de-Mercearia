﻿
namespace UIGestaoMercearia
{
    partial class FormPDV
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
            textBoxCodigoDeBarras = new TextBox();
            textBox2 = new TextBox();
            textBoxQuantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            bindingSourcePDV = new BindingSource(components);
            bindingSourceVenda = new BindingSource(components);
            buttonAdd = new Button();
            label4 = new Label();
            labelSubTT = new Label();
            buttonConcluir = new Button();
            NomeProduto = new DataGridViewTextBoxColumn();
            IdVenda = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ValorUnitario = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).BeginInit();
            SuspendLayout();
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.Location = new Point(34, 77);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(186, 27);
            textBoxCodigoDeBarras.TabIndex = 1;
            textBoxCodigoDeBarras.TextChanged += textBoxCodigoDeBarras_TextChanged;
            textBoxCodigoDeBarras.KeyDown += textBoxCodigoDeBarras_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(33, 152);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(187, 27);
            textBoxQuantidade.TabIndex = 4;
            textBoxQuantidade.Text = "1";
            textBoxQuantidade.TextChanged += textBoxQuantidade_TextChanged;
            textBoxQuantidade.KeyDown += textBoxQuantidade_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 55);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 199);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 5;
            label2.Text = "Valor Unitário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NomeProduto, IdVenda, Quantidade, ValorUnitario, SubTotal, Produto, dataGridViewTextBoxColumn1, idDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSourcePDV;
            dataGridView1.Location = new Point(272, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(680, 375);
            dataGridView1.TabIndex = 9;
            // 
            // bindingSourcePDV
            // 
            bindingSourcePDV.DataMember = "itemVendaList";
            bindingSourcePDV.DataSource = bindingSourceVenda;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.DataSource = typeof(Models.Venda);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(226, 77);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(29, 27);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "...";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(447, 459);
            label4.Name = "label4";
            label4.Size = new Size(112, 44);
            label4.TabIndex = 10;
            label4.Text = "Total:";
            // 
            // labelSubTT
            // 
            labelSubTT.AutoSize = true;
            labelSubTT.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubTT.Location = new Point(554, 464);
            labelSubTT.Name = "labelSubTT";
            labelSubTT.Size = new Size(34, 37);
            labelSubTT.TabIndex = 11;
            labelSubTT.Text = "0";
            labelSubTT.Click += labelSubTT_Click;
            // 
            // buttonConcluir
            // 
            buttonConcluir.FlatStyle = FlatStyle.Flat;
            buttonConcluir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConcluir.Location = new Point(829, 473);
            buttonConcluir.Name = "buttonConcluir";
            buttonConcluir.Size = new Size(123, 43);
            buttonConcluir.TabIndex = 12;
            buttonConcluir.Text = "Concluir";
            buttonConcluir.UseVisualStyleBackColor = true;
            buttonConcluir.Click += buttonConcluir_Click;
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "NomeProduto";
            NomeProduto.HeaderText = "Produto";
            NomeProduto.MinimumWidth = 6;
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            NomeProduto.Width = 200;
            // 
            // IdVenda
            // 
            IdVenda.DataPropertyName = "IdVenda";
            IdVenda.HeaderText = "IdVenda";
            IdVenda.MinimumWidth = 6;
            IdVenda.Name = "IdVenda";
            IdVenda.ReadOnly = true;
            IdVenda.Width = 125;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 125;
            // 
            // ValorUnitario
            // 
            ValorUnitario.DataPropertyName = "ValorUnitario";
            ValorUnitario.HeaderText = "ValorUnitario";
            ValorUnitario.MinimumWidth = 6;
            ValorUnitario.Name = "ValorUnitario";
            ValorUnitario.ReadOnly = true;
            ValorUnitario.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 125;
            // 
            // Produto
            // 
            Produto.DataPropertyName = "Produto";
            Produto.HeaderText = "Produto";
            Produto.MinimumWidth = 6;
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            Produto.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NomeProduto";
            dataGridViewTextBoxColumn1.HeaderText = "NomeProduto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormPDV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 531);
            Controls.Add(buttonConcluir);
            Controls.Add(labelSubTT);
            Controls.Add(label4);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBox2);
            Controls.Add(textBoxCodigoDeBarras);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPDV";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormPDV_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxCodigoDeBarras;
        private TextBox textBox2;
        private TextBox textBoxQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private BindingSource bindingSourcePDV;
        private Label label4;
        private Label labelSubTT;
        private Button buttonConcluir;
        private BindingSource bindingSourceVenda;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn IdVenda;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}