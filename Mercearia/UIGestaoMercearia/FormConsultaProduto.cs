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
    public partial class FormConsultaProduto : Form
    {

        public FormConsultaProduto()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxProduto.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxProduto.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };

                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorId(Convert.ToInt32(textBoxProduto.Text));
                        break;
                    case 1:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorNome(textBoxProduto.Text);
                        break;
                    case 2:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxProduto.Text);
                        break;
                    case 3:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarTodos();
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

        private void button4_Click(object sender, EventArgs e)
        { //excluir
            try
            {
                if (bindingSourceProduto.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Produto)bindingSourceProduto.Current).Id;
                new ClienteBLL().Excluir(id);
                bindingSourceProduto.RemoveCurrent();
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceProduto.Count == 0)
                {
                    MessageBox.Show("Não existe produto para ser alterado.");
                    return;
                }

                int id = ((Cliente)bindingSourceProduto.Current).Id;

                /*using (FormCadastroProduto frm = new FormCadastroProduto(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);*/ //a ser implementado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
