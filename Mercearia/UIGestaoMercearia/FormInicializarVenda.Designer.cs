﻿namespace UIGestaoMercearia
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
            labelPDV = new Label();
            labelNomeProduto = new Label();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            labelSubtotal = new Label();
            buttonFinalizarVenda = new Button();
            label6 = new Label();
            textBoxQuantidade = new TextBox();
            textBoxCodigodeBarras = new TextBox();
            label11 = new Label();
            buttonCancelar = new Button();
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
            labelpreco = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(labelPDV);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 64);
            panel1.TabIndex = 2;
            // 
            // labelPDV
            // 
            labelPDV.Anchor = AnchorStyles.Top;
            labelPDV.AutoSize = true;
            labelPDV.BackColor = Color.FromArgb(50, 153, 204);
            labelPDV.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelPDV.ForeColor = Color.White;
            labelPDV.Location = new Point(677, 0);
            labelPDV.Name = "labelPDV";
            labelPDV.Size = new Size(136, 67);
            labelPDV.TabIndex = 1;
            labelPDV.Text = "PDV";
            // 
            // labelNomeProduto
            // 
            labelNomeProduto.Anchor = AnchorStyles.Top;
            labelNomeProduto.AutoSize = true;
            labelNomeProduto.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeProduto.Location = new Point(356, 6);
            labelNomeProduto.Name = "labelNomeProduto";
            labelNomeProduto.Size = new Size(377, 47);
            labelNomeProduto.TabIndex = 0;
            labelNomeProduto.Text = "Nome do Produto";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(labelNomeProduto);
            panel2.Location = new Point(399, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 73);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(891, -8);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(162, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(labelSubtotal);
            panel3.Location = new Point(399, 771);
            panel3.Name = "panel3";
            panel3.Size = new Size(1067, 182);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(934, 49);
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
            labelSubtotal.Location = new Point(839, 77);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(187, 59);
            labelSubtotal.TabIndex = 2;
            labelSubtotal.Text = "000,00";
            // 
            // buttonFinalizarVenda
            // 
            buttonFinalizarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFinalizarVenda.BackColor = Color.FromArgb(50, 153, 204);
            buttonFinalizarVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinalizarVenda.ForeColor = SystemColors.Window;
            buttonFinalizarVenda.Location = new Point(1224, 701);
            buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            buttonFinalizarVenda.Size = new Size(208, 53);
            buttonFinalizarVenda.TabIndex = 22;
            buttonFinalizarVenda.Text = "Finalizar Venda";
            buttonFinalizarVenda.UseVisualStyleBackColor = false;
            buttonFinalizarVenda.Click += finaliz;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1240, 149);
            label6.Name = "label6";
            label6.Size = new Size(163, 31);
            label6.TabIndex = 3;
            label6.Text = "QUANTIDADE";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxQuantidade.BackColor = Color.WhiteSmoke;
            textBoxQuantidade.BorderStyle = BorderStyle.None;
            textBoxQuantidade.Cursor = Cursors.IBeam;
            textBoxQuantidade.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxQuantidade.Location = new Point(1224, 183);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(179, 80);
            textBoxQuantidade.TabIndex = 10;
            textBoxQuantidade.Text = "1";
            textBoxQuantidade.KeyDown += textBoxQuantidade_KeyDown;
            textBoxQuantidade.KeyPress += textBoxQuantidade_KeyPress;
            // 
            // textBoxCodigodeBarras
            // 
            textBoxCodigodeBarras.BackColor = Color.WhiteSmoke;
            textBoxCodigodeBarras.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCodigodeBarras.Location = new Point(454, 195);
            textBoxCodigodeBarras.Name = "textBoxCodigodeBarras";
            textBoxCodigodeBarras.Size = new Size(298, 65);
            textBoxCodigodeBarras.TabIndex = 11;
            textBoxCodigodeBarras.KeyDown += textBoxCodigodeBarras_KeyDown;
            textBoxCodigodeBarras.KeyPress += textBoxCodigodeBarras_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(454, 149);
            label11.Name = "label11";
            label11.Size = new Size(219, 31);
            label11.TabIndex = 3;
            label11.Text = "CÓDIGO DE BARRA";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.Coral;
            buttonCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ButtonHighlight;
            buttonCancelar.Location = new Point(1013, 701);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(205, 53);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(50, 153, 204);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, idVendaDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, valorUnitarioDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn, nomeProdutoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itemVendaListBindingSource;
            dataGridView1.Location = new Point(459, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(973, 415);
            dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
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
            quantidadeDataGridViewTextBoxColumn.Width = 200;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            valorUnitarioDataGridViewTextBoxColumn.Width = 200;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            subTotalDataGridViewTextBoxColumn.Width = 200;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            produtoDataGridViewTextBoxColumn.ReadOnly = true;
            produtoDataGridViewTextBoxColumn.Width = 200;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 200;
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
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(846, 149);
            label12.Name = "label12";
            label12.Size = new Size(200, 31);
            label12.TabIndex = 2;
            label12.Text = "PREÇO UNITÁRIO";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelpreco
            // 
            labelpreco.Anchor = AnchorStyles.Top;
            labelpreco.AutoSize = true;
            labelpreco.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelpreco.ImageAlign = ContentAlignment.TopCenter;
            labelpreco.Location = new Point(908, 195);
            labelpreco.Name = "labelpreco";
            labelpreco.Size = new Size(73, 59);
            labelpreco.TabIndex = 0;
            labelpreco.Text = "...";
            labelpreco.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2024_01_31_0909582;
            pictureBox1.Location = new Point(-516, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(949, 1002);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // FormInicializarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1466, 954);
            Controls.Add(buttonFinalizarVenda);
            Controls.Add(textBoxCodigodeBarras);
            Controls.Add(labelpreco);
            Controls.Add(textBoxQuantidade);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInicializarVenda";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormInicializarVenda_Load;
            KeyDown += textBoxCodigodeBarras_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelNomeProduto;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label labelSubtotal;
        private Label label6;
        private Button buttonCancelar;
        private Label label11;
        private DataGridView dataGridView1;
        private BindingSource bindingSourceVenda;
        private EventHandler bindingSourceVenda_CurrentChanged;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private TextBox textBoxQuantidade;
        private Label label12;
        private TextBox textBoxCodigodeBarras;
        private Label labelpreco;
        private BindingSource itemVendaListBindingSource;
        private TextBox textBox1;
        private TextBox textBoxPrecoProduto;
        private Button button1;
        private PictureBox pictureBox1;
        private Button buttonFinalizarVenda;
        private Label labelPDV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private PictureBox pictureBoxLogo;
    }
}