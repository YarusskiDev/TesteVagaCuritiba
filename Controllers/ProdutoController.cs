using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebApiCompras.Interfaces;
using TesteWebApiCompras.Interfaces.servicos;
using TesteWebApiCompras.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteWebApiCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoServico _produtoServico;
        private IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoServico produtoServico, IProdutoRepositorio produtoRepositorio)
        {
            _produtoServico = produtoServico;
            _produtoRepositorio = produtoRepositorio;

        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            var result = await _produtoRepositorio.ObterTodos();
            return result;
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            var result = _produtoRepositorio.ObterPorId(id).GetAwaiter().GetResult();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto produto)
        {
            await _produtoServico.Adicionar(produto);
            return CreatedAtAction(nameof(Post), produto);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Produto produto)
        {
            await _produtoServico.Atualizar(produto);

            return NoContent();
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _produtoServico.Remover(id);
            return NoContent();
        }
    }
}
