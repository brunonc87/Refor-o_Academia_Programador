using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaProdutos.Domain.Abstract
{
    public abstract class Entidade
    {
        int Id;

        public abstract void Validar();
    }
}
