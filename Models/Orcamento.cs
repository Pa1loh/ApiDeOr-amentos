using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class Orcamento:ModeloGenerico
    {
        [ForeignKey("Usuario")]
        [Required(ErrorMessage = "O Usuario é obrigatorio")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("Cliente")]
        [Required(ErrorMessage = "O Cliente é obrigatorio")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorDesconto { get; set; }
        public string Observacao { get; set; }
       
    }
}
