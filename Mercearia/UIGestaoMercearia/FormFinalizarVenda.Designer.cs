namespace UIGestaoMercearia
{
    partial class FormFinalizarVenda
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
            buttonBuscarFormaPagamento = new Button();
            labelFormaPagamento = new Label();
            textBoxFormaPagamento = new TextBox();
            textBoxValorPago = new TextBox();
            labelValorPago = new Label();
            pictureBox1 = new PictureBox();
            buttonCancelar = new Button();
            buttonOk = new Button();
            label3 = new Label();
            bindingSourceFinalizarVenda = new BindingSource(components);
            labelTroco = new Label();
            textBoxTotal = new TextBox();
            labelTotal = new Label();
            labelExTroco = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFinalizarVenda).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarFormaPagamento
            // 
            buttonBuscarFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscarFormaPagamento.Location = new Point(542, 149);
            buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            buttonBuscarFormaPagamento.Size = new Size(54, 43);
            buttonBuscarFormaPagamento.TabIndex = 3;
            buttonBuscarFormaPagamento.Text = "...";
            buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // labelFormaPagamento
            // 
            labelFormaPagamento.AutoSize = true;
            labelFormaPagamento.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormaPagamento.ForeColor = Color.White;
            labelFormaPagamento.Location = new Point(25, 122);
            labelFormaPagamento.Name = "labelFormaPagamento";
            labelFormaPagamento.Size = new Size(271, 24);
            labelFormaPagamento.TabIndex = 5;
            labelFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFormaPagamento.Cursor = Cursors.IBeam;
            textBoxFormaPagamento.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFormaPagamento.Location = new Point(25, 149);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.Size = new Size(511, 43);
            textBoxFormaPagamento.TabIndex = 5;
            // 
            // textBoxValorPago
            // 
            textBoxValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxValorPago.Cursor = Cursors.IBeam;
            textBoxValorPago.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValorPago.Location = new Point(894, 149);
            textBoxValorPago.Name = "textBoxValorPago";
            textBoxValorPago.Size = new Size(223, 43);
            textBoxValorPago.TabIndex = 1;
            textBoxValorPago.Visible = false;
            textBoxValorPago.KeyPress += textBoxValorPago_KeyPress;
            // 
            // labelValorPago
            // 
            labelValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelValorPago.AutoSize = true;
            labelValorPago.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorPago.ForeColor = Color.White;
            labelValorPago.Location = new Point(894, 122);
            labelValorPago.Name = "labelValorPago";
            labelValorPago.Size = new Size(153, 24);
            labelValorPago.TabIndex = 2;
            labelValorPago.Text = "VALOR PAGO";
            labelValorPago.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(176, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 600);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(1022, 829);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(107, 37);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.Location = new Point(909, 829);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(107, 35);
            buttonOk.TabIndex = 38;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(50, 153, 204);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1143, 94);
            label3.TabIndex = 39;
            label3.Text = "FINALIZAR VENDA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTroco
            // 
            labelTroco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTroco.AutoSize = true;
            labelTroco.Font = new Font("Swis721 Blk BT", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTroco.ForeColor = SystemColors.ButtonHighlight;
            labelTroco.Location = new Point(656, 401);
            labelTroco.Name = "labelTroco";
            labelTroco.Size = new Size(139, 144);
            labelTroco.TabIndex = 40;
            labelTroco.Text = "0";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(623, 149);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(237, 43);
            textBoxTotal.TabIndex = 7;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.White;
            labelTotal.Location = new Point(623, 122);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(80, 24);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "TOTAL";
            labelTotal.Visible = false;
            // 
            // labelExTroco
            // 
            labelExTroco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelExTroco.AutoSize = true;
            labelExTroco.Font = new Font("Swis721 Blk BT", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelExTroco.ForeColor = SystemColors.ButtonHighlight;
            labelExTroco.Location = new Point(137, 401);
            labelExTroco.Name = "labelExTroco";
            labelExTroco.Size = new Size(776, 144);
            labelExTroco.TabIndex = 40;
            labelExTroco.Text = "TROCO: R$";
            // 
            // FormFinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1143, 876);
            Controls.Add(label3);
            Controls.Add(labelTroco);
            Controls.Add(textBoxTotal);
            Controls.Add(labelExTroco);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancelar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBuscarFormaPagamento);
            Controls.Add(labelTotal);
            Controls.Add(labelValorPago);
            Controls.Add(labelFormaPagamento);
            Controls.Add(textBoxValorPago);
            Controls.Add(textBoxFormaPagamento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinalizarVenda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormFinalizarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFinalizarVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarFormaPagamento;
        private Label labelFormaPagamento;
        private TextBox textBoxFormaPagamento;
        private TextBox textBoxValorPago;
        private Label labelValorPago;
        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private Button buttonOk;
        private Label label3;
        private BindingSource bindingSourceFinalizarVenda;
        private Label labelTroco;
        private TextBox textBoxTotal;
        private Label labelTotal;
        private Label labelExTroco;
    }
}