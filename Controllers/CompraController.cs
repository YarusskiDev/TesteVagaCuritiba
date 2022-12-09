using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Interfaces;
using TesteWebApiCompras.Interfaces.Servicos;
using TesteWebApiCompras.Modelos;
using TesteWebApiCompras.Repositorios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteWebApiCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraServico _compraServico;
        private readonly ICompraRepositorio _compraRepositorio;
        public CompraController(ICompraServico compraServico, ICompraRepositorio compraRepositorio)
        {
            _compraRepositorio = compraRepositorio;
            _compraServico = compraServico;

        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet]
        public async Task<ActionResult<List<Compra>>> Get()
        {
            var result = await _compraRepositorio.ObterTodos();
            return result;
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            var result = _compraRepositorio.ObterPorId(id).GetAwaiter().GetResult();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Compra compra)
        {
            await _compraServico.Adicionar(compra);
            return CreatedAtAction(nameof(Post), compra);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Compra compra)
        {
            await _compraServico.Atualizar(compra);

            return NoContent();
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _compraServico.Remover(id);
            return NoContent();
        }
    }
}
