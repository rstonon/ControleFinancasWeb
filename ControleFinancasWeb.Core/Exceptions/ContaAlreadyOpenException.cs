using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Exceptions
{
    public class ContaAlreadyOpenException : Exception
    {
        public ContaAlreadyOpenException() : base("Conta já está aberta")
        {

        }
    }
}
