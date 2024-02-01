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
    public partial class FormCadastroPagamento : Form
    {
        int id;
        public FormCadastroPagamento(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroPagamento_Load(object sender, EventArgs e)
        {
            if (id == 0)
                formaPagamentoBindingSource.AddNew();
            else
                formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                formaPagamentoBindingSource.EndEdit();
                FormaPagamento pagamento = (FormaPagamento)formaPagamentoBindingSource.Current;

                if (id == 0)
                    new FormaPagamentoBLL().Inserir(pagamento);
                else
                    new FormaPagamentoBLL().Alterar(pagamento);
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
