using System;
using System.ComponentModel.DataAnnotations;

namespace CorujasDev.Eventos.Dominio.Entidades
{
    public class BaseEntidade
    {
        [Key]
        public Guid Id { get; set; }

        [DataType("DATETIME")]
        [Required]
        public DateTime DataCriacao { get; set; }

    }
}
