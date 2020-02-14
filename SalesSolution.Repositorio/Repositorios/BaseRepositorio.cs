using SalesSolution.Dominio.Contratos;
using SalesSolution.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace SalesSolution.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly SalesSolutionContexto SalesSolutionContexto;

        public BaseRepositorio(SalesSolutionContexto salesSolutionContexto)
        {
            SalesSolutionContexto = salesSolutionContexto;
        }

        public void Adicionar(TEntity entity)
        {
            SalesSolutionContexto.Set<TEntity>().Add(entity);
            SalesSolutionContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            SalesSolutionContexto.Set<TEntity>().Update(entity);
            SalesSolutionContexto.SaveChanges();
        }



        public TEntity ObterPorId(int id)
        {
           return SalesSolutionContexto.Set<TEntity>().Find(id);
        }

        public IList<TEntity> ObterTodos()
        {
           return SalesSolutionContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            SalesSolutionContexto.Set<TEntity>().Remove(entity);
            SalesSolutionContexto.SaveChanges();
        }

        public void Dispose()
        {
            SalesSolutionContexto.Dispose();
        }
    }
}
