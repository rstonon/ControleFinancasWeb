using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            CreatedAt = DateTime.Now;
            Ativo = true;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
