using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdCliente { get; set; }
        public int? IdFormaPagamento { get; set; }
        public DateTime DataVenda  { get; set; }
        public double Total { get; set; }
    }
}
