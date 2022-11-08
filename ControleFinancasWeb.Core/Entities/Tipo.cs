using ControleFinancasWeb.Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class Tipo : BaseEntity
    {
        public Tipo(string descricao)
        {
            Descricao = descricao;
            CreatedAt = DateTime.Now;
            Detalhamentos = new List<Detalhamento>();
            Contas = new List<Conta>();
            Status = ProjectStatusEnum.Ativo;
        }

        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Detalhamento> Detalhamentos { get; private set; }
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
