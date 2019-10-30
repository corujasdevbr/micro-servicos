using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorujasDev.Vagas.Dominio.Entidades
{

    [Table("Vagas")]
    public class VagaEntidade : BaseEntidade
    {
        [DataType("VARCHAR(150)")]
        [Required]
        public string Titulo { get; set; }

        [DataType("VARCHAR(150)")]
        [Required]
        public string Empresa { get; set; }

        [DataType("TEXT")]
        [Required]
        public string Descricao { get; set; }

        [DataType("VARCHAR(200)")]
        [Required]
        public string Endereco { get; set; }

        [DataType("VARCHAR(150)")]
        [Required]
        public string Email { get; set; }

        [DataType("VARCHAR(150)")]
        [Required]
        public string Curso { get; set; }

        [DataType("DECIMAL(10,8)")]
        public decimal? Salario { get; set; }

        public bool Ativa { get; set; }
    }
}
