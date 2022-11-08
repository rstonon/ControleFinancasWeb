using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.InputModels
{
    public class UpdateDetalhamentoInputModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdTipo { get; set; }
    }
}
