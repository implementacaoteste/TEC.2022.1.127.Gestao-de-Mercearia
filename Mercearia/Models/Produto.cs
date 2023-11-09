using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string CodigoDeBarra { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public int IdFornecedor { get; set; }

    }
}
