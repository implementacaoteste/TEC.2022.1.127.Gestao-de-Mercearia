﻿namespace UIGestaoMercearia
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
            label9 = new Label();
            textBoxFormaPagamento = new TextBox();
            textBoxValorPago = new TextBox();
            label1 = new Label();
            textBoxTroco = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonCancelar = new Button();
            buttonOk = new Button();
            label3 = new Label();
            bindingSourceFinalizarVenda = new BindingSource(components);
            textBox1 = new TextBox();
            label4 = new Label();
            labelTroco = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFinalizarVenda).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarFormaPagamento
            // 
            buttonBuscarFormaPagamento.Location = new Point(301, 102);
            buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            buttonBuscarFormaPagamento.Size = new Size(29, 29);
            buttonBuscarFormaPagamento.TabIndex = 36;
            buttonBuscarFormaPagamento.Text = "...";
            buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            buttonBuscarFormaPagamento.Click += buttonBuscarFormaPagamento_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 79);
            label9.Name = "label9";
            label9.Size = new Size(200, 18);
            label9.TabIndex = 35;
            label9.Text = "FORMA DE PAGAMENTO";
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.Cursor = Cursors.IBeam;
            textBoxFormaPagamento.Location = new Point(12, 102);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.Size = new Size(283, 27);
            textBoxFormaPagamento.TabIndex = 34;
            // 
            // textBoxValorPago
            // 
            textBoxValorPago.Cursor = Cursors.IBeam;
            textBoxValorPago.Location = new Point(12, 256);
            textBoxValorPago.Name = "textBoxValorPago";
            textBoxValorPago.Size = new Size(163, 27);
            textBoxValorPago.TabIndex = 34;
            textBoxValorPago.Visible = false;
            textBoxValorPago.KeyPress += textBoxValorPago_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(114, 18);
            label1.TabIndex = 35;
            label1.Text = "VALOR PAGO";
            label1.Visible = false;
            // 
            // textBoxTroco
            // 
            textBoxTroco.Cursor = Cursors.IBeam;
            textBoxTroco.Location = new Point(12, 343);
            textBoxTroco.Name = "textBoxTroco";
            textBoxTroco.Size = new Size(163, 27);
            textBoxTroco.TabIndex = 34;
            textBoxTroco.Visible = false;
            textBoxTroco.KeyDown += textBoxTroco_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 322);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 35;
            label2.Text = "TROCO";
            label2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(234, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 303);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(574, 477);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(474, 477);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 38;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(50, 153, 204);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(680, 61);
            label3.TabIndex = 39;
            label3.Text = "FINALIZAR VENDA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(61, 18);
            label4.TabIndex = 35;
            label4.Text = "TOTAL";
            label4.Visible = false;
            // 
            // labelTroco
            // 
            labelTroco.AutoSize = true;
            labelTroco.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTroco.ForeColor = SystemColors.ButtonHighlight;
            labelTroco.Location = new Point(278, 256);
            labelTroco.Name = "labelTroco";
            labelTroco.Size = new Size(214, 36);
            labelTroco.TabIndex = 41;
            labelTroco.Text = "TROCO R$ 0";
            // 
            // FormFinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            CancelButton = buttonCancelar;
            ClientSize = new Size(680, 518);
            Controls.Add(labelTroco);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancelar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBuscarFormaPagamento);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(textBoxTroco);
            Controls.Add(textBoxValorPago);
            Controls.Add(textBoxFormaPagamento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinalizarVenda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFinalizarVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarFormaPagamento;
        private Label label9;
        private TextBox textBoxFormaPagamento;
        private TextBox textBoxValorPago;
        private Label label1;
        private TextBox textBoxTroco;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private Button buttonOk;
        private Label label3;
        private BindingSource bindingSourceFinalizarVenda;
        private TextBox textBox1;
        private Label label4;
        private Label labelTroco;
    }
}