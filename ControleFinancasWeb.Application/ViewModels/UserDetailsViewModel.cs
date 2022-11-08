﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
    }
}
