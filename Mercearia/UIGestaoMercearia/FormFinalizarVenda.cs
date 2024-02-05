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
                textBoxDinheiro.Visible = true;
                textBoxTroco.Visible = true;
                label2.Visible = true;
                textBoxFormaPagamento.Text = _formaPagamento.Tipo;
            }
            else if (_formaPagamento.Tipo == "PIX")
            {
                pictureBox1.Visible = true;
            }

        }

        private void FormFinalizarVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
