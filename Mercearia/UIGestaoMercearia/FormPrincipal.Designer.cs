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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("Swis721 Blk BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(324, 10);
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
            this.panel1.Controls.Add(this.panel2);
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
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(61, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 4, 100, 4);
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "MENU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelNomeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.monthCalendar2);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 688);
            this.panel2.TabIndex = 15;
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(12, 373);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(261, 29);
            this.button8.TabIndex = 13;
            this.button8.Text = "Clientes";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(12, 338);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(261, 29);
            this.button9.TabIndex = 14;
            this.button9.Text = "Grupos de usuários";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(12, 303);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 29);
            this.button10.TabIndex = 11;
            this.button10.Text = "Clientes";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(12, 268);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(261, 29);
            this.button11.TabIndex = 12;
            this.button11.Text = "Grupos de usuários";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(12, 163);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(261, 29);
            this.button12.TabIndex = 8;
            this.button12.Text = "Usuários";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(12, 233);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(261, 29);
            this.button13.TabIndex = 9;
            this.button13.Text = "Clientes";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(12, 198);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(261, 29);
            this.button14.TabIndex = 10;
            this.button14.Text = "Grupos de usuários";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-17, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 4, 100, 4);
            this.label2.Size = new System.Drawing.Size(343, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da Empresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(9, 470);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 4;
            // 
            // button15
            // 
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(12, 58);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(261, 29);
            this.button15.TabIndex = 2;
            this.button15.Text = "Usuários";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(12, 128);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(261, 29);
            this.button16.TabIndex = 3;
            this.button16.Text = "Clientes";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button17.Location = new System.Drawing.Point(12, 93);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(261, 29);
            this.button17.TabIndex = 3;
            this.button17.Text = "Grupos de usuários";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(label1);
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 61);
            this.panel3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(145, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 55);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome da Empresa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1217, 688);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelNomeEmpresa);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panel2;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label2;
        private MonthCalendar monthCalendar2;
        private Button button15;
        private Button button16;
        private Button button17;
        private Panel panel3;
        private Label label4;
    }
}

