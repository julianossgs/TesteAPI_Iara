using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace TesteAPI_Iara.Models
{
    public class Cotacao
    {
        //Construtor
        public Cotacao()
        {
            CotacaoItens = new Collection<CotacaoItem>();
        }

        [Key]
        public int CotacaoId { get; set; }

        [Required]
        [StringLength(30)]
        public string? CnpjComprador { get; set; }

        [Required]
        [StringLength(30)]
        public string? CnpjFornecedor { get; set; }

        [Required]
        
        public int? NumeroCotacao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCotacao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataEntregaCotacao { get; set; }

        [Required]
        [StringLength(15)]
        public string? Cep { get; set; }

        [Required]
        [StringLength(50)]
        public string? Logradouro { get; set; }

        [Required]
        [StringLength(25)]
        public string? Complemento { get; set; }

        [Required]
        [StringLength(30)]
        public string? Bairro { get; set; }

        [Required]
        [StringLength(2)]
        public char Uf { get; set; }

        
        [StringLength(100)]
        public string? Observacao { get; set; }

        public ICollection<CotacaoItem>? CotacaoItens { get; set; }

    }
}
