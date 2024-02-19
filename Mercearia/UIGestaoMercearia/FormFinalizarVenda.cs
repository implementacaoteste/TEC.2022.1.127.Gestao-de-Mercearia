using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormFinalizarVenda : Form
    {
        private double totalVenda;
        public FormaPagamento FormaPagamento;
        public FormFinalizarVenda(FormaPagamento _formaPagamento, double _totalVenda)
        {
            InitializeComponent();
            totalVenda = _totalVenda;
            FormaPagamento = _formaPagamento;

            if (_formaPagamento.Tipo.ToUpper() == "DINHEIRO")
            {
                textBoxValorPago.Visible = true;
                textBoxTotal.Visible = true;
                textBoxTotal.Text = _totalVenda.ToString();
                labelValorPago.Visible = true;
                labelTotal.Visible = true;
                labelFormaPagamento.Visible = true;
                textBoxFormaPagamento.Text = _formaPagamento.Tipo;

            }
            else if (_formaPagamento.Tipo.ToUpper() == "PIX")
            {
                pictureBox1.Visible = true;
                labelFormaPagamento.Visible = true;
                textBoxFormaPagamento.Text = _formaPagamento.Tipo;
                textBoxTotal.Visible = true;
                textBoxTotal.Text = _totalVenda.ToString();
                labelExTroco.Visible = false;
                labelTroco.Visible = false;
                labelTotal.Visible = true;
            }
        }
        private void textBoxValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                if (string.IsNullOrEmpty(textBoxValorPago.Text))
                {
                    textBoxValorPago.Focus();

                }
                else
                {
                    e.Handled = true;
                    AdicionarTroco();
                }
            }
        }
        private void AdicionarTroco()
        {
            double troco;
            if (Convert.ToDouble(textBoxValorPago.Text) != 0)
            {

                troco = Convert.ToDouble(textBoxValorPago.Text) - totalVenda;
                labelTroco.Text = troco.ToString();
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Venda Concluída!");
            Close();
        }


        private void FormFinalizarVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdicionarTroco();
            else if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
            else if (e.KeyCode == Keys.F11)
                buttonBuscarFormaPagamento_Click(sender, e);
            else if (e.KeyCode == Keys.F12)
                buttonOk_Click(sender, e);
                
        }

        private void buttonBuscarFormaPagamento_Click(object sender, KeyEventArgs e)
        {

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

        private void labelTroco_Click(object sender, EventArgs e)
        {

        }
    }
}
