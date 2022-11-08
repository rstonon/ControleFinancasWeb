using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.InputModels
{
    public class NewContaInputModel
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int IdTipo { get; set; }
        public int IdDetalhamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public int? NumeroParcela { get; set; }
        public int? QuantidadeParcelas { get; set; }
    }
}
