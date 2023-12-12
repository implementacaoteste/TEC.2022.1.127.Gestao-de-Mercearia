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
    public partial class FormeCadastroEstoque : Form
    {
        int id;
        public FormeCadastroEstoque(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    ((Estoque)bindingSourceEstoque.Current).Produto = frm.produto;
                    textBoxNomeProduto.Text = frm.produto.Nome;
                    ((Estoque)bindingSourceEstoque.Current).IdProduto = frm.produto.Id;
                }
            }
        }
    }
}
