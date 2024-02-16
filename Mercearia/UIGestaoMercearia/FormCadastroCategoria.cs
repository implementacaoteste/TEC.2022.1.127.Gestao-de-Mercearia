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
    public partial class FormCadastroCategoria : Form
    {
        int id;
        public FormCadastroCategoria(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroCategoria_Load(object sender, EventArgs e)
        {
            if (id == 0)
                categoriaBindingSource.AddNew();
            else
                categoriaBindingSource.DataSource = new CategoriaBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                categoriaBindingSource.EndEdit();
                Categoria categoria = (Categoria)categoriaBindingSource.Current;

                if (id == 0)
                    new CategoriaBLL().Inserir(categoria);
                else
                    new CategoriaBLL().Alterar(categoria);
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
    }
}
