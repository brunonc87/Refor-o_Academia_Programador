using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaProdutos.Domain.Abstract;

namespace VendaProdutos.Domain.Interface
{
    public interface IRepository<T> where T : Entidade
    {
        T Adicionar(T entidade);

        void Editar(T entidade);

        void Excluir(int Id);

        IEnumerable<T> GetAll();

        T GetById(int Id);
    }
}
