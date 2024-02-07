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
        public FormFinalizarVenda(FormaPagamento _formaPagamento)
        {
            InitializeComponent();
            if (_formaPagamento.Tipo.ToUpper() == "DINHEIRO")
            {
                textBoxValorPago.Visible = true;
                textBoxTroco.Visible = true;
                label2.Visible = true;
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
                {
                    e.Handled = true;
                    AdicionarTroco();
                }
            }
            textBoxValorPago.Focus();
        }
        private void AdicionarTroco()
        {
            
            if (Convert.ToDouble(textBoxValorPago.Text) !=  0)
            {
                
                ((ItemVenda)bindingSourceFinalizarVenda.Current).Troco = ((ItemVenda)bindingSourceFinalizarVenda.Current).ValorPago - ((ItemVenda)bindingSourceFinalizarVenda.Current).SubTotal;
                textBoxTroco.Text = $"{((Venda)bindingSourceFinalizarVenda.Current).Total:F2}";
            }
        }        
        private void textBoxTroco_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxValorPago.Focus();
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxTroco.Text));
                
        }
    }
}
