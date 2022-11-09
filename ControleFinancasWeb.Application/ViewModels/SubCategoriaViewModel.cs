using ControleFinancasWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.ViewModels
{
    public class SubCategoriaViewModel
    {
        public SubCategoriaViewModel(int id, string descricao, string tipo)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }

        public string Tipo { get; private set; }
    }
}
