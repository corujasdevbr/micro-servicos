using System.Collections.Generic;

namespace CorujasDev.Eventos.Servicos.ViewModels.Evento
{
    public class EventoHomeViewModel
    {
        public int quantidade { get; set; }
        public IList<EventoViewModel> Eventos { get; set; }
    }
}
