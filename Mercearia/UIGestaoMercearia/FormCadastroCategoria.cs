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
    public partial class FormCadastroCategoria : Form
    {
        int id;
        public FormCadastroCategoria(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
