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
    public partial class FormConsultaVenda : Form
    {
        private int id;

        public FormConsultaVenda()
        {
            InitializeComponent();
        }

        public FormConsultaVenda(int id)
        {
            this.id = id;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxVenda.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxVenda.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10030 } } };
                        bindingSourceVenda.DataSource = new ProdutoBLL().BuscarPorId(Convert.ToInt32(textBoxVenda.Text));
                        break;
                    case 1:
                        bindingSourceVenda.DataSource = new ProdutoBLL().BuscarPorNome(textBoxVenda.Text);
                        break;
                    case 2:
                        bindingSourceVenda.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxVenda.Text);
                        break;
                    case 3:
                        bindingSourceVenda.DataSource = new ProdutoBLL().BuscarTodos();
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceVenda.Count == 0)
                {
                    MessageBox.Show("Não existe venda para ser alterado.");
                    return;
                }

                int id = ((Venda)bindingSourceVenda.Current).Id;

                using (FormConsultaVenda frm = new FormConsultaVenda(id))
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
                using (FormConsultaVenda frm = new FormConsultaVenda())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
