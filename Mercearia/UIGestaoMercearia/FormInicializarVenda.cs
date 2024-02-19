using BLL;
using Models;
using System.Security.Cryptography;
namespace UIGestaoMercearia
{
    public partial class FormPontoDeVenda : Form
    {
        int id;
        private object itemVenda;
        double total;

        public Produto produtoAtual { get; private set; }
        public FormPontoDeVenda(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    bindingSourceVenda.EndEdit();
                    Venda venda = (Venda)bindingSourceVenda.Current;

                    if (id == 0)
                        new VendaBLL().Inserir(venda);

                    MessageBox.Show("Registro salvo com sucesso!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void FormInicializarVenda_Load(object sender, EventArgs e)
        {
            bindingSourceVenda.AddNew();
            textBoxCodigodeBarras.Focus();

        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {
                    ((ItemVenda)bindingSourceVenda.Current).Produto = frm.produto;
                    textBoxCodigodeBarras.Text = frm.produto.CodigoDeBarra;
                    ((ItemVenda)bindingSourceVenda.Current).Id = frm.produto.Id;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (FormConsultaProduto frm = new FormConsultaProduto(true))
            {
                frm.ShowDialog();
                if (frm.produto != null)
                {

                    textBoxCodigodeBarras.Text = frm.produto.CodigoDeBarra;
                    labelNomeProduto.Text = frm.produto.Nome;
                    textBoxPrecoProduto.Text = $" {frm.produto.Preco:C}";


                }
            }
        }
        private void textBoxCodigodeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                buttonFinalizarVenda_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void AdicionarProduto()
        {
            Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxCodigodeBarras.Text);
            labelNomeProduto.Text = produto.Nome;
            labelpreco.Text = $" {produto.Preco:C}";
            itemVendaListBindingSource.AddNew();
            ((ItemVenda)itemVendaListBindingSource.Current).Produto = produto;
            ((ItemVenda)itemVendaListBindingSource.Current).ValorUnitario = produto.Preco;
            ((ItemVenda)itemVendaListBindingSource.Current).Quantidade = Convert.ToDouble(textBoxQuantidade.Text);
            ((ItemVenda)itemVendaListBindingSource.Current).SubTotal = ((ItemVenda)itemVendaListBindingSource.Current).Quantidade * ((ItemVenda)itemVendaListBindingSource.Current).ValorUnitario;
            ((Venda)bindingSourceVenda.Current).Total += ((ItemVenda)itemVendaListBindingSource.Current).SubTotal;
            total = ((Venda)bindingSourceVenda.Current).Total;
            labelSubtotal.Text = $"subtotal: {((Venda)bindingSourceVenda.Current).Total:F2}";
            textBoxCodigodeBarras.Text = "";
            textBoxCodigodeBarras.Focus();
        }
        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    double.TryParse(labelpreco.Text, out double preco);
            //    double.TryParse(textBoxQuantidade.Text, out double quantidade);
            //    double subtotal = quantidade * preco;
            //    labelSubtotal.Text = $"subtotal: {Convert.ToDouble(labelSubtotal.Text) + subtotal:F2}";
            //    //e.Handled = true;
            //    textBoxCodigodeBarras.Focus();
            //}
        }

        private void textBoxCodigodeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBoxCodigodeBarras.Text))
                {
                    e.Handled = true;
                    AdicionarProduto();
                }
                else
                    textBoxQuantidade.Focus();
            }

            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    e.Handled = true;
            //    textBoxQuantidade.Focus();
            //}
        }

        private void textBoxQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxQuantidade.Text))
                textBoxCodigodeBarras.Focus();
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            textBoxCodigodeBarras.Text = "";
            labelpreco.Text = "";
            textBoxQuantidade.Text = "1";
            try
            {
                FormaPagamento formaPagamento = new FormaPagamento();
                using (FormPagamento frm = new FormPagamento(true))
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        formaPagamento = frm.pagamento;
                        if (formaPagamento.Tipo.ToUpper() == "DINHEIRO" || formaPagamento.Tipo.ToUpper() == "PIX")
                        {
                            using (FormFinalizarVenda formFinalizarVenda = new FormFinalizarVenda(formaPagamento, ((Venda)bindingSourceVenda.Current).Total))
                            {
                                formFinalizarVenda.ShowDialog();

                            }
                        }

                    }

                }
                ((Venda)bindingSourceVenda.Current).IdFormaPagamento = formaPagamento.Id;
                new VendaBLL().Inserir((Venda)bindingSourceVenda.Current);
                bindingSourceVenda.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}