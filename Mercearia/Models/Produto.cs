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
        public string CodigoDeBarra { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdFornecedor { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string NomeFornecedor 
        {
            get
            {
                if(Fornecedor == null)
                    return string.Empty;
                return Fornecedor.Nome;
            } 
        }

    }
}
