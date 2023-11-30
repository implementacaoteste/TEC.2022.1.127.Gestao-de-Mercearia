using Models;
using System;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                labelNomeEmpresa.Text = Constantes.NomeEmpresa;
                PosicionarTopo();
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarUsuario frm = new FormBuscarUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonCliente_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
        }
        private void PosicionarTopo()
        {
            //labelNomeEmpresa.Left = ((this.Width - panel2.Width) / 2) - labelNomeEmpresa.Width / 2 - (panel2.Width / 4);
            labelNomeEmpresa.Left = panel3.Width / 2 - labelNomeEmpresa.Width / 2;
            pictureBoxLogo.Left = labelNomeEmpresa.Left - pictureBoxLogo.Width;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto())
            {
                frm.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            using(FormConsultaFuncionario frm = new FormConsultaFuncionario())
            {
                frm.ShowDialog();
            }

        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            using (FormConsultaFornecedor frm = new FormConsultaFornecedor())
            {
                frm.ShowDialog();            
            }
        }

        private void buttonEstatistica_Click(object sender, EventArgs e)
        {
            using (FormEstatistica frm = new FormEstatistica())
            {
                frm.ShowDialog();
            }
        }

        private void buttonEstoque_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            PosicionarTopo();
        }

        private void FormPrincipal_ResizeEnd(object sender, EventArgs e)
        {
            PosicionarTopo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGrupoUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaCategoria frm = new FormConsultaCategoria())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaMarca frm = new FormConsultaMarca())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (FormConfiguracao frm = new FormConfiguracao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonConsultaVenda(object sender, EventArgs e)
        {
            using (FormConsultaVenda frm = new FormConsultaVenda())
            {
                frm.ShowDialog();
            }
        }

        private void buttonIniciarVenda_Click(object sender, EventArgs e)
        {
            using (FormInicializarVenda frm = new FormInicializarVenda())
            {
                frm.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (FormConsultaEstoque frm = new FormConsultaEstoque())
            {
                frm.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (FormConsultaPermissao frm = new FormConsultaPermissao())
            {
                frm.ShowDialog();
            }
        }
    }
}
