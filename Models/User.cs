using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 0 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 carateres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 0 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 carateres")]
        public string Password { get; set; }

        public string Role { get; set; }        

    }
}