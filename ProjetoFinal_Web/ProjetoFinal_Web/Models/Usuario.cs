using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal_Web.Models
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}
