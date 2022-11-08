using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.ViewModels;

namespace ControleFinancasWeb.Application.Services.Interfaces
{
    public interface IDetalhamentoService
    {
        List<DetalhamentoViewModel> GetAll(string query);
        DetalhamentoDetailsViewModel GetById(int id);
        int Create(NewDetalhamentoInputModel inputModel);
        void Update(UpdateDetalhamentoInputModel inputModel);
        void Delete(int id);
    }
}
