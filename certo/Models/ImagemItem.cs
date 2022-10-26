using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class ImagemItem:ModeloGenerico
    {
        [ForeignKey("Item")]
        [Required(ErrorMessage = "O Item é obrigatorio")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        
    }
}
