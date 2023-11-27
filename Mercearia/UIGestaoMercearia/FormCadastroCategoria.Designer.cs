namespace UIGestaoMercearia
{
    partial class FormCadastroCategoria
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1Nome = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(683, 159);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 47;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Azure;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(583, 159);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 46;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(782, 61);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cadastro de Categoria";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1Nome
            // 
            this.textBox1Nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Nome", true));
            this.textBox1Nome.Location = new System.Drawing.Point(41, 110);
            this.textBox1Nome.Name = "textBox1Nome";
            this.textBox1Nome.Size = new System.Drawing.Size(728, 27);
            this.textBox1Nome.TabIndex = 48;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Models.Categoria);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 35);
            this.label1.TabIndex = 49;
            this.label1.Text = "Insira uma categoria:";
            // 
            // FormCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(782, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Nome);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCategoria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label10;
        private TextBox textBox1Nome;
        private Label label1;
        private BindingSource categoriaBindingSource;
    }
}