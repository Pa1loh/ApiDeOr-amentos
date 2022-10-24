using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ApiDeOrcamento.Models.Enums;

namespace ApiDeOrcamento.Models
{
    public class Item:ModeloGenerico
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Referencia { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public decimal Preco { get; set; }
        public decimal Estoque { get; set; }
        public ItemTipo ItemTipo { get; set; }
    }
}
