using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Interfaces.IRepositorios;
using TesteWebApiCompras.Interfaces.Servicos;
using TesteWebApiCompras.Modelos;
using TesteWebApiCompras.Repositorios;
using TesteWebApiCompras.Servicos;

namespace TesteWebApiCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensCompraController : Controller
    {
        private IItensCompraServico _itensCompraServico;
        private IItensCompraRepositorio _itensCompraRepositorio;
        public ItensCompraController(IItensCompraServico itensCompraServico, IItensCompraRepositorio itensCompraRepositorio)
        {
            _itensCompraServico = itensCompraServico;
            _itensCompraRepositorio = itensCompraRepositorio;
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet]
        public async Task<ActionResult<List<ItensCompras>>> Get()
        {
            var result = await _itensCompraRepositorio.ObterTodos();
            return result;
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _itensCompraRepositorio.ObterPorId(id);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ItensCompras itens)
        {
            await _itensCompraServico.Adicionar(itens);
            return CreatedAtAction(nameof(Post), itens);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] ItensCompras itensCompras)
        {
            await _itensCompraServico.Atualizar(itensCompras);

            return NoContent();
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _itensCompraServico.Remover(id);
            return NoContent();
        }
    }
}
