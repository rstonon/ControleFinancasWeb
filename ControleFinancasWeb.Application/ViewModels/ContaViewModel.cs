using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.ViewModels
{
    public class ContaViewModel
    {
        public ContaViewModel(int id, string descricao, decimal valor, DateTime dataVencimento)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            DataVencimento = dataVencimento;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataVencimento { get; private set; }
    }
}
