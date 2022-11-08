using ControleFinancasWeb.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinancasWeb.API.Controllers
{
    [Route("api/tipos")]
    public class TiposController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateTipoModel createTipo)
        {
            return CreatedAtAction(nameof(GetById), new { id = createTipo.Id }, createTipo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateTipoModel updateTipo)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
