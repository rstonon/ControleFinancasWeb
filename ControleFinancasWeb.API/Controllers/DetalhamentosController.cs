using ControleFinancasWeb.API.Models;
using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinancasWeb.API.Controllers
{
    [Route("api/detalhamentos")]
    public class DetalhamentosController : ControllerBase
    {
        private readonly IDetalhamentoService _detalhamentoService;

        public DetalhamentosController(IDetalhamentoService detalhamentoService)
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
        public IActionResult Post([FromBody] NewDetalhamentoInputModel inputModel)
        {
            var id = _detalhamentoService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateDetalhamentoInputModel inputModel)
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
