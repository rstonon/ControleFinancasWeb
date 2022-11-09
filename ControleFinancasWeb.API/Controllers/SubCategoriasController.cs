using ControleFinancasWeb.API.Models;
using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinancasWeb.API.Controllers
{
    [Route("api/subcategorias")]
    public class SubCategoriasController : ControllerBase
    {
        private readonly ISubCategoriaService _detalhamentoService;

        public SubCategoriasController(ISubCategoriaService detalhamentoService)
        {
            _detalhamentoService = detalhamentoService;
        }

        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var detalhamentos = _detalhamentoService.GetAll(query);

            return Ok(detalhamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var detalhamento = _detalhamentoService.GetById(id);

            if (detalhamento == null)
            {
                return NotFound();
            }
            return Ok(detalhamento);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewSubCategoriaInputModel inputModel)
        {
            var id = _detalhamentoService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateSubCategoriaInputModel inputModel)
        {
            _detalhamentoService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _detalhamentoService.Delete(id);

            return NoContent();
        }
    }
}
