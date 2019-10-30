using System;

namespace CorujasDev.Eventos.Dominio.Entidades
{
    public class EventoEntidade : BaseEntidade
    {
        public string Titulo { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
    }
}
