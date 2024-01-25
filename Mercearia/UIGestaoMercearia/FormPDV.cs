using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormPDV : Form
    {
        public FormPDV()
        {
            InitializeComponent();
        }

        private void FormPDV_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ItemVenda() 
                                    VALUES()";
                cmd.CommandType = System.Data.CommandType.Text;

                //cmd.Parameters.AddWithValue("@SubTotal", );


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }


        private void Exibir()
        {
            string query = "select * from Produto";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    ((ItemVenda)bindingSourcePDV.Current).Produto = frm.produto;
                    textBoxNomeProduto.Text = frm.produto.Nome;
                    ((ItemVenda)bindingSourcePDV.Current).Id = frm.produto.Id;
                }
            }
        }
    }
}
