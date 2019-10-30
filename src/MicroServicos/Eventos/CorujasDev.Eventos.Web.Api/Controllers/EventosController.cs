using System;
using System.Collections.Generic;
using CorujasDev.Eventos.Servicos.Interfaces;
using CorujasDev.Eventos.Servicos.ViewModels.Evento;
using Microsoft.AspNetCore.Mvc;

namespace CorujasDev.Eventos.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IEventoServico _eventoServico;

        public EventosController(IEventoServico eventoServico)
        {
            _eventoServico = eventoServico;
        }

        // GET api/Eventos
        [HttpGet]
        public ActionResult<IEnumerable<EventoHomeViewModel>> Get()
        {
            try
            {
                return Ok(_eventoServico.Listar());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/Eventos
        [HttpPost]
        public ActionResult Post(EventoViewModel Evento)
        {
            try
            {
                _eventoServico.Inserir(Evento);

                return Ok(Evento);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Put api/Eventos
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<EventoHomeViewModel>> Put(EventoViewModel Evento, Guid id)
        {
            try
            {
                var EventoRetorno = _eventoServico.BuscarPorId(id);

                if (EventoRetorno == null)
                    return NotFound();

                _eventoServico.Alterar(Evento);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
