namespace UIGestaoMercearia
{
    partial class FormConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracao));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            buttonAlterarSenha = new Button();
            textBoxSenha = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxConfirmacaoSenha = new TextBox();
            textBoxNovaSenha = new TextBox();
            pictureBoxLogo = new PictureBox();
            buttonCancelar = new Button();
            textBoxNovoNomeUsuario = new TextBox();
            textBoxNomeUsuario = new TextBox();
            buttonAlterarNomeUsuario = new Button();
            label3 = new Label();
            label10 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxNovoNomeUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxNomeUsuario);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonAlterarSenha);
            panel1.Controls.Add(buttonAlterarNomeUsuario);
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxConfirmacaoSenha);
            panel1.Controls.Add(textBoxNovaSenha);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 653);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 BlkCn BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(27, 157);
            label9.Name = "label9";
            label9.Size = new Size(169, 27);
            label9.TabIndex = 29;
            label9.Text = "ALTERAR SENHA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 BlkCn BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(71, 99);
            label8.Name = "label8";
            label8.Size = new Size(329, 36);
            label8.TabIndex = 27;
            label8.Text = "Privacidade e Segurança";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(50, 153, 204);
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Dock = DockStyle.Top;
            label7.Enabled = false;
            label7.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(748, 61);
            label7.TabIndex = 1;
            label7.Text = "CONFIGURAÇÃO";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAlterarSenha
            // 
            buttonAlterarSenha.Location = new Point(28, 338);
            buttonAlterarSenha.Name = "buttonAlterarSenha";
            buttonAlterarSenha.Size = new Size(108, 29);
            buttonAlterarSenha.TabIndex = 8;
            buttonAlterarSenha.Text = "Salvar";
            buttonAlterarSenha.UseVisualStyleBackColor = true;
            buttonAlterarSenha.Click += buttonAlterarSenha_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Right;
            textBoxSenha.Location = new Point(157, 207);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(569, 27);
            textBoxSenha.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(28, 212);
            label4.Name = "label4";
            label4.Size = new Size(123, 18);
            label4.TabIndex = 2;
            label4.Text = "SENHA ATUAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(28, 300);
            label6.Name = "label6";
            label6.Size = new Size(218, 18);
            label6.TabIndex = 6;
            label6.Text = "CONFIRMAR NOVA SENHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 259);
            label2.Name = "label2";
            label2.Size = new Size(115, 18);
            label2.TabIndex = 4;
            label2.Text = "NOVA SENHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 26;
            // 
            // textBoxConfirmacaoSenha
            // 
            textBoxConfirmacaoSenha.Anchor = AnchorStyles.Right;
            textBoxConfirmacaoSenha.Location = new Point(252, 295);
            textBoxConfirmacaoSenha.Name = "textBoxConfirmacaoSenha";
            textBoxConfirmacaoSenha.Size = new Size(474, 27);
            textBoxConfirmacaoSenha.TabIndex = 7;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Anchor = AnchorStyles.Right;
            textBoxNovaSenha.Location = new Point(149, 254);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.Size = new Size(577, 27);
            textBoxNovaSenha.TabIndex = 5;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(23, 90);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(51, 45);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 28;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.Location = new Point(631, 600);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(104, 29);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxNovoNomeUsuario
            // 
            textBoxNovoNomeUsuario.Anchor = AnchorStyles.Right;
            textBoxNovoNomeUsuario.Location = new Point(251, 460);
            textBoxNovoNomeUsuario.Name = "textBoxNovoNomeUsuario";
            textBoxNovoNomeUsuario.Size = new Size(474, 27);
            textBoxNovoNomeUsuario.TabIndex = 10;
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.Anchor = AnchorStyles.Right;
            textBoxNomeUsuario.Location = new Point(251, 500);
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(474, 27);
            textBoxNomeUsuario.TabIndex = 12;
            // 
            // buttonAlterarNomeUsuario
            // 
            buttonAlterarNomeUsuario.Location = new Point(23, 550);
            buttonAlterarNomeUsuario.Name = "buttonAlterarNomeUsuario";
            buttonAlterarNomeUsuario.Size = new Size(109, 29);
            buttonAlterarNomeUsuario.TabIndex = 13;
            buttonAlterarNomeUsuario.Text = "Salvar";
            buttonAlterarNomeUsuario.UseVisualStyleBackColor = true;
            buttonAlterarNomeUsuario.Click += buttonAlterarNomeUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(24, 509);
            label3.Name = "label3";
            label3.Size = new Size(215, 18);
            label3.TabIndex = 11;
            label3.Text = "NOVO NOME DE USUÁRIO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Swis721 BlkCn BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(23, 406);
            label10.Name = "label10";
            label10.Size = new Size(286, 27);
            label10.TabIndex = 30;
            label10.Text = "ALTERAR NOME DE USUÁRIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(21, 465);
            label5.Name = "label5";
            label5.Size = new Size(222, 18);
            label5.TabIndex = 9;
            label5.Text = "NOME DE USUÁRIO ATUAL";
            // 
            // FormConfiguracao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 653);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfiguracao";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonIniciarVenda;
        private TextBox textBoxNovaSenha;
        private Label label2;
        private Label label1;
        private TextBox textBoxSenha;
        private Label label4;
        private Button buttonAlterarSenha;
        private Label label6;
        private TextBox textBoxConfirmacaoSenha;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBoxLogo;
        private Label label10;
        private TextBox textBoxNovoNomeUsuario;
        private Label label3;
        private TextBox textBoxNomeUsuario;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonAlterarNomeUsuario;
    }
}