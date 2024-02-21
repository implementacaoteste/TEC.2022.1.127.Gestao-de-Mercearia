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
            buttonConsultarVenda = new Button();
            buttonIniciarVenda = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            MENU = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            MENU.Location = new Point(155, 9);
            MENU.Name = "MENU";
            MENU.Size = new Size(180, 51);
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
            buttonUsuario.Location = new Point(15, 597);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(399, 73);
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
            buttonCliente.Location = new Point(15, 197);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(399, 74);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            panel2.Location = new Point(1208, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 1055);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 1014);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 11);
            panel1.TabIndex = 2;
            // 
            // buttonPagamento
            // 
            buttonPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPagamento.BackColor = Color.White;
            buttonPagamento.FlatStyle = FlatStyle.Flat;
            buttonPagamento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagamento.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPagamento.Location = new Point(15, 913);
            buttonPagamento.Name = "buttonPagamento";
            buttonPagamento.Size = new Size(399, 73);
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
            buttonPermissao.Location = new Point(15, 834);
            buttonPermissao.Name = "buttonPermissao";
            buttonPermissao.Size = new Size(399, 73);
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
            buttonCategorias.Location = new Point(15, 676);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(399, 73);
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
            buttonGrupoUsuario.Location = new Point(15, 517);
            buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            buttonGrupoUsuario.Size = new Size(399, 74);
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
            buttonFornecedores.Location = new Point(15, 437);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(399, 74);
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
            button8.Location = new Point(15, 357);
            button8.Name = "button8";
            button8.Size = new Size(399, 74);
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
            buttonFuncionarios.Location = new Point(15, 277);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(399, 74);
            buttonFuncionarios.TabIndex = 4;
            buttonFuncionarios.Text = "Funcionários";
            buttonFuncionarios.UseVisualStyleBackColor = false;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 9);
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
            panel5.Location = new Point(15, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 11);
            panel5.TabIndex = 1;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonProdutos.BackColor = Color.White;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(50, 153, 204);
            buttonProdutos.Location = new Point(15, 117);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(399, 73);
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
            buttonMarcas.Location = new Point(15, 755);
            buttonMarcas.Name = "buttonMarcas";
            buttonMarcas.Size = new Size(399, 73);
            buttonMarcas.TabIndex = 10;
            buttonMarcas.Text = "Marcas";
            buttonMarcas.UseVisualStyleBackColor = false;
            buttonMarcas.Click += buttonMarcas_Click;
            // 
            // pictureBoxEstatistica
            // 
            pictureBoxEstatistica.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxEstatistica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxEstatistica.BackColor = Color.Transparent;
            pictureBoxEstatistica.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEstatistica.Cursor = Cursors.Hand;
            pictureBoxEstatistica.ErrorImage = null;
            pictureBoxEstatistica.Image = (Image)resources.GetObject("pictureBoxEstatistica.Image");
            pictureBoxEstatistica.InitialImage = null;
            pictureBoxEstatistica.Location = new Point(918, 22);
            pictureBoxEstatistica.Margin = new Padding(3, 4, 3, 4);
            pictureBoxEstatistica.Name = "pictureBoxEstatistica";
            pictureBoxEstatistica.Size = new Size(134, 96);
            pictureBoxEstatistica.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEstatistica.TabIndex = 21;
            pictureBoxEstatistica.TabStop = false;
            pictureBoxEstatistica.Click += pictureBoxEstatistica_Click;
            // 
            // labelNomeEmpresa
            // 
            labelNomeEmpresa.Anchor = AnchorStyles.Top;
            labelNomeEmpresa.AutoSize = true;
            labelNomeEmpresa.BackColor = Color.Transparent;
            labelNomeEmpresa.Cursor = Cursors.No;
            labelNomeEmpresa.FlatStyle = FlatStyle.Popup;
            labelNomeEmpresa.Font = new Font("Bernard MT Condensed", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNomeEmpresa.ForeColor = Color.FromArgb(50, 153, 204);
            labelNomeEmpresa.Location = new Point(504, 0);
            labelNomeEmpresa.Name = "labelNomeEmpresa";
            labelNomeEmpresa.Size = new Size(229, 55);
            labelNomeEmpresa.TabIndex = 0;
            labelNomeEmpresa.Text = "MERCEARIA";
            labelNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(5, 1055);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(labelPDV);
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(1221, 91);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // labelPDV
            // 
            labelPDV.Anchor = AnchorStyles.None;
            labelPDV.AutoSize = true;
            labelPDV.BackColor = Color.FromArgb(50, 153, 204);
            labelPDV.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelPDV.ForeColor = Color.White;
            labelPDV.Location = new Point(383, 0);
            labelPDV.Name = "labelPDV";
            labelPDV.Size = new Size(410, 67);
            labelPDV.TabIndex = 2;
            labelPDV.Text = "CAIXA ABERTO";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxLogo.Anchor = AnchorStyles.Top;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Cursor = Cursors.No;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.shopping_cart_icon_illustration_free_vector2;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(414, 3);
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
            panel4.Controls.Add(pictureBoxEstatistica);
            panel4.Controls.Add(buttonConsultarVenda);
            panel4.Controls.Add(buttonIniciarVenda);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(1218, 135);
            panel4.TabIndex = 1;
            // 
            // buttonConsultarVenda
            // 
            buttonConsultarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonConsultarVenda.BackColor = Color.Coral;
            buttonConsultarVenda.FlatStyle = FlatStyle.Flat;
            buttonConsultarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonConsultarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultarVenda.Location = new Point(504, 22);
            buttonConsultarVenda.Name = "buttonConsultarVenda";
            buttonConsultarVenda.Size = new Size(392, 84);
            buttonConsultarVenda.TabIndex = 1;
            buttonConsultarVenda.Text = "CONSULTAR VENDA";
            buttonConsultarVenda.UseVisualStyleBackColor = false;
            buttonConsultarVenda.Click += buttonConsultaVenda;
            // 
            // buttonIniciarVenda
            // 
            buttonIniciarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonIniciarVenda.FlatStyle = FlatStyle.Flat;
            buttonIniciarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonIniciarVenda.Location = new Point(33, 22);
            buttonIniciarVenda.Name = "buttonIniciarVenda";
            buttonIniciarVenda.Size = new Size(435, 84);
            buttonIniciarVenda.TabIndex = 0;
            buttonIniciarVenda.Text = "PONTO DE VENDA";
            buttonIniciarVenda.UseVisualStyleBackColor = false;
            buttonIniciarVenda.Click += buttonIniciarVenda_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.settings_512px;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(1069, 24);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 94);
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
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(-22, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1243, 861);
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
            ClientSize = new Size(1634, 1055);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(labelNomeEmpresa);
            Controls.Add(pictureBox2);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1156, 723);
            Name = "FormPrincipal";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Button buttonPagamento;
        private PictureBox pictureBoxEstatistica;
        private Panel panel1;
        private Label labelPDV;
    }
}

