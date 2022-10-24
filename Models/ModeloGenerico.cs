using System.ComponentModel.DataAnnotations;

namespace ApiDeOrcamento.Models
{
    public class ModeloGenerico
    {
        [Key]
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime AlteracaoData { get; set; }
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime CriacaoData { get; set; }
        public bool IsDeletado { get; set; }

    }
}
