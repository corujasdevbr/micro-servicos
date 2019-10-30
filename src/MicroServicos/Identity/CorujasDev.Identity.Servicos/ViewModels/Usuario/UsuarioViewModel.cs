using System;
using System.ComponentModel.DataAnnotations;

namespace CorujasDev.Identity.Servicos.ViewModels.Usuario
{
    
        public class UsuarioViewModel
        {

        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }

        [Required]
        public string NumeroMatricula { get; set; }


        [Required]
        public string Nome { get; set; }


        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Celular { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        public string Cpf { get; set; }

        [Required]
        public string Curso { get; set; }

        [Required]
        public string Turma { get; set; }


        public bool Ativo { get; set; }
    }
    
}
