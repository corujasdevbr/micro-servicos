using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CorujasDev.Eventos.Servicos.ViewModels.Evento
{
    public class EventoViewModel
    {
        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }
        [Required(ErrorMessage = "Informe o título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Informe a Imagem")]
        public string Imagem { get; set; }
        public IFormFile ArquivoImagem { get; set; }
        [Required(ErrorMessage = "Informe a Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Informe a Data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Informe o horário")]
        public string Horario { get; set; }
    }
}
