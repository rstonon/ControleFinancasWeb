using ControleFinancasWeb.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class SubCategoria : BaseEntity
    {
        public SubCategoria(string descricao, int idTipo)
        {
            Descricao = descricao;
            CreatedAt = DateTime.Now;
            Contas = new List<Conta>();
            Status = ProjectStatusEnum.Ativo;
            IdTipo = idTipo;
        }
        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Conta> Contas { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public int IdTipo { get; private set; }
        public Categoria Tipo { get; private set; }

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
