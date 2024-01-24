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
            components = new System.ComponentModel.Container();
            Label label1;
            Label MENU;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            buttonUsuario = new Button();
            buttonCliente = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonPermissao = new Button();
            button8 = new Button();
            buttonMarcas = new Button();
            buttonCategorias = new Button();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            buttonGrupoUsuario = new Button();
            buttonEstatistica = new Button();
            buttonProdutos = new Button();
            buttonFornecedores = new Button();
            buttonFuncionarios = new Button();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            labelNomeEmpresa = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitter1 = new Splitter();
            panel3 = new Panel();
            label4 = new Label();
            pictureBoxLogo = new PictureBox();
            panel4 = new Panel();
            buttonConsultarVenda = new Button();
            buttonIniciarVenda = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            MENU = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 153, 204);
            label1.Cursor = Cursors.No;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Swis721 Blk BT", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(319, 10);
            label1.Name = "label1";
            label1.Size = new Size(285, 40);
            label1.TabIndex = 1;
            label1.Text = "CAIXA ABERTO";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // MENU
            // 
            MENU.Anchor = AnchorStyles.Top;
            MENU.BackColor = Color.FromArgb(50, 153, 204);
            MENU.Cursor = Cursors.No;
            MENU.FlatStyle = FlatStyle.Popup;
            MENU.Font = new Font("Swis721 Blk BT", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            MENU.ForeColor = Color.White;
            MENU.Location = new Point(17, 14);
            MENU.Name = "MENU";
            MENU.Size = new Size(282, 50);
            MENU.TabIndex = 2;
            MENU.Text = "MENU";
            MENU.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonUsuario
            // 
            buttonUsuario.BackColor = Color.White;
            buttonUsuario.FlatStyle = FlatStyle.Flat;
            buttonUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonUsuario.Location = new Point(9, 381);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(269, 38);
            buttonUsuario.TabIndex = 2;
            buttonUsuario.Text = "Usuários";
            buttonUsuario.UseVisualStyleBackColor = false;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.BackColor = Color.White;
            buttonCliente.FlatStyle = FlatStyle.Flat;
            buttonCliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCliente.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCliente.Location = new Point(9, 162);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(269, 38);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 153, 204);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(monthCalendar1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(924, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 936);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(buttonPermissao);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(buttonMarcas);
            panel2.Controls.Add(buttonCategorias);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(MENU);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(buttonGrupoUsuario);
            panel2.Controls.Add(buttonCliente);
            panel2.Controls.Add(buttonUsuario);
            panel2.Controls.Add(buttonEstatistica);
            panel2.Controls.Add(buttonProdutos);
            panel2.Controls.Add(buttonFornecedores);
            panel2.Controls.Add(buttonFuncionarios);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 936);
            panel2.TabIndex = 15;
            panel2.Paint += panel2_Paint;
            // 
            // buttonPermissao
            // 
            buttonPermissao.BackColor = Color.White;
            buttonPermissao.FlatStyle = FlatStyle.Flat;
            buttonPermissao.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPermissao.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPermissao.Location = new Point(9, 505);
            buttonPermissao.Name = "buttonPermissao";
            buttonPermissao.Size = new Size(269, 35);
            buttonPermissao.TabIndex = 25;
            buttonPermissao.Text = "Permissões";
            buttonPermissao.UseVisualStyleBackColor = false;
            buttonPermissao.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(50, 153, 204);
            button8.Location = new Point(9, 252);
            button8.Name = "button8";
            button8.Size = new Size(269, 35);
            button8.TabIndex = 24;
            button8.Text = "Estoque";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // buttonMarcas
            // 
            buttonMarcas.BackColor = Color.White;
            buttonMarcas.FlatStyle = FlatStyle.Flat;
            buttonMarcas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMarcas.ForeColor = Color.FromArgb(50, 153, 204);
            buttonMarcas.Location = new Point(9, 464);
            buttonMarcas.Name = "buttonMarcas";
            buttonMarcas.Size = new Size(269, 35);
            buttonMarcas.TabIndex = 23;
            buttonMarcas.Text = "Marcas";
            buttonMarcas.UseVisualStyleBackColor = false;
            buttonMarcas.Click += buttonMarcas_Click;
            // 
            // buttonCategorias
            // 
            buttonCategorias.BackColor = Color.White;
            buttonCategorias.FlatStyle = FlatStyle.Flat;
            buttonCategorias.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategorias.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCategorias.Location = new Point(9, 425);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(269, 35);
            buttonCategorias.TabIndex = 22;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = false;
            buttonCategorias.Click += buttonCategorias_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Location = new Point(12, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(261, 10);
            panel5.TabIndex = 17;
            // 
            // buttonGrupoUsuario
            // 
            buttonGrupoUsuario.BackColor = Color.White;
            buttonGrupoUsuario.FlatStyle = FlatStyle.Flat;
            buttonGrupoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGrupoUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonGrupoUsuario.Location = new Point(9, 337);
            buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            buttonGrupoUsuario.Size = new Size(269, 38);
            buttonGrupoUsuario.TabIndex = 21;
            buttonGrupoUsuario.Text = "Grupo de Usuários";
            buttonGrupoUsuario.UseVisualStyleBackColor = false;
            buttonGrupoUsuario.Click += buttonGrupoUsuario_Click_1;
            // 
            // buttonEstatistica
            // 
            buttonEstatistica.BackColor = Color.White;
            buttonEstatistica.FlatStyle = FlatStyle.Flat;
            buttonEstatistica.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEstatistica.ForeColor = Color.FromArgb(50, 153, 204);
            buttonEstatistica.Location = new Point(9, 546);
            buttonEstatistica.Name = "buttonEstatistica";
            buttonEstatistica.Size = new Size(269, 44);
            buttonEstatistica.TabIndex = 12;
            buttonEstatistica.Text = "Estatística";
            buttonEstatistica.UseVisualStyleBackColor = false;
            buttonEstatistica.Click += buttonEstatistica_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.White;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(50, 153, 204);
            buttonProdutos.Location = new Point(9, 118);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(269, 38);
            buttonProdutos.TabIndex = 8;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.BackColor = Color.White;
            buttonFornecedores.FlatStyle = FlatStyle.Flat;
            buttonFornecedores.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFornecedores.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFornecedores.Location = new Point(9, 293);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(269, 38);
            buttonFornecedores.TabIndex = 9;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = false;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // buttonFuncionarios
            // 
            buttonFuncionarios.BackColor = Color.White;
            buttonFuncionarios.FlatStyle = FlatStyle.Flat;
            buttonFuncionarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFuncionarios.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFuncionarios.Location = new Point(9, 206);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(269, 38);
            buttonFuncionarios.TabIndex = 10;
            buttonFuncionarios.Text = "Funcionários";
            buttonFuncionarios.UseVisualStyleBackColor = false;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // button6
            // 
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(17, 360);
            button6.Name = "button6";
            button6.Size = new Size(261, 29);
            button6.TabIndex = 13;
            button6.Text = "Clientes";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(17, 325);
            button7.Name = "button7";
            button7.Size = new Size(261, 29);
            button7.TabIndex = 14;
            button7.Text = "Grupos de usuários";
            button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(17, 290);
            button4.Name = "button4";
            button4.Size = new Size(261, 29);
            button4.TabIndex = 11;
            button4.Text = "Clientes";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(17, 255);
            button5.Name = "button5";
            button5.Size = new Size(261, 29);
            button5.TabIndex = 12;
            button5.Text = "Grupos de usuários";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(17, 150);
            button1.Name = "button1";
            button1.Size = new Size(261, 29);
            button1.TabIndex = 8;
            button1.Text = "Usuários";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(17, 220);
            button2.Name = "button2";
            button2.Size = new Size(261, 29);
            button2.TabIndex = 9;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(17, 185);
            button3.Name = "button3";
            button3.Size = new Size(261, 29);
            button3.TabIndex = 10;
            button3.Text = "Grupos de usuários";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(61, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 4, 100, 4);
            label3.Size = new Size(176, 26);
            label3.TabIndex = 7;
            label3.Text = "MENU";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 470);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // labelNomeEmpresa
            // 
            labelNomeEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNomeEmpresa.AutoSize = true;
            labelNomeEmpresa.BackColor = Color.Transparent;
            labelNomeEmpresa.Cursor = Cursors.No;
            labelNomeEmpresa.FlatStyle = FlatStyle.Popup;
            labelNomeEmpresa.Font = new Font("Bernard MT Condensed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNomeEmpresa.ForeColor = Color.FromArgb(50, 153, 204);
            labelNomeEmpresa.Location = new Point(335, 0);
            labelNomeEmpresa.Name = "labelNomeEmpresa";
            labelNomeEmpresa.Size = new Size(225, 55);
            labelNomeEmpresa.TabIndex = 5;
            labelNomeEmpresa.Text = "SUPER TOP";
            labelNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            labelNomeEmpresa.Click += label2_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 936);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(921, 61);
            panel3.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(50, 153, 204);
            label4.Location = new Point(264, 540);
            label4.Name = "label4";
            label4.Size = new Size(521, 55);
            label4.TabIndex = 17;
            label4.Text = "Nome da Empresa";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(225, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(67, 52);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Coral;
            panel4.Controls.Add(buttonConsultarVenda);
            panel4.Controls.Add(buttonIniciarVenda);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(921, 82);
            panel4.TabIndex = 17;
            // 
            // buttonConsultarVenda
            // 
            buttonConsultarVenda.Anchor = AnchorStyles.Right;
            buttonConsultarVenda.FlatStyle = FlatStyle.Flat;
            buttonConsultarVenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonConsultarVenda.Location = new Point(512, 19);
            buttonConsultarVenda.Name = "buttonConsultarVenda";
            buttonConsultarVenda.Size = new Size(342, 45);
            buttonConsultarVenda.TabIndex = 20;
            buttonConsultarVenda.Text = "CONSULTAR VENDA";
            buttonConsultarVenda.UseVisualStyleBackColor = false;
            buttonConsultarVenda.Click += buttonConsultaVenda;
            // 
            // buttonIniciarVenda
            // 
            buttonIniciarVenda.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonIniciarVenda.FlatStyle = FlatStyle.Flat;
            buttonIniciarVenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonIniciarVenda.Location = new Point(20, 19);
            buttonIniciarVenda.Name = "buttonIniciarVenda";
            buttonIniciarVenda.Size = new Size(465, 45);
            buttonIniciarVenda.TabIndex = 17;
            buttonIniciarVenda.Text = "INICIAR VENDA";
            buttonIniciarVenda.UseVisualStyleBackColor = false;
            buttonIniciarVenda.Click += buttonIniciarVenda_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.settings_512px;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(860, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.carrinho_de_supermercado_canes_svg_med;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(0, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(921, 470);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1209, 936);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(labelNomeEmpresa);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1157, 733);
            Name = "FormPrincipal";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            ResizeEnd += FormPrincipal_ResizeEnd;
            KeyDown += FormPrincipal_KeyDown;
            Resize += FormPrincipal_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel3;
        private Label label4;
        private PictureBox pictureBoxLogo;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button buttonConsultarVenda;
        private Button buttonIniciarVenda;
        private Button buttonGrupoUsuario;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Button buttonMarcas;
        private Button buttonCategorias;
        private Button button8;
        private Button buttonPermissao;
        private ToolTip toolTip1;
    }
}

