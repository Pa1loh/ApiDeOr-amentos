using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class Endereco : ModeloGenerico
    {
        [Required(ErrorMessage = "A Rua é obrigatorio")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "A Cidade é obrigatorio")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O Estado é obrigatorio")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "O Cep é obrigatorio")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O Pais é obrigatorio")]
        public string Pais { get; set; }

    }
}
