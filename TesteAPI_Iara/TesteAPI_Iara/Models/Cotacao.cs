namespace TesteAPI_Iara.Models
{
    public class Cotacao
    {
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
    }
}
