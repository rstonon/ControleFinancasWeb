using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class Detalhamento : BaseEntity
    {
        public Detalhamento(string descricao)
        {
            Descricao = descricao;
            CreatedAt = DateTime.Now;
            Contas = new List<Conta>();
        }
        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Conta> Contas { get; private set; }
    }
}
