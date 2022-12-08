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
    public class EmpresaController : ControllerBase
    {
        private IEmpresaServico _empresaServico;
        private IEmpresaRepositorio _empresaRepositorio;
        public EmpresaController(IEmpresaServico empresaServico, IEmpresaRepositorio empresaRepositorio)
        {
            _empresaServico = empresaServico;
            _empresaRepositorio = empresaRepositorio;

        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet]
        public async Task<ActionResult<List<Empresa>>> Get()
        {
            var result = await _empresaRepositorio.ObterTodos();
            return result;
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            var result = _empresaRepositorio.ObterPorId(id).GetAwaiter().GetResult();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Empresa empresa)
        {
            await _empresaServico.Adicionar(empresa);
            return CreatedAtAction(nameof(Post),empresa);
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Empresa empresa)
        {
            await _empresaServico.Atualizar(empresa);

            return NoContent();
        }

        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _empresaServico.Remover(id);
            return NoContent();
        }
    }
}
