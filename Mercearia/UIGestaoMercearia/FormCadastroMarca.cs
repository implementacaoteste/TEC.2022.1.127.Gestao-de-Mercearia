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
    public partial class FormCadastroMarca : Form
    {
        int id;
        public FormCadastroMarca(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                marcaBindingSource.EndEdit();
                Marca marca = (Marca)marcaBindingSource.Current;

                if (id == 0)
                    new MarcaBLL().Inserir(marca);
                else
                    new MarcaBLL().Alterar(marca);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroMarca_Load(object sender, EventArgs e)
        {
            if (id == 0)
                marcaBindingSource.AddNew();
            else
                marcaBindingSource.DataSource = new MarcaBLL().BuscarPorId(id);
        }
    }
}
