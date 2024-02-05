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

        }



        private void buttonAlterarSenha_Click(object sender, EventArgs e)
        {
            
                try
                {
                string senhaAtual = textBoxSenha.Text; 

                
                if (senhaAtual != usuario.Senha)
                {
                    MessageBox.Show("Senha incorreta!");
                    return; 
                }


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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarNomeUsuario_Click(object sender, EventArgs e)
        {
            
                try
                {
                string nomeUsuarioAtual = textBoxNomeUsuario.Text;

                
                if (nomeUsuarioAtual != usuario.NomeUsuario)
                {
                    MessageBox.Show("Nome de usuário incorreto");
                    return; 
                }



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


}