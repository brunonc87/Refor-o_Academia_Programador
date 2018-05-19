using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaProdutos.Domain.Abstract;
using VendaProdutos.Domain.Interface;

namespace VendaProdutos.Applications.Abstract
{
    public abstract class Service<T> where T : Entidade
    {
        IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }


        public T Adicionar(T entidade)
        {
            entidade.Validar();
            return _repository.Adicionar(entidade);
        }

        public void Editar(T entidade)
        {
            entidade.Validar();
            _repository.Editar(entidade);
        }

        public void Excluir(T entidade)
        {
            _repository.Excluir(entidade.Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T Get(int Id)
        {
            return _repository.GetById(Id);

        }
    }
}
