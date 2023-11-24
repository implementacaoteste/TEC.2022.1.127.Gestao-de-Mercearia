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
            System.Windows.Forms.Label MENU;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGrupoUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEstatistica = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonFornecedores = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelNomeEmpresa = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            MENU = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            label1.Location = new System.Drawing.Point(319, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(285, 40);
            label1.TabIndex = 1;
            label1.Text = "CAIXA ABERTO";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MENU
            // 
            MENU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            MENU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            MENU.Font = new System.Drawing.Font("Swis721 Blk BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MENU.ForeColor = System.Drawing.Color.White;
            MENU.Location = new System.Drawing.Point(17, 20);
            MENU.Name = "MENU";
            MENU.Size = new System.Drawing.Size(282, 50);
            MENU.TabIndex = 2;
            MENU.Text = "MENU";
            MENU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUsuario.Location = new System.Drawing.Point(12, 376);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(261, 32);
            this.buttonUsuario.TabIndex = 2;
            this.buttonUsuario.Text = "Consultar Usuários";
            this.buttonUsuario.UseVisualStyleBackColor = false;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCliente.Location = new System.Drawing.Point(12, 168);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(261, 32);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "Cadastrar Clientes";
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(924, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 936);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.buttonGrupoUsuario);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(MENU);
            this.panel2.Controls.Add(this.buttonCliente);
            this.panel2.Controls.Add(this.buttonUsuario);
            this.panel2.Controls.Add(this.buttonEstatistica);
            this.panel2.Controls.Add(this.buttonProdutos);
            this.panel2.Controls.Add(this.buttonFornecedores);
            this.panel2.Controls.Add(this.buttonFuncionarios);
            this.panel2.Controls.Add(this.monthCalendar2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 936);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonGrupoUsuario
            // 
            this.buttonGrupoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrupoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGrupoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGrupoUsuario.Location = new System.Drawing.Point(12, 325);
            this.buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            this.buttonGrupoUsuario.Size = new System.Drawing.Size(261, 32);
            this.buttonGrupoUsuario.TabIndex = 21;
            this.buttonGrupoUsuario.Text = "Consultar Grupo de Usuários";
            this.buttonGrupoUsuario.UseVisualStyleBackColor = false;
            this.buttonGrupoUsuario.Click += new System.EventHandler(this.buttonGrupoUsuario_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEstatistica
            // 
            this.buttonEstatistica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstatistica.BackColor = System.Drawing.Color.White;
            this.buttonEstatistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstatistica.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEstatistica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.buttonEstatistica.Location = new System.Drawing.Point(9, 664);
            this.buttonEstatistica.Name = "buttonEstatistica";
            this.buttonEstatistica.Size = new System.Drawing.Size(269, 44);
            this.buttonEstatistica.TabIndex = 12;
            this.buttonEstatistica.Text = "Estatística";
            this.buttonEstatistica.UseVisualStyleBackColor = false;
            this.buttonEstatistica.Click += new System.EventHandler(this.buttonEstatistica_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProdutos.Location = new System.Drawing.Point(12, 112);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(261, 32);
            this.buttonProdutos.TabIndex = 8;
            this.buttonProdutos.Text = "Cadastrar Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = false;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // buttonFornecedores
            // 
            this.buttonFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFornecedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFornecedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFornecedores.Location = new System.Drawing.Point(12, 272);
            this.buttonFornecedores.Name = "buttonFornecedores";
            this.buttonFornecedores.Size = new System.Drawing.Size(261, 32);
            this.buttonFornecedores.TabIndex = 9;
            this.buttonFornecedores.Text = "Consultar Fornecedor";
            this.buttonFornecedores.UseVisualStyleBackColor = false;
            this.buttonFornecedores.Click += new System.EventHandler(this.buttonFornecedores_Click);
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFuncionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFuncionarios.Location = new System.Drawing.Point(12, 220);
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.Size = new System.Drawing.Size(261, 32);
            this.buttonFuncionarios.TabIndex = 10;
            this.buttonFuncionarios.Text = "Consultar Funcionários";
            this.buttonFuncionarios.UseVisualStyleBackColor = false;
            this.buttonFuncionarios.Click += new System.EventHandler(this.buttonFuncionarios_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar2.Location = new System.Drawing.Point(9, 720);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 4;
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
            this.labelNomeEmpresa.AutoSize = true;
            this.labelNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelNomeEmpresa.Font = new System.Drawing.Font("Bernard MT Condensed", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelNomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.labelNomeEmpresa.Location = new System.Drawing.Point(335, 0);
            this.labelNomeEmpresa.Name = "labelNomeEmpresa";
            this.labelNomeEmpresa.Size = new System.Drawing.Size(361, 55);
            this.labelNomeEmpresa.TabIndex = 5;
            this.labelNomeEmpresa.Text = "Nome da Empresa";
            this.labelNomeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNomeEmpresa.Click += new System.EventHandler(this.label2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 936);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(label1);
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 61);
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
            this.label4.Location = new System.Drawing.Point(264, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 55);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome da Empresa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBoxLogo.ErrorImage = null;
            this.pictureBoxLogo.Image = global::UIGestaoMercearia.Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(225, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(67, 52);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(921, 82);
            this.panel4.TabIndex = 17;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(512, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(342, 45);
            this.button10.TabIndex = 20;
            this.button10.Text = "CONSULTAR VENDA";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(20, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(465, 45);
            this.button9.TabIndex = 17;
            this.button9.Text = "INICIAR VENDA";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::UIGestaoMercearia.Properties.Resources.settings_512px;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(860, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(921, 673);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1209, 936);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelNomeEmpresa);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1157, 733);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResizeEnd += new System.EventHandler(this.FormPrincipal_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button buttonUsuario;
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
        private Button buttonEstatistica;
        private Button buttonProdutos;
        private Button buttonFornecedores;
        private Button buttonFuncionarios;
        private MonthCalendar monthCalendar2;
        private Panel panel3;
        private Label label4;
        private PictureBox pictureBoxLogo;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button10;
        private Button button9;
        private Button buttonGrupoUsuario;
        private PictureBox pictureBox2;
    }
}

