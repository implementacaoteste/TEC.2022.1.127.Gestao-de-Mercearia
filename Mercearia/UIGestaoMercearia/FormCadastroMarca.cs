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
    public partial class FormCadastroMarca : Form
    {
        int id;
        public FormCadastroMarca(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
    }
}
