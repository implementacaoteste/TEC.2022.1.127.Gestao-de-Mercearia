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
                textBoxTroco.Visible = true;
                label2.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
                label9.Visible = true;
                textBoxFormaPagamento.Text = _formaPagamento.Tipo;
            }
            else if (_formaPagamento.Tipo == "PIX")
            {
                pictureBox1.Visible = true;
            }
        }
        private void textBoxValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (e.KeyChar == (char)Keys.Enter)
            {

                if (!string.IsNullOrEmpty(textBoxValorPago.Text))


                    textBoxValorPago.Text = null;
                textBoxValorPago.Focus();
                if (e.KeyChar == (char)Keys.Enter)
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
                textBoxValorPago.Focus();
            }
        }
        private void AdicionarTroco()
        {



            double troco;
            if (Convert.ToDouble(textBoxValorPago.Text) != 0)
            {

                troco = Convert.ToDouble(textBoxValorPago.Text) - totalVenda;
                textBoxTroco.Text = troco.ToString();
                labelTroco.Text = troco.ToString();
            }
        }
        private void textBoxTroco_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxValorPago.Focus();
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxTroco.Text))
            {
                AdicionarTroco();
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {


            ((ItemVenda)bindingSourceFinalizarVenda.Current).Troco = ((ItemVenda)bindingSourceFinalizarVenda.Current).ValorPago - ((ItemVenda)bindingSourceFinalizarVenda.Current).SubTotal;
            textBoxTroco.Text = $"{((Venda)bindingSourceFinalizarVenda.Current).Total:F2}";



        }

        private void FormFinalizarVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
