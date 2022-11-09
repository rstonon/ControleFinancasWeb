using ControleFinancasWeb.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class Conta : BaseEntity
    {
        public Conta(string descricao, decimal valor, int idTipo, int idDetalhamento, DateTime dataVencimento, int? numeroParcela, int? quantidadeParcelas)
        {
            Descricao = descricao;
            Valor = valor;
            IdTipo = idTipo;
            IdDetalhamento = idDetalhamento;
            DataVencimento = dataVencimento;
            NumeroParcela = numeroParcela;
            QuantidadeParcelas = quantidadeParcelas;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Aberto;
        }

        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int IdTipo { get; private set; }
        public Categoria Tipo { get; private set; }
        public int IdDetalhamento { get; private set; }
        public SubCategoria Detalhamento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public int? NumeroParcela { get; private set; }
        public int? QuantidadeParcelas { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? DataQuitacao { get; private set; }
        public ProjectStatusEnum Status { get; private set; }

        public void Excluir()
        {
            if (Status == ProjectStatusEnum.Aberto)
            {
                Status = ProjectStatusEnum.Excluido;
            }
        }

        public void Aberta()
        {
            if (Status == ProjectStatusEnum.Quitado)
            {
                Status = ProjectStatusEnum.Aberto;
                DataQuitacao = null;
            }
        }

        public void Quitar()
        {
            if (Status == ProjectStatusEnum.Aberto)
            {
                Status = ProjectStatusEnum.Quitado;
                DataQuitacao = DateTime.Now;
            }
        }

        public void Update(string descricao, decimal valor, int idTipo, int idDetalhamento, DateTime dataVencimento, int? numeroParcela, int? quantidadeParcelas)
        {
            Descricao = descricao;
            Valor = valor;
            IdTipo = idTipo;
            IdDetalhamento = idDetalhamento;
            DataVencimento = dataVencimento;
            NumeroParcela = numeroParcela;
            QuantidadeParcelas = quantidadeParcelas;

        }
    }
}
