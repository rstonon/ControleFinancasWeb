﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class TipoDetalhamento : BaseEntity
    {
        public TipoDetalhamento(int idTipo, int idDetalhamento)
        {
            IdTipo = idTipo;
            IdDetalhamento = idDetalhamento;
        }

        public int IdTipo { get; private set; }
        public int IdDetalhamento { get; private set; }
    }
}
