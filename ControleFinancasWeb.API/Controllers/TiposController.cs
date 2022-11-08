using ControleFinancasWeb.API.Models;
using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Implementations;
using ControleFinancasWeb.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinancasWeb.API.Controllers
{
    [Route("api/tipos")]
    public class TiposController : ControllerBase
    {
        private readonly ITipoService _tipoService;

        public TiposController(ITipoService tipoService)
        {
            _tipoService = tipoService;
        }

        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var tipos = _tipoService.GetAll(query);

            return Ok(tipos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tipo = _tipoService.GetById(id);

            if (tipo == null)
            {
                return NotFound();
            }
            return Ok(tipo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewTipoInputModel inputModel)
        {
            var id = _tipoService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateTipoInputModel inputModel)
        {
            _tipoService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoService.Delete(id);

            return NoContent();
        }
    }
}
