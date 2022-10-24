using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class OrcamentoItem:ModeloGenerico
    {
        [ForeignKey("Orcamento")]
        [Required(ErrorMessage = "O Orcamento é obrigatorio")]
        public int OrcamentoId { get; set; }
        public virtual Orcamento Orcamento { get; set; }
        [ForeignKey("Item")]
        [Required(ErrorMessage = "O Orcamento é obrigatorio")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }
        public decimal Quantidade { get; set; }
    }
}
