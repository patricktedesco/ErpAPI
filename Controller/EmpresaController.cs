using ErpAPI.Models;
using ErpAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ErpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Empresa>> GetEmpresas()
        {
            var empresas = _empresaService.GetAll();
            return Ok(empresas);
        }

        [HttpGet("{id}")]
        public ActionResult<Empresa> GetEmpresaById(int id)
        {
            var empresa = _empresaService.GetById(id);

            if (empresa == null)
            {
                return NotFound();
            }

            return Ok(empresa);
        }

        [HttpPost]
        public ActionResult<Empresa> AddEmpresa([FromBody] Empresa empresa)
        {
            if (empresa == null)
            {
                return BadRequest();
            }

            _empresaService.Add(empresa);

            return CreatedAtAction(nameof(GetEmpresaById), new { id = empresa.Id }, empresa);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmpresa(int id, [FromBody] Empresa empresa)
        {
            if (empresa == null || id != empresa.Id)
            {
                return BadRequest();
            }

            var existingEmpresa = _empresaService.GetById(id);

            if (existingEmpresa == null)
            {
                return NotFound();
            }

            _empresaService.Update(empresa);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmpresa(int id)
        {
            var empresa = _empresaService.GetById(id);

            if (empresa == null)
            {
                return NotFound();
            }

            _empresaService.Delete(id);

            return NoContent();
        }
    }
}
