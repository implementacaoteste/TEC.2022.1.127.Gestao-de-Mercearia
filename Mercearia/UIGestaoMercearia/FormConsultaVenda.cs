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
                        bindingSourceVenda.DataSource = new VendaBLL().BuscarPorId(Convert.ToInt32(textBoxVenda.Text));
                        break;
                    default:
                        bindingSourceVenda.DataSource = new VendaBLL().BuscarTodos();
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
                using (FormPontodeVenda frm = new FormPontodeVenda())

                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceVenda.Count == 0)
                {
                    MessageBox.Show("Não existe Venda para ser selecionado.");
                    return;
                }


                Venda selectedVenda = (Venda)bindingSourceVenda.Current;


                MessageBox.Show($"Venda Selecionado:, Id: {selectedVenda.Id}");


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

        private void FormConsultaVenda_Load(object sender, EventArgs e)
        {
            HabilitarComponentes();
            comboBoxVenda.SelectedIndex = 1;
            buttonBuscar_Click(sender, e);
        }

        private void HabilitarComponentes()
        {
            HabilitarBotao(buttonInserir, new UsuarioBLL().ValidarPermissao(44, false));
            HabilitarBotao(buttonAlterar, new UsuarioBLL().ValidarPermissao(45, false));
            HabilitarBotao(buttonExcluir, new UsuarioBLL().ValidarPermissao(46, false));
        }
        private void HabilitarBotao(System.Windows.Forms.Button button, bool ativo)
        {
            if (ativo)
            {
                button.BackColor = Color.White;
                button.ForeColor = SystemColors.ControlText;
            }
            else
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = SystemColors.ControlText;
            }
            button.Enabled = ativo;
        }

        private void FormConsultaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}