using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SenhaBLL
    {
        public void Inserir(Senha _senha)
        {
            new SenhaDAL().Inserir(_senha);
        }
        public List<Senha> BuscarTodos()
        {
            return new SenhaDAL().BuscarTodos();
        }
        public void Excluir(int _id)
        {
            new SenhaDAL().Excluir(_id);
        }
    }
}
