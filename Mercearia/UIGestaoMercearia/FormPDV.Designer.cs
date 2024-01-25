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
            textBoxNomeProduto = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAtualizar = new Button();
            buttonClear = new Button();
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            bindingSourcePDV = new BindingSource(components);
            label4 = new Label();
            labelSubTT = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePDV).BeginInit();
            SuspendLayout();
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(34, 78);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(186, 27);
            textBoxNomeProduto.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 55);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 134);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor Unitário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 199);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantidade";
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.FlatStyle = FlatStyle.Flat;
            buttonAtualizar.Location = new Point(26, 283);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(94, 29);
            buttonAtualizar.TabIndex = 4;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonClear
            // 
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = SystemColors.ActiveCaptionText;
            buttonClear.Location = new Point(126, 283);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Resetar";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, idProdutoDataGridViewTextBoxColumn, idVendaDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, valorUnitarioDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSourcePDV;
            dataGridView1.Location = new Point(272, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(680, 375);
            dataGridView1.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(226, 78);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(29, 27);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "...";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // bindingSourcePDV
            // 
            bindingSourcePDV.DataSource = typeof(Models.ItemVenda);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(447, 459);
            label4.Name = "label4";
            label4.Size = new Size(112, 44);
            label4.TabIndex = 7;
            label4.Text = "Total:";
            // 
            // labelSubTT
            // 
            labelSubTT.AutoSize = true;
            labelSubTT.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubTT.Location = new Point(554, 464);
            labelSubTT.Name = "labelSubTT";
            labelSubTT.Size = new Size(34, 37);
            labelSubTT.TabIndex = 8;
            labelSubTT.Text = "0";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            idProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            idVendaDataGridViewTextBoxColumn.DataPropertyName = "IdVenda";
            idVendaDataGridViewTextBoxColumn.HeaderText = "IdVenda";
            idVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            valorUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            subTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormPDV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClear;
            ClientSize = new Size(964, 531);
            Controls.Add(labelSubTT);
            Controls.Add(label4);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Controls.Add(buttonClear);
            Controls.Add(buttonAtualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBoxNomeProduto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPDV";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormPDV_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomeProduto;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAtualizar;
        private Button buttonClear;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private BindingSource bindingSourcePDV;
        private Label label4;
        private Label labelSubTT;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
    }
}