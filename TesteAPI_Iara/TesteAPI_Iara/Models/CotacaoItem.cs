namespace TesteAPI_Iara.Models
{
    public class CotacaoItem
    {
        public int CotacaoItemId { get; set; }
        public string? Descricao { get; set; }
        public int NumeroItem { get; set; }
        public decimal Preco { get; set; }
        public float Quantidade { get; set; }
        public string? Marca { get; set; }
        public string? Unidade { get; set; }
        public int CotacaoId { get; set; }
        public Cotacao? Cotacao { get; set; }
    }
}
