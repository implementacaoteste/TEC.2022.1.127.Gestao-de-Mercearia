using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class VendaBLL
    {
        public void Inserir(Venda _venda)
        {
            new VendaDAL().Inserir(_venda);
        }
        public List<Venda> BuscarTodos()
        {
            return new VendaDAL().BuscarTodos();
        }
        public Venda BuscarPorId(int _id)
        {
            return new VendaDAL().BuscarPorId(_id);
        }
        public void Excluir(int _id)
        {
            new VendaDAL().Excluir(_id);
        }

    }
}
