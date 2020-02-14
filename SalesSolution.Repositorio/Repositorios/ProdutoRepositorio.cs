using SalesSolution.Dominio.Contratos;
using SalesSolution.Dominio.Entidades;
using SalesSolution.Repositorio.Contexto;

namespace SalesSolution.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(SalesSolutionContexto salesSolutionContexto) : base(salesSolutionContexto)
        {

        }


    }
}
