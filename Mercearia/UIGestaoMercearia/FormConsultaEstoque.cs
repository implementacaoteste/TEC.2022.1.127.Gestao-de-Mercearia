using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoMercearia
{

    public partial class FormConsultaEstoque : Form
    {
        private BindingSource EstoqueBindingSource = new BindingSource();
        public int Id;
        public FormConsultaEstoque()
        {
            InitializeComponent();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceEstoque.Count > 0)
                {
                    Id = ((GrupoUsuario)bindingSourceEstoque.Current).Id;
                    Close();
                }
                else
                    MessageBox.Show("Não existe registro para ser selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaEstoque_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelecionar_Click_1(object sender, EventArgs e)
        {

        }

        private void labelGerenProd_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNomeGrupo(buttonBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (EstoqueBindingSource.Count == 0)
                    throw new Exception("Não existe grupo listado para ser alterado.");

                using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(((GrupoUsuario)EstoqueBindingSource.Current).Id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroProduto frm = new FormCadastroProduto())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstoqueBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Cliente)EstoqueBindingSource.Current).Id;
                new EstoqueBLL().Excluir(id);
                EstoqueBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

