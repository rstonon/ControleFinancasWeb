namespace ControleFinancasWeb.API.Models
{
    public class CreateContaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataQuitacao { get; set; }
        public int NumeroParcela { get; set; }
        public int QuantidadeParcelas { get; set; }

    }
}
