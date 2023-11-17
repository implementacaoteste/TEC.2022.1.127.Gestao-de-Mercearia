using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstoqueBLL
    {
        public void Inserir(Estoque _estoque)
        {
            new EstoqueDAL().Inserir(_estoque);
        }
        public void Alterar(Estoque _estoque)
        {
            new EstoqueDAL().Alterar(_estoque);
        }
        
        
    }
}
