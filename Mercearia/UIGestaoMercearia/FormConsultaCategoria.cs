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
    public partial class FormConsultaCategoria : Form
    {
        public FormConsultaCategoria()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(comboBoxBuscarPor.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };
                        bindingSourceCategoria.DataSource = new CategoriaBLL().BuscarPorId(Convert.ToInt32(comboBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourceCategoria.DataSource = new CategoriaBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceCategoria.Count == 0)
                {
                    MessageBox.Show("Não existe categoria para ser alterado.");
                    return;
                }

                int id = ((Categoria)bindingSourceCategoria.Current).Id;

                using (FormCadastroCategoria frm = new FormCadastroCategoria(id))
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

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroCategoria frm = new FormCadastroCategoria())
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
                if (bindingSourceCategoria.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Categoria)bindingSourceCategoria.Current).Id;
                new CategoriaBLL().Excluir(id);
                bindingSourceCategoria.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
