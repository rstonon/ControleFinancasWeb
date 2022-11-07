namespace ControleFinancasWeb.API.Models
{
    public class UpdateContaModel
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public int NumeroParcela { get; set; }
        public int QuantidadeParcelas { get; set; }
    }
}
