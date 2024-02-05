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
            panel1 = new Panel();
            label7 = new Label();
            buttonAlterarNomeUsuario = new Button();
            buttonAlterarSenha = new Button();
            buttonCancelar = new Button();
            textBoxNomeUsuario = new TextBox();
            label5 = new Label();
            textBoxSenha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxNovoNomeUsuario = new TextBox();
            textBoxConfirmacaoSenha = new TextBox();
            textBoxNovaSenha = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(buttonAlterarNomeUsuario);
            panel1.Controls.Add(buttonAlterarSenha);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(textBoxNomeUsuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxNovoNomeUsuario);
            panel1.Controls.Add(textBoxConfirmacaoSenha);
            panel1.Controls.Add(textBoxNovaSenha);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 444);
            panel1.TabIndex = 0;
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
            label7.Size = new Size(722, 61);
            label7.TabIndex = 36;
            label7.Text = "CONFIGURAÇÃO";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAlterarNomeUsuario
            // 
            buttonAlterarNomeUsuario.Location = new Point(167, 388);
            buttonAlterarNomeUsuario.Name = "buttonAlterarNomeUsuario";
            buttonAlterarNomeUsuario.Size = new Size(192, 29);
            buttonAlterarNomeUsuario.TabIndex = 35;
            buttonAlterarNomeUsuario.Text = "Alterar Nome de Usuario";
            buttonAlterarNomeUsuario.UseVisualStyleBackColor = true;
            buttonAlterarNomeUsuario.Click += buttonAlterarNomeUsuario_Click;
            // 
            // buttonAlterarSenha
            // 
            buttonAlterarSenha.Location = new Point(167, 234);
            buttonAlterarSenha.Name = "buttonAlterarSenha";
            buttonAlterarSenha.Size = new Size(175, 29);
            buttonAlterarSenha.TabIndex = 34;
            buttonAlterarSenha.Text = "Alterar Senha";
            buttonAlterarSenha.UseVisualStyleBackColor = true;
            buttonAlterarSenha.Click += buttonAlterarSenha_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(606, 403);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(104, 29);
            buttonCancelar.TabIndex = 33;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.Location = new Point(343, 322);
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(249, 27);
            textBoxNomeUsuario.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(10, 287);
            label5.Name = "label5";
            label5.Size = new Size(316, 18);
            label5.TabIndex = 31;
            label5.Text = "Insira aqui seu nome de usuario atual";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(262, 87);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(236, 27);
            textBoxSenha.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 92);
            label4.Name = "label4";
            label4.Size = new Size(229, 18);
            label4.TabIndex = 29;
            label4.Text = "Insira aqui sua senha atual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 325);
            label3.Name = "label3";
            label3.Size = new Size(314, 18);
            label3.TabIndex = 28;
            label3.Text = "Insira aqui seu novo nome de usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 180);
            label6.Name = "label6";
            label6.Size = new Size(282, 18);
            label6.TabIndex = 27;
            label6.Text = "Insira sua nova senha novamente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(227, 18);
            label2.TabIndex = 27;
            label2.Text = "Insira aqui sua nova senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 26;
            // 
            // textBoxNovoNomeUsuario
            // 
            textBoxNovoNomeUsuario.Location = new Point(343, 282);
            textBoxNovoNomeUsuario.Name = "textBoxNovoNomeUsuario";
            textBoxNovoNomeUsuario.Size = new Size(247, 27);
            textBoxNovoNomeUsuario.TabIndex = 25;
            // 
            // textBoxConfirmacaoSenha
            // 
            textBoxConfirmacaoSenha.Location = new Point(300, 175);
            textBoxConfirmacaoSenha.Name = "textBoxConfirmacaoSenha";
            textBoxConfirmacaoSenha.Size = new Size(198, 27);
            textBoxConfirmacaoSenha.TabIndex = 24;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Location = new Point(262, 134);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.Size = new Size(236, 27);
            textBoxNovaSenha.TabIndex = 24;
            // 
            // FormConfiguracao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 444);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfiguracao";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonIniciarVenda;
        private TextBox textBoxNovoNomeUsuario;
        private TextBox textBoxNovaSenha;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxSenha;
        private Label label4;
        private TextBox textBoxNomeUsuario;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonAlterarNomeUsuario;
        private Button buttonAlterarSenha;
        private Label label6;
        private TextBox textBoxConfirmacaoSenha;
        private Label label7;
    }
}