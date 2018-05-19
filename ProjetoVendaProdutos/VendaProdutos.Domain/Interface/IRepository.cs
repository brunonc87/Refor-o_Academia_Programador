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
    }
}
