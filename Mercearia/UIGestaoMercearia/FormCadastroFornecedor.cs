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
    public partial class FormCadastroFornecedor : Form
    {
        int id;
        public FormCadastroFornecedor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
