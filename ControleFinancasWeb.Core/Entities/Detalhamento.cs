using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class Detalhamento
    {
        public Detalhamento(string descricao)
        {
            Descricao = descricao;
            CreatedAt = DateTime.Now;
        }
        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
