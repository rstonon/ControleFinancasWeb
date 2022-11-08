using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserDetailsViewModel GetById(int id);
        int Create(NewUserInputModel inputModel);
    }
}
