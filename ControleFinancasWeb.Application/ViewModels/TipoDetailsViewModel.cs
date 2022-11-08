using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.ViewModels
{
    public class TipoDetailsViewModel
    {
        public TipoDetailsViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
    }
}
