using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaProdutos.Domain.Abstract;

namespace VendaProdutos.Applications.Abstract
{
    public abstract class Service<T> where T : Entidade
    {
    }
}
