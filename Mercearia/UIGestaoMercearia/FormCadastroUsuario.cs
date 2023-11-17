using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormCadastroUsuario : Form
    {
        public int Id;

        public FormCadastroUsuario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();

                if (Id == 0)
                    new UsuarioBLL().Inserir((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);
                else
                    new UsuarioBLL().Alterar((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();

            }
            catch (Exception ex)
            {
                if (new TratarErro().GetId(ex) == 1)
                    senhaTextBox.Focus();

                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    usuarioBindingSource.AddNew();
                else
                    usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }


        private void cPFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cPFLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nomeUsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void ativoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
