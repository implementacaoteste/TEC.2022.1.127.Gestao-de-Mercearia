namespace UIGestaoMercearia
{
    partial class FormCadastroUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label label1;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Location = new System.Drawing.Point(3, 97);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 18);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cPFLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cPFLabel.Location = new System.Drawing.Point(225, 156);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(40, 18);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Location = new System.Drawing.Point(330, 97);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(58, 18);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-mail";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeUsuarioLabel.Location = new System.Drawing.Point(3, 156);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(146, 18);
            nomeUsuarioLabel.TabIndex = 7;
            nomeUsuarioLabel.Text = "Nome de usuário";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            senhaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            senhaLabel.Location = new System.Drawing.Point(6, 213);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(59, 18);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(112, 213);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 18);
            label1.TabIndex = 11;
            label1.Text = "Confirmar senha";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(6, 121);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(318, 27);
            this.nomeTextBox.TabIndex = 2;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(225, 180);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(331, 27);
            this.cPFTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(330, 121);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(393, 27);
            this.emailTextBox.TabIndex = 6;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(6, 180);
            this.nomeUsuarioTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(213, 27);
            this.nomeUsuarioTextBox.TabIndex = 8;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(6, 236);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 27);
            this.senhaTextBox.TabIndex = 10;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ativoCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ativoCheckBox.Location = new System.Drawing.Point(283, 239);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(69, 24);
            this.ativoCheckBox.TabIndex = 13;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(112, 237);
            this.textBoxConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(165, 27);
            this.textBoxConfirmarSenha.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 74);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastro de usuários";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(567, 263);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 39);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(648, 263);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 39);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(731, 309);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(label1);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuários";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}