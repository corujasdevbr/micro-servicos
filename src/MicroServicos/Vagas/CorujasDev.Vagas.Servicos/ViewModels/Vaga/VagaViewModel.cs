using System;
using System.ComponentModel.DataAnnotations;

namespace CorujasDev.Vagas.Servicos.ViewModels.Vaga
{
    public class VagaViewModel
    {
        
        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "Informe o título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Informe a Empresa")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Informe a Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        public string Email { get; set; }

        public decimal? Salario { get; set; }

        public bool Ativa { get; set; }
    }
}
