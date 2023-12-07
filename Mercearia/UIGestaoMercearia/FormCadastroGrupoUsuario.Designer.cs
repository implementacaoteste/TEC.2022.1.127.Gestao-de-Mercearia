namespace UIGestaoMercearia
{
    partial class FormCadastroGrupoUsuario
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
            System.Windows.Forms.Label nomeGrupoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxPermissoes = new System.Windows.Forms.TextBox();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeGrupoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeGrupoLabel.Location = new System.Drawing.Point(12, 80);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(132, 18);
            nomeGrupoLabel.TabIndex = 1;
            nomeGrupoLabel.Text = "Nome do grupo";
            nomeGrupoLabel.Click += new System.EventHandler(this.nomeGrupoLabel_Click);
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(577, 58);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de grupo de usuário";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(12, 144);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 18);
            label2.TabIndex = 5;
            label2.Text = "Permissões";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(12, 104);
            this.nomeGrupoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(536, 27);
            this.nomeGrupoTextBox.TabIndex = 2;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Azure;
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalvar.Location = new System.Drawing.Point(392, 259);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 29);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(473, 259);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxPermissoes
            // 
            this.textBoxPermissoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPermissoes.Location = new System.Drawing.Point(12, 167);
            this.textBoxPermissoes.Name = "textBoxPermissoes";
            this.textBoxPermissoes.Size = new System.Drawing.Size(536, 27);
            this.textBoxPermissoes.TabIndex = 6;
            // 
            // FormCadastroGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(577, 301);
            this.Controls.Add(this.textBoxPermissoes);
            this.Controls.Add(label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(label1);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de grupo de usuário";
            this.Load += new System.EventHandler(this.FormCadastroGrupoUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroGrupoUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private TextBox textBoxPermissoes;
    }
}