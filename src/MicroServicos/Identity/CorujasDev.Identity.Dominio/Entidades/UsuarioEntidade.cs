using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorujasDev.Identity.Dominio.Entidades
{

    [Table("Usuarios")]
    public class UsuarioEntidade : BaseEntidade
    {
        [DataType("VARCHAR(150)")]
        [Required]
        public string NumeroMatricula { get; set; }

        [DataType("VARCHAR(150)")]
        [Required]
        public string Nome { get; set; }

        [DataType("VARCHAR(20)")]
        [Required]
        public string Telefone { get; set; }

        [DataType("VARCHAR(20)")]
        [Required]
        public string Celular { get; set; }

        [DataType("VARCHAR(150)")]
        [Required]
        public string Email { get; set; }

        [DataType("VARCHAR(20)")]
        [Required]
        public string Cpf { get; set; }

        [DataType("VARCHAR(150)")]
        public string Curso { get; set; }

        [DataType("VARCHAR(10)")]
        public string Turma { get; set; }

        public bool Ativo { get; set; }
    }
}
