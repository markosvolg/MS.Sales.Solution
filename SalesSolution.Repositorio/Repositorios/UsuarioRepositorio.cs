using SalesSolution.Dominio.Contratos;
using SalesSolution.Dominio.Entidades;
using SalesSolution.Repositorio.Contexto;

namespace SalesSolution.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SalesSolutionContexto salesSolutionContexto) : base(salesSolutionContexto)
        {

        }
    }
}
