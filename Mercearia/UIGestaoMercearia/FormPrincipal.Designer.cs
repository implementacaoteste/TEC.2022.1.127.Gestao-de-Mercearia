namespace UIGestaoMercearia
{
    partial class FormPrincipal
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
            System.Windows.Forms.Label label1;
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelNomeEmpresa = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("Swis721 Blk BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            label1.Location = new System.Drawing.Point(304, 197);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(285, 40);
            label1.TabIndex = 1;
            label1.Text = "CAIXA ABERTO";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUsuario.Location = new System.Drawing.Point(17, 45);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(261, 29);
            this.buttonUsuario.TabIndex = 2;
            this.buttonUsuario.Text = "Usuários";
            this.buttonUsuario.UseVisualStyleBackColor = false;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonGrupoUsuario
            // 
            this.buttonGrupoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGrupoUsuario.Location = new System.Drawing.Point(17, 80);
            this.buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            this.buttonGrupoUsuario.Size = new System.Drawing.Size(261, 29);
            this.buttonGrupoUsuario.TabIndex = 3;
            this.buttonGrupoUsuario.Text = "Grupos de usuários";
            this.buttonGrupoUsuario.UseVisualStyleBackColor = false;
            this.buttonGrupoUsuario.Click += new System.EventHandler(this.buttonGrupoUsuario_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCliente.Location = new System.Drawing.Point(17, 115);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(261, 29);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.buttonUsuario);
            this.panel1.Controls.Add(this.buttonCliente);
            this.panel1.Controls.Add(this.buttonGrupoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(932, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 688);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(116, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "MENU";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 470);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // labelNomeEmpresa
            // 
            this.labelNomeEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelNomeEmpresa.Font = new System.Drawing.Font("Script MT Bold", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelNomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.labelNomeEmpresa.Location = new System.Drawing.Point(0, 0);
            this.labelNomeEmpresa.Name = "labelNomeEmpresa";
            this.labelNomeEmpresa.Size = new System.Drawing.Size(926, 55);
            this.labelNomeEmpresa.TabIndex = 5;
            this.labelNomeEmpresa.Text = "Nome da Empresa";
            this.labelNomeEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNomeEmpresa.Click += new System.EventHandler(this.label2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 688);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(17, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Usuários";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(17, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(17, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Grupos de usuários";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(17, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "Clientes";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(17, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "Grupos de usuários";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(17, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(261, 29);
            this.button6.TabIndex = 13;
            this.button6.Text = "Clientes";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(17, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 29);
            this.button7.TabIndex = 14;
            this.button7.Text = "Grupos de usuários";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1217, 688);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelNomeEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button buttonUsuario;
        private Button buttonGrupoUsuario;
        private Button buttonCliente;
        private Panel panel1;
        private Label labelNomeEmpresa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Splitter splitter1;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

