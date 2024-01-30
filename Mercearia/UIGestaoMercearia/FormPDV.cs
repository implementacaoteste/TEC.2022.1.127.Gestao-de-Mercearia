using BLL;
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
        int id;
        Venda venda;
        public FormPDV(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormPDV_Load(object sender, EventArgs e)
        {
            DateTime dataAgora = DateTime.Now;

            venda = new Venda()
            {
                IdCliente = null,
                IdFormaPagamento = null,
                IdFuncionario = null,
                Total = 0,
                DataVenda = dataAgora,

            };
            new VendaBLL().Inserir(venda);


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    ItemVenda current = ((ItemVenda)bindingSourcePDV.Current);
                    current.Produto = frm.produto;
                    textBoxCodigoDeBarras.Text = frm.produto.Nome;
                    current.Id = frm.produto.Id;
                }
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBoxCodigoDeBarras.Text))
                    textBoxQuantidade.Focus();
                else
                {
                    Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxCodigoDeBarras.Text);
                    if (produto.Id == 0)
                    {
                        MessageBox.Show("Produto não encontrado.");
                        textBoxCodigoDeBarras.SelectAll();
                        return;
                    }

                    bindingSourcePDV.AddNew();
                    ((ItemVenda)bindingSourcePDV.Current).Produto = produto;
                    ((ItemVenda)bindingSourcePDV.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                    ((ItemVenda)bindingSourcePDV.Current).SubTotal = Convert.ToInt32(textBoxQuantidade.Text) * ((ItemVenda)bindingSourcePDV.Current).Produto.Preco;
                    ((ItemVenda)bindingSourcePDV.Current).ValorUnitario = produto.Preco;
                    venda.Total += ((ItemVenda)bindingSourcePDV.Current).SubTotal;
                    labelSubTT.Text = (Convert.ToDouble(labelSubTT.Text) + ((ItemVenda)bindingSourcePDV.Current).SubTotal).ToString();
                    bindingSourcePDV.EndEdit();
                    textBoxQuantidade.Text = "1";
                    textBoxCodigoDeBarras.Text = "";
                    textBoxCodigoDeBarras.Focus();
                }
            }
        }

        private void textBoxQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxCodigoDeBarras.Focus();
            }
        }


        private void labelSubTT_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            //Finalizar os dados da venda
            new VendaBLL().Alterar(venda);
        }
    }
}
