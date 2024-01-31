using BLL;
using Models;
namespace UIGestaoMercearia
{
    public partial class FormInicializarVenda : Form
    {
        int id;
        private object itemVenda;

        public Produto produtoAtual { get; private set; }

        public FormInicializarVenda(int _id = 0)
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
            /*
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Venda(IdFuncionario, IdCliente, IdFormaPagamento, DataVenda, Total) VALUES (@IdFuncionario, @IdCliente, @IdFormaPagamento, @DataVenda, @Total)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdFuncionario", Constantes.IdUsuarioLogado);
                cmd.Parameters.AddWithValue("@IdCliente", null);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", null);
                cmd.Parameters.AddWithValue("@DataVenda", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Total", 0);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorre um erro ao abrir uma venda no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }*/
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
            if (e.KeyCode == Keys.Enter)
            {
                AdicionarProduto();
            }
        }
        private void AdicionarProduto()
        {
            Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxCodigodeBarras.Text);
            labelNomeProduto.Text = produto.Nome;
            labelpreco.Text = $" {produto.Preco:C}";

            ItemVenda itemVenda = new ItemVenda();
            itemVenda.Produto = produto;
            itemVenda.ValorUnitario = produto.Preco;
            itemVenda.Quantidade = produto.Quantidade;


        }
        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            ItemVenda itemVenda = new ItemVenda();
            itemVenda.Quantidade = Convert.ToDouble(textBoxQuantidade.Text);
        }
        private void textBoxValorPago_TextChanged(object sender, EventArgs e)
        {
            ItemVenda itemVenda = new ItemVenda();
            itemVenda.ValorPago = (int)Convert.ToDouble(textBoxValorPago.Text);
        }


    }
}

