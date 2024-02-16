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
            panel2 = new Panel();
            pictureBoxEstatistica = new PictureBox();
            buttonPagamento = new Button();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            buttonPermissao = new Button();
            buttonProdutos = new Button();
            buttonFuncionarios = new Button();
            button8 = new Button();
            buttonGrupoUsuario = new Button();
            buttonMarcas = new Button();
            buttonFornecedores = new Button();
            buttonCategorias = new Button();
            labelNomeEmpresa = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitter1 = new Splitter();
            panel3 = new Panel();
            pictureBoxLogo = new PictureBox();
            panel4 = new Panel();
            buttonConsultarVenda = new Button();
            buttonIniciarVenda = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            MENU = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).BeginInit();
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
            label1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 13);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 0;
            label1.Text = "CAIXA ABERTO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MENU
            // 
            MENU.Anchor = AnchorStyles.Top;
            MENU.BackColor = Color.FromArgb(50, 153, 204);
            MENU.Cursor = Cursors.No;
            MENU.FlatStyle = FlatStyle.Popup;
            MENU.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            MENU.ForeColor = Color.White;
            MENU.Location = new Point(80, 10);
            MENU.Name = "MENU";
            MENU.Size = new Size(247, 38);
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
            buttonUsuario.Location = new Point(13, 415);
            buttonUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(355, 50);
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
            buttonCliente.Location = new Point(13, 146);
            buttonCliente.Margin = new Padding(3, 2, 3, 2);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(355, 51);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(50, 153, 204);
            panel2.Controls.Add(pictureBoxEstatistica);
            panel2.Controls.Add(buttonPagamento);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(MENU);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(buttonCliente);
            panel2.Controls.Add(buttonPermissao);
            panel2.Controls.Add(buttonProdutos);
            panel2.Controls.Add(buttonFuncionarios);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(buttonGrupoUsuario);
            panel2.Controls.Add(buttonUsuario);
            panel2.Controls.Add(buttonMarcas);
            panel2.Controls.Add(buttonFornecedores);
            panel2.Controls.Add(buttonCategorias);
            panel2.Location = new Point(783, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 976);
            panel2.TabIndex = 3;
            // 
            // pictureBoxEstatistica
            // 
            pictureBoxEstatistica.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxEstatistica.Anchor = AnchorStyles.Right;
            pictureBoxEstatistica.BackColor = Color.Transparent;
            pictureBoxEstatistica.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEstatistica.Cursor = Cursors.Hand;
            pictureBoxEstatistica.ErrorImage = null;
            pictureBoxEstatistica.Image = (Image)resources.GetObject("pictureBoxEstatistica.Image");
            pictureBoxEstatistica.InitialImage = null;
            pictureBoxEstatistica.Location = new Point(21, 772);
            pictureBoxEstatistica.Margin = new Padding(3, 2, 3, 2);
            pictureBoxEstatistica.Name = "pictureBoxEstatistica";
            pictureBoxEstatistica.Size = new Size(355, 110);
            pictureBoxEstatistica.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEstatistica.TabIndex = 21;
            pictureBoxEstatistica.TabStop = false;
            pictureBoxEstatistica.Click += pictureBoxEstatistica_Click;
            // 
            // buttonPagamento
            // 
            buttonPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPagamento.BackColor = Color.White;
            buttonPagamento.FlatStyle = FlatStyle.Flat;
            buttonPagamento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagamento.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPagamento.Location = new Point(13, 624);
            buttonPagamento.Margin = new Padding(3, 2, 3, 2);
            buttonPagamento.Name = "buttonPagamento";
            buttonPagamento.Size = new Size(355, 44);
            buttonPagamento.TabIndex = 27;
            buttonPagamento.Text = "Formas de Pagamento";
            buttonPagamento.UseVisualStyleBackColor = false;
            buttonPagamento.Click += buttonPagamento_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Location = new Point(10, 62);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(358, 8);
            panel5.TabIndex = 1;
            // 
            // buttonPermissao
            // 
            buttonPermissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPermissao.BackColor = Color.White;
            buttonPermissao.FlatStyle = FlatStyle.Flat;
            buttonPermissao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPermissao.ForeColor = Color.FromArgb(50, 153, 204);
            buttonPermissao.Location = new Point(13, 572);
            buttonPermissao.Margin = new Padding(3, 2, 3, 2);
            buttonPermissao.Name = "buttonPermissao";
            buttonPermissao.Size = new Size(355, 47);
            buttonPermissao.TabIndex = 25;
            buttonPermissao.Text = "Permissões";
            buttonPermissao.UseVisualStyleBackColor = false;
            buttonPermissao.Click += button9_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonProdutos.BackColor = Color.White;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(50, 153, 204);
            buttonProdutos.Location = new Point(13, 89);
            buttonProdutos.Margin = new Padding(3, 2, 3, 2);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(355, 52);
            buttonProdutos.TabIndex = 2;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonFuncionarios
            // 
            buttonFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFuncionarios.BackColor = Color.White;
            buttonFuncionarios.FlatStyle = FlatStyle.Flat;
            buttonFuncionarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFuncionarios.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFuncionarios.Location = new Point(13, 201);
            buttonFuncionarios.Margin = new Padding(3, 2, 3, 2);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(355, 50);
            buttonFuncionarios.TabIndex = 4;
            buttonFuncionarios.Text = "Funcionários";
            buttonFuncionarios.UseVisualStyleBackColor = false;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(50, 153, 204);
            button8.Location = new Point(13, 255);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(355, 47);
            button8.TabIndex = 5;
            button8.Text = "Estoque";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // buttonGrupoUsuario
            // 
            buttonGrupoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGrupoUsuario.BackColor = Color.White;
            buttonGrupoUsuario.FlatStyle = FlatStyle.Flat;
            buttonGrupoUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGrupoUsuario.ForeColor = Color.FromArgb(50, 153, 204);
            buttonGrupoUsuario.Location = new Point(13, 361);
            buttonGrupoUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            buttonGrupoUsuario.Size = new Size(355, 50);
            buttonGrupoUsuario.TabIndex = 2;
            buttonGrupoUsuario.Text = "Grupo de Usuários";
            buttonGrupoUsuario.UseVisualStyleBackColor = false;
            buttonGrupoUsuario.Click += buttonGrupoUsuario_Click_1;
            // 
            // buttonMarcas
            // 
            buttonMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonMarcas.BackColor = Color.White;
            buttonMarcas.FlatStyle = FlatStyle.Flat;
            buttonMarcas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMarcas.ForeColor = Color.FromArgb(50, 153, 204);
            buttonMarcas.Location = new Point(13, 520);
            buttonMarcas.Margin = new Padding(3, 2, 3, 2);
            buttonMarcas.Name = "buttonMarcas";
            buttonMarcas.Size = new Size(355, 47);
            buttonMarcas.TabIndex = 10;
            buttonMarcas.Text = "Marcas";
            buttonMarcas.UseVisualStyleBackColor = false;
            buttonMarcas.Click += buttonMarcas_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFornecedores.BackColor = Color.White;
            buttonFornecedores.FlatStyle = FlatStyle.Flat;
            buttonFornecedores.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFornecedores.ForeColor = Color.FromArgb(50, 153, 204);
            buttonFornecedores.Location = new Point(13, 307);
            buttonFornecedores.Margin = new Padding(3, 2, 3, 2);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(355, 50);
            buttonFornecedores.TabIndex = 9;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = false;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // buttonCategorias
            // 
            buttonCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCategorias.BackColor = Color.White;
            buttonCategorias.FlatStyle = FlatStyle.Flat;
            buttonCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategorias.ForeColor = Color.FromArgb(50, 153, 204);
            buttonCategorias.Location = new Point(13, 469);
            buttonCategorias.Margin = new Padding(3, 2, 3, 2);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(355, 47);
            buttonCategorias.TabIndex = 9;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = false;
            buttonCategorias.Click += buttonCategorias_Click;
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
            labelNomeEmpresa.Location = new Point(374, 0);
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
            splitter1.Size = new Size(4, 747);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(50, 153, 204);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 44);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 51);
            panel3.TabIndex = 0;
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
            pictureBoxLogo.Location = new Point(295, 2);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(59, 39);
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
            panel4.Location = new Point(0, 94);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(786, 100);
            panel4.TabIndex = 1;
            // 
            // buttonConsultarVenda
            // 
            buttonConsultarVenda.Anchor = AnchorStyles.Right;
            buttonConsultarVenda.BackColor = Color.Coral;
            buttonConsultarVenda.FlatStyle = FlatStyle.Flat;
            buttonConsultarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonConsultarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultarVenda.Location = new Point(272, 22);
            buttonConsultarVenda.Margin = new Padding(9, 8, 9, 8);
            buttonConsultarVenda.Name = "buttonConsultarVenda";
            buttonConsultarVenda.Size = new Size(384, 61);
            buttonConsultarVenda.TabIndex = 1;
            buttonConsultarVenda.Text = "CONSULTAR VENDA";
            buttonConsultarVenda.UseVisualStyleBackColor = false;
            buttonConsultarVenda.Click += buttonConsultaVenda;
            // 
            // buttonIniciarVenda
            // 
            buttonIniciarVenda.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonIniciarVenda.FlatStyle = FlatStyle.Flat;
            buttonIniciarVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciarVenda.ForeColor = SystemColors.ButtonHighlight;
            buttonIniciarVenda.Location = new Point(19, 22);
            buttonIniciarVenda.Margin = new Padding(3, 2, 3, 2);
            buttonIniciarVenda.Name = "buttonIniciarVenda";
            buttonIniciarVenda.Size = new Size(242, 61);
            buttonIniciarVenda.TabIndex = 0;
            buttonIniciarVenda.Text = "PDV";
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
            pictureBox3.Location = new Point(683, 15);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 68);
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
            pictureBox2.Location = new Point(0, 191);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(783, 785);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(998, 747);
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
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1014, 554);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstatistica).EndInit();
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
    }
}

