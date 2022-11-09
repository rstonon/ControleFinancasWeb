using ControleFinancasWeb.Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class Categoria : BaseEntity
    {
        public Categoria(string descricao)
        {
            Descricao = descricao;
            CreatedAt = DateTime.Now;
            Detalhamentos = new List<SubCategoria>();
            Contas = new List<Conta>();
            Status = ProjectStatusEnum.Ativo;
        }

        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<SubCategoria> Detalhamentos { get; private set; }
        public List<Conta> Contas { get; private set; }
        public ProjectStatusEnum Status { get; private set; }

        public void Excluir()
        {
            if (Status == ProjectStatusEnum.Ativo)
            {
                Status = ProjectStatusEnum.Excluido;
            }
        }

        public void Update(string descricao)
        {
            Descricao = descricao;
        }
    }
}
