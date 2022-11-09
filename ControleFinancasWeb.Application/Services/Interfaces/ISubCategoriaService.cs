using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.ViewModels;

namespace ControleFinancasWeb.Application.Services.Interfaces
{
    public interface ISubCategoriaService
    {
        List<SubCategoriaViewModel> GetAll(string query);
        SubCategoriaDetailsViewModel GetById(int id);
        int Create(NewSubCategoriaInputModel inputModel);
        void Update(UpdateSubCategoriaInputModel inputModel);
        void Delete(int id);
    }
}
