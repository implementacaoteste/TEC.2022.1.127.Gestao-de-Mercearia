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
    public partial class FormConsultaFuncionario : Form
    {
        private BindingSource bindingSourceFuncionario = new BindingSource();


        public FormConsultaFuncionario()
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
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 10130 } } };
                        funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 1:
                        funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarTodos();
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

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroFuncionario frm = new FormCadastroFuncionario())
            {
                frm.ShowDialog();

            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceFuncionario.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Funcionario)bindingSourceFuncionario.Current).Id;
                new FuncionarioBLL().Excluir(id);
                bindingSourceFuncionario.RemoveCurrent();
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
                if (bindingSourceFuncionario.Count == 0)
                {
                    MessageBox.Show("Não existe produto para ser alterado.");
                    return;
                }

                int id = ((Funcionario)bindingSourceFuncionario.Current).Id;

                using (FormCadastroFuncionario frm = new FormCadastroFuncionario(id))
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

    }
}







        
    

