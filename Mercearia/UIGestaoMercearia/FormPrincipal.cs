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
                label2.Text = Constantes.NomeEmpresa;
                labelNomeEmpresa.Text = Constantes.NomeEmpresa;
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

        private void buttonGrupoUsuario_Click(object sender, EventArgs e)
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

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
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

        }

        private void buttonEstoque_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
