using ControleFinancasWeb.API.Models;
using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
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
        private readonly IContaService _contaService;
        public ContasController(IContaService contaService)
        {
            _contaService = contaService;
        }
        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var contas = _contaService.GetAll(query);

            return Ok(contas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var conta = _contaService.GetById(id);

            if (conta == null)
            {
                return NotFound();
            }
            return Ok(conta);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewContaInputModel inputModel)
        {
            var id = _contaService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new {id = id}, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateContaInputModel inputModel)
        {
            _contaService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contaService.Delete(id);

            return NoContent();
        }

        [HttpPut("{id}/quitar")]
        public IActionResult Quitar(int id)
        {
            _contaService.Quitar(id);

            return NoContent();
        }

        [HttpPut("{id}/aberta")]
        public IActionResult Aberta(int id)
        {
            _contaService.Aberta(id);

            return NoContent();
        }
    }
}
