using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class ComposicaoItem:ModeloGenerico
    {
        public string Nome { get; set; }
        public decimal Desconto { get; set; }
        public string Referencia { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
