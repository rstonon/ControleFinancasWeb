using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.Services.Interfaces
{
    public interface ITipoService
    {
        List<TipoViewModel> GetAll(string query);
        TipoDetailsViewModel GetById(int id);
        int Create(NewTipoInputModel inputModel);
        void Update(UpdateTipoInputModel inputModel);
        void Delete(int id);
    }
}
