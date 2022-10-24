using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class Cliente : ModeloGenerico
    {
        [Required(ErrorMessage = "O Nome é obrigatorio")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        [ForeignKey("Endereco")]
        [Required(ErrorMessage = "O Endereco é obrigatorio")]
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

    }
}
