using Microsoft.AspNetCore.Mvc;
using  CorujasDev.Vagas.Servicos.Interfaces;
using  CorujasDev.Vagas.Servicos.ViewModels.Vaga;
using System;
using System.Collections.Generic;

namespace CorujasDev.Vagas.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        private readonly IVagaServico _vagaServico;

        public VagasController(IVagaServico vagaServico)
        {
            _vagaServico = vagaServico;
        }

        // GET api/vagas
        [HttpGet]
        public ActionResult<IEnumerable<VagaHomeViewModel>> Get()
        {
            try
            {
                return Ok(_vagaServico.Listar());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/vagas
        [HttpPost]
        public ActionResult Post(VagaViewModel vaga)
        {
            try
            {
                _vagaServico.Inserir(vaga);

                return Ok(vaga);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Put api/vagas
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<VagaHomeViewModel>> Put(VagaViewModel vaga, Guid id)
        {
            try
            {
                var vagaRetorno = _vagaServico.BuscarPorId(id);

                if (vagaRetorno == null)
                    return NotFound();

                _vagaServico.Alterar(vaga);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Put api/vagas
        [HttpPut("/ativar/{id}")]
        public ActionResult<IEnumerable<VagaHomeViewModel>> Ativar(VagaViewModel vaga, Guid id)
        {
            try
            {
                var vagaRetorno = _vagaServico.BuscarPorId(id);

                if (vagaRetorno == null)
                    return NotFound();

                _vagaServico.Ativar(id);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Put api/vagas
        [HttpPut("/desativar/{id}")]
        public ActionResult<IEnumerable<VagaHomeViewModel>> Desativar(VagaViewModel vaga, Guid id)
        {
            try
            {
                var vagaRetorno = _vagaServico.BuscarPorId(id);

                if (vagaRetorno == null)
                    return NotFound();

                _vagaServico.Desativar(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}