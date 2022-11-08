using ControleFinancasWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Infrastructure.Persistence
{
    public class ControleFinancasDbContext
    {
        public ControleFinancasDbContext()
        {
            Contas = new List<Conta>
            {
                new Conta("Vivo Rafael", Convert.ToDecimal(61.89), 1, 1, Convert.ToDateTime("2022-11-10"), null, null),
                new Conta("Vivo Bruna", Convert.ToDecimal(59.99), 1, 1, Convert.ToDateTime("2022-11-06"), null, null),
                new Conta("MHNet", Convert.ToDecimal(77.56), 1, 1, Convert.ToDateTime("2022-11-08"), null, null),
            };

            Users = new List<User>
            {
                new User("Rafael Tonon", "rstonon@gmail.com"),
            };

            Tipos = new List<Tipo>
            {
                new Tipo("Alimentação"),
            };

            Detalhamentos = new List<Detalhamento>
            {
                new Detalhamento("Supermercado"),
            };
        }
        public List<Conta> Contas { get; set; }
        public List<User> Users { get; set; }
        public List<Tipo> Tipos { get; set; }
        public List<Detalhamento> Detalhamentos { get; set; }
    }
}
