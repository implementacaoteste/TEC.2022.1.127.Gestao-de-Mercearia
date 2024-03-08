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
            Label MENU;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            buttonUsuario = new Button();
            buttonCliente = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonPagamento = new Button();
            buttonPermissao = new Button();
            buttonCategorias = new Button();
            buttonGrupoUsuario = new Button();
            buttonFornecedores = new Button();
            button8 = new Button();
            buttonFuncionarios = new Button();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            buttonProdutos = new Button();
            buttonMarcas = new Button();
            pictureBoxEstatistica = new PictureBox();
            labelNomeEmpresa = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitter1 = new Splitter();
            panel3 = new Panel();
            labelPDV = new Label();
            pictureBoxLogo = new PictureBox();
            panel4 = new Panel();
            pictureBoxConfiguração = new PictureBox();
            buttonIniciarVenda = new Button();
            buttonConsultarVenda = new Button();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            buttonAjuda = new Button();
            MENU = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfiguração).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MENU
            // 
            MENU.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MENU.BackColor = Color.FromArgb(50, 153, 204);
            MENU.Cursor = Cursors.No;
            MENU.FlatStyle = FlatStyle.Popup;
            MENU.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            MENU.ForeColor = Color.White;
            MENU.Location = new Point(136, 7);
            MENU.Name = "MENU";
            MENU.Size = new Size(136, 38);
            MENU.TabIndex = 0;
            MENU.Text = "MENU";
            MENU.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonUsuario
            // 
            buttonUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonUsuario.BackColor = Color.White;
            buttonUsuario.FlatStyle = FlatStyle.Flat;
            buttonUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonUsuario.Location = new Point(13, 388);
            buttonUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(327, 55);
            buttonUsuario.TabIndex = 8;
            buttonUsuario.Text = "Usuários";
            buttonUsuario.UseVisualStyleBackColor = false;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCliente.BackColor = Color.White;
            buttonCliente.FlatStyle = FlatStyle.Flat;
            buttonCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCliente.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCliente.Location = new Point(13, 148);
            buttonCliente.Margin = new Padding(3, 2, 3, 2);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(327, 56);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(buttonPagamento);
            panel2.Controls.Add(buttonPermissao);
            panel2.Controls.Add(buttonCategorias);
            panel2.Controls.Add(buttonGrupoUsuario);
            panel2.Controls.Add(buttonFornecedores);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(buttonCliente);
            panel2.Controls.Add(MENU);
            panel2.Controls.Add(buttonFuncionarios);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(buttonProdutos);
            panel2.Controls.Add(buttonUsuario);
            panel2.Controls.Add(buttonMarcas);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 837);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(10, 806);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 8);
            panel1.TabIndex = 2;
            // 
            // buttonPagamento
            // 
            buttonPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPagamento.BackColor = Color.White;
            buttonPagamento.FlatStyle = FlatStyle.Flat;
            buttonPagamento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagamento.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPagamento.Location = new Point(13, 685);
            buttonPagamento.Margin = new Padding(3, 2, 3, 2);
            buttonPagamento.Name = "buttonPagamento";
            buttonPagamento.Size = new Size(327, 55);
            buttonPagamento.TabIndex = 27;
            buttonPagamento.Text = "Formas de Pagamento";
            buttonPagamento.UseVisualStyleBackColor = false;
            buttonPagamento.Click += buttonPagamento_Click;
            // 
            // buttonPermissao
            // 
            buttonPermissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPermissao.BackColor = Color.White;
            buttonPermissao.FlatStyle = FlatStyle.Flat;
            buttonPermissao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPermissao.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPermissao.Location = new Point(13, 626);
            buttonPermissao.Margin = new Padding(3, 2, 3, 2);
            buttonPermissao.Name = "buttonPermissao";
            buttonPermissao.Size = new Size(327, 55);
            buttonPermissao.TabIndex = 25;
            buttonPermissao.Text = "Permissões";
            buttonPermissao.UseVisualStyleBackColor = false;
            buttonPermissao.Click += button9_Click;
            // 
            // buttonCategorias
            // 
            buttonCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCategorias.BackColor = Color.White;
            buttonCategorias.FlatStyle = FlatStyle.Flat;
            buttonCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategorias.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCategorias.Location = new Point(13, 507);
            buttonCategorias.Margin = new Padding(3, 2, 3, 2);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(327, 55);
            buttonCategorias.TabIndex = 9;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = false;
            buttonCategorias.Click += buttonCategorias_Click;
            // 
            // buttonGrupoUsuario
            // 
            buttonGrupoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGrupoUsuario.BackColor = Color.White;
            buttonGrupoUsuario.FlatStyle = FlatStyle.Flat;
            buttonGrupoUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGrupoUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonGrupoUsuario.Location = new Point(13, 447);
            buttonGrupoUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            buttonGrupoUsuario.Size = new Size(327, 56);
            buttonGrupoUsuario.TabIndex = 7;
            buttonGrupoUsuario.Text = "Grupo de Usuários";
            buttonGrupoUsuario.UseVisualStyleBackColor = false;
            buttonGrupoUsuario.Click += buttonGrupoUsuario_Click_1;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFornecedores.BackColor = Color.White;
            buttonFornecedores.FlatStyle = FlatStyle.Flat;
            buttonFornecedores.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFornecedores.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFornecedores.Location = new Point(13, 328);
            buttonFornecedores.Margin = new Padding(3, 2, 3, 2);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(327, 56);
            buttonFornecedores.TabIndex = 6;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = false;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(50, 153, 204);
            button8.Location = new Point(13, 268);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(327, 56);
            button8.TabIndex = 5;
            button8.Text = "Estoque";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // buttonFuncionarios
            // 
            buttonFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFuncionarios.BackColor = Color.White;
            buttonFuncionarios.FlatStyle = FlatStyle.Flat;
            buttonFuncionarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFuncionarios.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFuncionarios.Location = new Point(13, 208);
            buttonFuncionarios.Margin = new Padding(3, 2, 3, 2);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(327, 56);
            buttonFuncionarios.TabIndex = 4;
            buttonFuncionarios.Text = "Funcionários";
            buttonFuncionarios.UseVisualStyleBackColor = false;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Location = new Point(13, 62);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 8);
            panel5.TabIndex = 1;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonProdutos.BackColor = Color.White;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(50, 153, 204);
            buttonProdutos.Location = new Point(13, 88);
            buttonProdutos.Margin = new Padding(3, 2, 3, 2);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(327, 55);
            buttonProdutos.TabIndex = 2;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonMarcas
            // 
            buttonMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonMarcas.BackColor = Color.White;
            buttonMarcas.FlatStyle = FlatStyle.Flat;
            buttonMarcas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMarcas.ForeColor = Color.FromArgb(50, 153, 204);
            buttonMarcas.Location = new Point(13, 566);
            buttonMarcas.Margin = new Padding(3, 2, 3, 2);
            buttonMarcas.Name = "buttonMarcas";
            buttonMarcas.Size = new Size(327, 55);
            buttonMarcas.TabIndex = 10;
            buttonMarcas.Text = "Marcas";
            buttonMarcas.UseVisualStyleBackColor = false;
            buttonMarcas.Click += buttonMarcas_Click;
            // 
            // pictureBoxEstatistica
            // 
            pictureBoxEstatistica.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxEstatistica.BackColor = Color.Transparent;
            pictureBoxEstatistica.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEstatistica.Cursor = Cursors.Hand;
            pictureBoxEstatistica.ErrorImage = null;
            pictureBoxEstatistica.Image = (Image)resources.GetObject("pictureBoxEstatistica.Image");
            pictureBoxEstatistica.InitialImage = null;
            pictureBoxEstatistica.Location = new Point(20, 17);
            pictureBoxEstatistica.Name = "pictureBoxEstatistica";
            pictureBoxEstatistica.Size = new Size(117, 72);
            pictureBoxEstatistica.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEstatistica.TabIndex = 21;
            pictureBoxEstatistica.TabStop = false;
            pictureBoxEstatistica.Click += pictureBoxEstatistica_Click;
            // 
            // labelNomeEmpresa
            // 
            labelNomeEmpresa.Anchor = AnchorStyles.Right;
            labelNomeEmpresa.AutoSize = true;
            labelNomeEmpresa.BackColor = Color.Transparent;
            labelNomeEmpresa.Cursor = Cursors.No;
            labelNomeEmpresa.FlatStyle = FlatStyle.Popup;
            labelNomeEmpresa.Font = new Font("Bernard MT Condensed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNomeEmpresa.ForeColor = Color.FromArgb(50, 153, 204);
            labelNomeEmpresa.Location = new Point(784, 2);
            labelNomeEmpresa.Name = "labelNomeEmpresa";
            labelNomeEmpresa.Size = new Size(187, 45);
            labelNomeEmpresa.TabIndex = 0;
            labelNomeEmpresa.Text = "MERCEARIA";
            labelNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 2, 3, 2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 749);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(labelPDV);
            panel3.Location = new Point(349, 44);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1087, 68);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // labelPDV
            // 
            labelPDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPDV.AutoSize = true;
            labelPDV.BackColor = Color.FromArgb(50, 153, 204);
            labelPDV.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelPDV.ForeColor = Color.White;
            labelPDV.Location = new Point(344, 0);
            labelPDV.Name = "labelPDV";
            labelPDV.Size = new Size(328, 53);
            labelPDV.TabIndex = 2;
            labelPDV.Text = "CAIXA ABERTO";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.Anchor = AnchorStyles.Right;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(719, 3);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(59, 39);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Coral;
            panel4.Controls.Add(pictureBoxConfiguração);
            panel4.Controls.Add(pictureBoxEstatistica);
            panel4.Controls.Add(buttonIniciarVenda);
            panel4.Controls.Add(buttonConsultarVenda);
            panel4.Location = new Point(349, 107);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1085, 101);
            panel4.TabIndex = 1;
            // 
            // pictureBoxConfiguração
            // 
            pictureBoxConfiguração.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxConfiguração.BackColor = Color.Transparent;
            pictureBoxConfiguração.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxConfiguração.Cursor = Cursors.Hand;
            pictureBoxConfiguração.ErrorImage = null;
            pictureBoxConfiguração.Image = Properties.Resources.settings_512px;
            pictureBoxConfiguração.InitialImage = null;
            pictureBoxConfiguração.Location = new Point(153, 19);
            pictureBoxConfiguração.Name = "pictureBoxConfiguração";
            pictureBoxConfiguração.Size = new Size(100, 70);
            pictureBoxConfiguração.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConfiguração.TabIndex = 19;
            pictureBoxConfiguração.TabStop = false;
            pictureBoxConfiguração.Click += pictureBoxConfiguracao_Click;
            // 
            // buttonIniciarVenda
            // 
            buttonIniciarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonIniciarVenda.FlatStyle = FlatStyle.Flat;
            buttonIniciarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonIniciarVenda.Location = new Point(647, 26);
            buttonIniciarVenda.Margin = new Padding(3, 2, 3, 2);
            buttonIniciarVenda.Name = "buttonIniciarVenda";
            buttonIniciarVenda.Size = new Size(283, 63);
            buttonIniciarVenda.TabIndex = 0;
            buttonIniciarVenda.Text = "PONTO DE VENDA";
            buttonIniciarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonIniciarVenda.UseVisualStyleBackColor = false;
            buttonIniciarVenda.Click += buttonIniciarVenda_Click;
            // 
            // buttonConsultarVenda
            // 
            buttonConsultarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonConsultarVenda.BackColor = Color.Coral;
            buttonConsultarVenda.FlatStyle = FlatStyle.Flat;
            buttonConsultarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonConsultarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultarVenda.Location = new Point(279, 27);
            buttonConsultarVenda.Margin = new Padding(3, 2, 3, 2);
            buttonConsultarVenda.Name = "buttonConsultarVenda";
            buttonConsultarVenda.Size = new Size(343, 63);
            buttonConsultarVenda.TabIndex = 1;
            buttonConsultarVenda.Text = "CONSULTAR VENDA";
            buttonConsultarVenda.UseVisualStyleBackColor = false;
            buttonConsultarVenda.Click += buttonConsultaVenda;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(349, 201);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(943, 572);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // buttonAjuda
            // 
            buttonAjuda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAjuda.BackColor = Color.FromArgb(50, 153, 204);
            buttonAjuda.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAjuda.Cursor = Cursors.Help;
            buttonAjuda.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjuda.ForeColor = Color.White;
            buttonAjuda.Location = new Point(1223, 2);
            buttonAjuda.Margin = new Padding(3, 2, 3, 2);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(56, 39);
            buttonAjuda.TabIndex = 22;
            buttonAjuda.Text = "?";
            buttonAjuda.UseVisualStyleBackColor = false;
            buttonAjuda.Click += buttonAjuda_Click;
            buttonAjuda.KeyDown += buttonAjuda_KeyDown;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1291, 749);
            Controls.Add(buttonAjuda);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(labelNomeEmpresa);
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1014, 552);
            Name = "FormPrincipal";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            ResizeEnd += FormPrincipal_ResizeEnd;
            KeyDown += FormPrincipal_KeyDown;
            Resize += FormPrincipal_Resize;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfiguração).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonUsuario;
        private Button buttonCliente;
        private Label labelNomeEmpresa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Splitter splitter1;
        private Panel panel2;
        private Button buttonProdutos;
        private Button buttonFornecedores;
        private Button buttonFuncionarios;
        private Panel panel3;
        private PictureBox pictureBoxLogo;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxConfiguração;
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
        private Button buttonPagamento;
        private PictureBox pictureBoxEstatistica;
        private Panel panel1;
        private Label labelPDV;
        private Button buttonAjuda;
    }
}

