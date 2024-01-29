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
            labelNomeProduto = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            labelSubtotal = new Label();
            label6 = new Label();
            textBoxQuantidade = new TextBox();
            label7 = new Label();
            textBoxValorPago = new TextBox();
            textBoxCodigodeBarras = new TextBox();
            label11 = new Label();
            label5 = new Label();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            idVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemVendaListBindingSource = new BindingSource(components);
            bindingSourceVenda = new BindingSource(components);
            label12 = new Label();
            buttonBuscarProduto = new Button();
            labelpreco = new Label();
            labelTroco = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaListBindingSource).BeginInit();
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
            // labelNomeProduto
            // 
            labelNomeProduto.Anchor = AnchorStyles.Top;
            labelNomeProduto.AutoSize = true;
            labelNomeProduto.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeProduto.Location = new Point(352, 10);
            labelNomeProduto.Name = "labelNomeProduto";
            labelNomeProduto.Size = new Size(377, 47);
            labelNomeProduto.TabIndex = 1;
            labelNomeProduto.Text = "Nome do Produto";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(labelNomeProduto);
            panel2.Location = new Point(407, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 73);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(labelSubtotal);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxQuantidade);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBoxValorPago);
            panel3.Location = new Point(404, 803);
            panel3.Name = "panel3";
            panel3.Size = new Size(1062, 150);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(929, 17);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 3;
            label4.Text = "Subtotal:";
            // 
            // labelSubtotal
            // 
            labelSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSubtotal.AutoSize = true;
            labelSubtotal.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtotal.Location = new Point(834, 45);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(187, 59);
            labelSubtotal.TabIndex = 2;
            labelSubtotal.Text = "000,00";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 14);
            label6.Name = "label6";
            label6.Size = new Size(163, 31);
            label6.TabIndex = 5;
            label6.Text = "QUANTIDADE";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxQuantidade.Cursor = Cursors.IBeam;
            textBoxQuantidade.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxQuantidade.Location = new Point(38, 50);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(179, 87);
            textBoxQuantidade.TabIndex = 15;
            textBoxQuantidade.Text = "1";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(277, 14);
            label7.Name = "label7";
            label7.Size = new Size(155, 31);
            label7.TabIndex = 6;
            label7.Text = "VALOR PAGO";
            // 
            // textBoxValorPago
            // 
            textBoxValorPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxValorPago.Cursor = Cursors.IBeam;
            textBoxValorPago.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxValorPago.Location = new Point(277, 50);
            textBoxValorPago.Name = "textBoxValorPago";
            textBoxValorPago.Size = new Size(233, 87);
            textBoxValorPago.TabIndex = 16;
            // 
            // textBoxCodigodeBarras
            // 
            textBoxCodigodeBarras.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCodigodeBarras.Location = new Point(454, 195);
            textBoxCodigodeBarras.Name = "textBoxCodigodeBarras";
            textBoxCodigodeBarras.Size = new Size(298, 65);
            textBoxCodigodeBarras.TabIndex = 19;
            textBoxCodigodeBarras.KeyDown += textBoxCodigodeBarras_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(454, 149);
            label11.Name = "label11";
            label11.Size = new Size(219, 31);
            label11.TabIndex = 13;
            label11.Text = "CÓDIGO DE BARRA";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1336, 149);
            label5.Name = "label5";
            label5.Size = new Size(96, 31);
            label5.TabIndex = 4;
            label5.Text = "TROCO:";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.LimeGreen;
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvar.ForeColor = SystemColors.ButtonHighlight;
            buttonSalvar.Location = new Point(1306, 617);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(121, 42);
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
            buttonCancelar.Location = new Point(1179, 617);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(121, 41);
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, idVendaDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, valorUnitarioDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn, nomeProdutoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itemVendaListBindingSource;
            dataGridView1.Location = new Point(454, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(973, 331);
            dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "IdProduto";
            dataGridViewTextBoxColumn2.HeaderText = "IdProduto";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            idVendaDataGridViewTextBoxColumn.DataPropertyName = "IdVenda";
            idVendaDataGridViewTextBoxColumn.HeaderText = "IdVenda";
            idVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            idVendaDataGridViewTextBoxColumn.Width = 125;
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
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            produtoDataGridViewTextBoxColumn.ReadOnly = true;
            produtoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemVendaListBindingSource
            // 
            itemVendaListBindingSource.DataMember = "ItemVendaList";
            itemVendaListBindingSource.DataSource = bindingSourceVenda;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.DataSource = typeof(Models.Venda);
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(846, 149);
            label12.Name = "label12";
            label12.Size = new Size(200, 31);
            label12.TabIndex = 18;
            label12.Text = "PREÇO UNITÁRIO";
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBuscarProduto.BackColor = Color.FromArgb(50, 153, 204);
            buttonBuscarProduto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscarProduto.ForeColor = SystemColors.Window;
            buttonBuscarProduto.Location = new Point(454, 617);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(241, 53);
            buttonBuscarProduto.TabIndex = 20;
            buttonBuscarProduto.Text = "Buscar Produto";
            buttonBuscarProduto.UseVisualStyleBackColor = false;
            buttonBuscarProduto.Click += button1_Click;
            buttonBuscarProduto.KeyDown += button1_KeyDown;
            // 
            // labelpreco
            // 
            labelpreco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelpreco.AutoSize = true;
            labelpreco.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelpreco.Location = new Point(846, 201);
            labelpreco.Name = "labelpreco";
            labelpreco.Size = new Size(73, 59);
            labelpreco.TabIndex = 20;
            labelpreco.Text = "...";
            // 
            // labelTroco
            // 
            labelTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTroco.AutoSize = true;
            labelTroco.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTroco.ImageAlign = ContentAlignment.MiddleRight;
            labelTroco.Location = new Point(1354, 195);
            labelTroco.Name = "labelTroco";
            labelTroco.Size = new Size(73, 59);
            labelTroco.TabIndex = 14;
            labelTroco.Text = "...";
            labelTroco.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormInicializarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1466, 954);
            Controls.Add(textBoxCodigodeBarras);
            Controls.Add(labelpreco);
            Controls.Add(buttonBuscarProduto);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(labelTroco);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)itemVendaListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelNomeProduto;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label labelSubtotal;
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
        private TextBox textBoxQuantidade;
        private TextBox textBoxValorPago;
        private Label label12;
        private TextBox textBoxCodigodeBarras;
        private Button buttonBuscarProduto;
        private Label labelpreco;
        private Label labelTroco;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private BindingSource itemVendaListBindingSource;
    }
}