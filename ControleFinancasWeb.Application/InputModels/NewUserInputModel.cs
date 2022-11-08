using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.InputModels
{
    public class NewUserInputModel
    {
        public string FullName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
    }
}
