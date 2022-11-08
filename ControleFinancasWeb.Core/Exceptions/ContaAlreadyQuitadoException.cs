using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Exceptions
{
    public class ContaAlreadyQuitadoException : Exception
    {
        public ContaAlreadyQuitadoException() : base("Conta já está quitada")
        {

        }
    }
}
