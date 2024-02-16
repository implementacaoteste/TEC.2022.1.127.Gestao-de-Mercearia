﻿using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormConsultaCliente : Form
    {
        public FormConsultaCliente()
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
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };

                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorCPF(textBoxBuscar.Text);
                        break;
                    case 3:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarTodos();
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Cliente)clienteBindingSource.Current).Id;
                new ClienteBLL().Excluir(id);
                clienteBindingSource.RemoveCurrent();
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
                using (FormCadastroCliente frm = new FormCadastroCliente())
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
                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser alterado.");
                    return;
                }

                int id = ((Cliente)clienteBindingSource.Current).Id;

                using (FormCadastroCliente frm = new FormCadastroCliente(id))
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

        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 3;
            HabilitarComponentes();
        }

        private void HabilitarComponentes()
        {
            HabilitarBotao(buttonInserir, new UsuarioBLL().ValidarPermissao(40, false));
            HabilitarBotao(buttonAlterar, new UsuarioBLL().ValidarPermissao(41, false));
            HabilitarBotao(buttonExcluir, new UsuarioBLL().ValidarPermissao(42, false));
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

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser selecionado.");
                    return;
                }


                Cliente selectedCliente = (Cliente)clienteBindingSource.Current;


                MessageBox.Show($"Cliente Selecionado: {selectedCliente.Nome}, Id: {selectedCliente.Id}");


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
