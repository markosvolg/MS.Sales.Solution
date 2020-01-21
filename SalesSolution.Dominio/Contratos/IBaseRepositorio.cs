using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSolution.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IList<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
