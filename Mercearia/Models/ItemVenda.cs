using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double SubTotal { get; set; }
        public Produto Produto { get; set; }
        public string NomeProduto
        {
            get
            {
                if (Produto == null)
                    return string.Empty;
                return Produto.Nome;
            }
        }
    }
}
