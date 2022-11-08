using ControleFinancasWeb.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.ViewModels
{
    public class ContaDetailsViewModel
    {
        public ContaDetailsViewModel(int id, string descricao, decimal valor, int idTipo, int idDetalhamento, DateTime dataVencimento, int? numeroParcela, int? quantidadeParcelas, DateTime createdAt, DateTime? dataQuitacao, ProjectStatusEnum status, string tipoFullName, string detalhamentoFullName)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            IdTipo = idTipo;
            IdDetalhamento = idDetalhamento;
            DataVencimento = dataVencimento;
            NumeroParcela = numeroParcela;
            QuantidadeParcelas = quantidadeParcelas;
            CreatedAt = createdAt;
            DataQuitacao = dataQuitacao;
            Status = status;
            TipoFullName = tipoFullName;
            DetalhamentoFullName = detalhamentoFullName;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int IdTipo { get; private set; }
        public int IdDetalhamento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public int? NumeroParcela { get; private set; }
        public int? QuantidadeParcelas { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? DataQuitacao { get; private set; }
        public ProjectStatusEnum Status { get; private set; }

        public string TipoFullName { get; private set; }
        public string DetalhamentoFullName { get; private set; }
    }
}
