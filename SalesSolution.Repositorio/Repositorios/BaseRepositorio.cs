using SalesSolution.Dominio.Contratos;
using System.Collections.Generic;

namespace SalesSolution.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        public BaseRepositorio()
        {

        }
        public void Adicionar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }



        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<TEntity> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
