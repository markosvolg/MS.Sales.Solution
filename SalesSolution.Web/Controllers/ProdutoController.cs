using Microsoft.AspNetCore.Mvc;
using SalesSolution.Dominio.Contratos;
using SalesSolution.Dominio.Entidades;
using System;

namespace SalesSolution.Web.Controllers
{

    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio )
        {

            _produtoRepositorio = produtoRepositorio;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
               return Ok(_produtoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto )
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);

                return Created("api/produto",produto); //Uri e retorno

            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString()); 
            }
        }
    }

}
