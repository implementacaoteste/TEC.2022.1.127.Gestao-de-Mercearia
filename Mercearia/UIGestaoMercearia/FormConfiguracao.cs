using BLL;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormConfiguracao : Form
    {
        private Usuario usuario;
        public FormConfiguracao(int _id)
        {
            InitializeComponent();

            usuario = new UsuarioBLL().BuscarPorId(_id);

            textBoxNomeUsuario.Text = usuario.NomeUsuario;

            textBoxSenha.Text = usuario.Senha;
        }



        private void buttonAlterarSenha_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    usuario.Senha = textBoxNovaSenha.Text;
                    new UsuarioBLL().AlterarSenha(usuario, textBoxConfirmacaoSenha.Text);

                    MessageBox.Show("Senha alterada com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao alterar senha: {ex.Message}");
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarNomeUsuario_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    usuario.NomeUsuario = textBoxNomeUsuario.Text;
                    new UsuarioBLL().AlterarNomeUsuario(usuario);

                    MessageBox.Show("Nome de usuário alterado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao alterar nome de usuário: {ex.Message}");
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }


}