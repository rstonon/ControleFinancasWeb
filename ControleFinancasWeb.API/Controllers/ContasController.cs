using ControleFinancasWeb.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinancasWeb.API.Controllers
{
    [Route("api/contas")]
    public class ContasController : ControllerBase
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
        public IActionResult Post([FromBody] CreateContaModel createConta)
        {
            return CreatedAtAction(nameof(GetById), new {id = createConta.Id}, createConta);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateContaModel updateConta)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/quitar")]
        public IActionResult Quitar(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/aberta")]
        public IActionResult Aberta(int id)
        {
            return NoContent();
        }
    }
}
