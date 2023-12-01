using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormCadastroFuncionario : Form
    {
        public int Id { get; set; }

        public FormCadastroFuncionario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)bindingSourceCadastrarFuncionario.Current;

                bindingSourceCadastrarFuncionario.EndEdit();

                if (Id == 0)
                    new FuncionarioBLL().Inserir(funcionario);
                else
                    new FuncionarioBLL().Alterar(funcionario);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceCadastrarFuncionario_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                bindingSourceCadastrarFuncionario.AddNew();
            else
                bindingSourceCadastrarFuncionario.DataSource = new FuncionarioBLL().BuscarPorId(Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
