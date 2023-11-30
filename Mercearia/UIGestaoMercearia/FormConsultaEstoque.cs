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
        public FormConsultaEstoque()
        {
            InitializeComponent();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
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

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
