using System.Collections.ObjectModel;

namespace TesteAPI_Iara.Models
{
    public class Cotacao
    {
        //Construtor
        public Cotacao()
        {
            CotacaoItens = new Collection<CotacaoItem>();
        }

        public int CotacaoId { get; set; }
        public string? CnpjComprador { get; set; }
        public string? CnpjFornecedor { get; set; }
        public int? NumeroCotacao  { get; set; }
        public DateTime DataCotacao { get; set; }
        public DateTime DataEntregaCotacao { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public char Uf { get; set; }
        public string? Observacao { get; set; }

        public ICollection<CotacaoItem>? CotacaoItens { get; set; }

    }
}
