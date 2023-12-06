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
    public partial class FormCadastroProduto : Form
    {
        int id;
        public FormCadastroProduto(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    produtoBindingSource.AddNew();
                else
                    produtoBindingSource.DataSource = new ProdutoBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = (Produto)produtoBindingSource.Current;

                produtoBindingSource.EndEdit();

                if (id == 0)
                    new ProdutoBLL().Inserir(produto);
                else
                    new ProdutoBLL().Alterar(produto);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            using (FormConsultaFornecedor frm = new FormConsultaFornecedor(true))
            {
                frm.ShowDialog();
                if(frm.fornecedor != null)
                {
                    ((Produto)produtoBindingSource.Current).Fornecedor = frm.fornecedor;
                    textBoxNomeFornecedor.Text = frm.fornecedor.Nome;
                    ((Produto)produtoBindingSource.Current).IdFornecedor = frm.fornecedor.Id;
                }
            }

        }

        private void buttonBuscarMarca_Click(object sender, EventArgs e)
        {
            using (FormConsultaMarca frm = new FormConsultaMarca(true))
            {
                frm.ShowDialog();
                if (frm.marca != null)
                {
                    ((Produto)produtoBindingSource.Current).Marca = frm.marca;
                    textBoxNomeMarca.Text = frm.marca.Nome;
                    ((Produto)produtoBindingSource.Current).IdMarca = frm.marca.Id;
                }
            }
        }
    }
}
