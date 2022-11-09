using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.Services.Interfaces
{
    public interface ICategoriaService
    {
        List<CategoriaViewModel> GetAll(string query);
        CategoriaDetailsViewModel GetById(int id);
        int Create(NewCategoriaInputModel inputModel);
        void Update(UpdateCategoriaInputModel inputModel);
        void Delete(int id);
    }
}
