using SalesSolution.Dominio.Contratos;
using SalesSolution.Dominio.Entidades;
using SalesSolution.Repositorio.Contexto;

namespace SalesSolution.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(SalesSolutionContexto salesSolutionContexto) : base(salesSolutionContexto)
        {
        }
    }
}
