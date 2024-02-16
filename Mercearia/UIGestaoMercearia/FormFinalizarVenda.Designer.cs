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
            buttonBuscarFormaPagamento.Location = new Point(474, 112);
            buttonBuscarFormaPagamento.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            buttonBuscarFormaPagamento.Size = new Size(47, 32);
            buttonBuscarFormaPagamento.TabIndex = 3;
            buttonBuscarFormaPagamento.Text = "...";
            buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // labelFormaPagamento
            // 
            labelFormaPagamento.AutoSize = true;
            labelFormaPagamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormaPagamento.ForeColor = Color.White;
            labelFormaPagamento.Location = new Point(22, 92);
            labelFormaPagamento.Name = "labelFormaPagamento";
            labelFormaPagamento.Size = new Size(199, 20);
            labelFormaPagamento.TabIndex = 1;
            labelFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFormaPagamento.Cursor = Cursors.IBeam;
            textBoxFormaPagamento.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFormaPagamento.Location = new Point(22, 112);
            textBoxFormaPagamento.Margin = new Padding(3, 2, 3, 2);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.Size = new Size(448, 36);
            textBoxFormaPagamento.TabIndex = 2;
            textBoxFormaPagamento.TabStop = false;
            // 
            // textBoxValorPago
            // 
            textBoxValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxValorPago.Cursor = Cursors.IBeam;
            textBoxValorPago.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValorPago.Location = new Point(782, 112);
            textBoxValorPago.Margin = new Padding(3, 2, 3, 2);
            textBoxValorPago.Name = "textBoxValorPago";
            textBoxValorPago.Size = new Size(196, 36);
            textBoxValorPago.TabIndex = 5;
            textBoxValorPago.Visible = false;
            textBoxValorPago.KeyPress += textBoxValorPago_KeyPress;
            // 
            // labelValorPago
            // 
            labelValorPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelValorPago.AutoSize = true;
            labelValorPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorPago.ForeColor = Color.White;
            labelValorPago.Location = new Point(782, 92);
            labelValorPago.Name = "labelValorPago";
            labelValorPago.Size = new Size(114, 20);
            labelValorPago.TabIndex = 4;
            labelValorPago.Text = "VALOR PAGO";
            labelValorPago.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(154, 160);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(695, 450);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(894, 622);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 28);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.Location = new Point(795, 622);
            buttonOk.Margin = new Padding(3, 2, 3, 2);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 26);
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
            label3.Size = new Size(1000, 70);
            label3.TabIndex = 0;
            label3.Text = "FINALIZAR VENDA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTroco
            // 
            labelTroco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTroco.AutoSize = true;
            labelTroco.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTroco.ForeColor = SystemColors.ButtonHighlight;
            labelTroco.Location = new Point(574, 301);
            labelTroco.Name = "labelTroco";
            labelTroco.Size = new Size(98, 108);
            labelTroco.TabIndex = 6;
            labelTroco.Text = "0";
            labelTroco.Click += labelTroco_Click;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(545, 112);
            textBoxTotal.Margin = new Padding(3, 2, 3, 2);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(208, 36);
            textBoxTotal.TabIndex = 2;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.White;
            labelTotal.Location = new Point(545, 92);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(59, 20);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "TOTAL";
            labelTotal.Visible = false;
            // 
            // labelExTroco
            // 
            labelExTroco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelExTroco.AutoSize = true;
            labelExTroco.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelExTroco.ForeColor = SystemColors.ButtonHighlight;
            labelExTroco.Location = new Point(120, 301);
            labelExTroco.Name = "labelExTroco";
            labelExTroco.Size = new Size(567, 108);
            labelExTroco.TabIndex = 5;
            labelExTroco.Text = "TROCO: R$";
            // 
            // FormFinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(1000, 562);
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
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinalizarVenda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormFinalizarVenda_Load;
            KeyDown += FormFinalizarVenda_KeyDown;
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