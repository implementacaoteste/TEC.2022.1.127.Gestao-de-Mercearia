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
            buttonBuscarFornecedor = new Button();
            label9 = new Label();
            textBoxFormaPagamento = new TextBox();
            textBoxDinheiro = new TextBox();
            label1 = new Label();
            textBoxTroco = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonCancelar = new Button();
            buttonOk = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarFornecedor
            // 
            buttonBuscarFornecedor.Location = new Point(301, 102);
            buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            buttonBuscarFornecedor.Size = new Size(29, 29);
            buttonBuscarFornecedor.TabIndex = 36;
            buttonBuscarFornecedor.Text = "...";
            buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
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
            // textBoxDinheiro
            // 
            textBoxDinheiro.Cursor = Cursors.IBeam;
            textBoxDinheiro.Location = new Point(336, 104);
            textBoxDinheiro.Name = "textBoxDinheiro";
            textBoxDinheiro.Size = new Size(163, 27);
            textBoxDinheiro.TabIndex = 34;
            textBoxDinheiro.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(336, 81);
            label1.Name = "label1";
            label1.Size = new Size(163, 18);
            label1.TabIndex = 35;
            label1.Text = "Dinheiro do cliente";
            label1.Visible = false;
            // 
            // textBoxTroco
            // 
            textBoxTroco.Cursor = Cursors.IBeam;
            textBoxTroco.Location = new Point(505, 104);
            textBoxTroco.Name = "textBoxTroco";
            textBoxTroco.Size = new Size(163, 27);
            textBoxTroco.TabIndex = 34;
            textBoxTroco.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(505, 81);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 35;
            label2.Text = "Troco";
            label2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(149, 137);
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
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(474, 477);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 38;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
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
            label3.Text = "FORMA DE PAGAMENTO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormFinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 153, 204);
            ClientSize = new Size(680, 518);
            Controls.Add(label3);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancelar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBuscarFornecedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(textBoxTroco);
            Controls.Add(textBoxDinheiro);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarFornecedor;
        private Label label9;
        private TextBox textBoxFormaPagamento;
        private TextBox textBoxDinheiro;
        private Label label1;
        private TextBox textBoxTroco;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private Button buttonOk;
        private Label label3;
    }
}