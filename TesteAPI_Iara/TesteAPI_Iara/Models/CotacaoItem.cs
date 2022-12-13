using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteAPI_Iara.Models
{
    public class CotacaoItem
    {
        [Key]
        public int CotacaoItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Descricao { get; set; }

        [Required]
       
        public int NumeroItem { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco { get; set; }

        [Required]
        
        public float Quantidade { get; set; }

        [Required]
        [StringLength(50)]
        public string? Marca { get; set; }

        [Required]
        [StringLength(20)]
        public string? Unidade { get; set; }

        
        public int CotacaoId { get; set; }
        public Cotacao? Cotacao { get; set; }
    }
}
