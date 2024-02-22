using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Runtime.InteropServices;
using Models;

namespace UIGestaoMercearia
{
    public partial class FormEstatistica : Form
    {
        Estatistica estatistica;
        public FormEstatistica()
        {
            InitializeComponent();
        }

        private void FormEstatistica_Load(object sender, EventArgs e)
        {
            estatistica = new Estatistica();
            //$" {frm.produto.Preco:C}";
            //labelGanhos = 
        }

        private void FormEstatistica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
