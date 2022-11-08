using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.Services.Interfaces
{
    public interface IContaService
    {
        List<ContaViewModel> GetAll(string query);
        ContaDetailsViewModel GetById(int id);
        int Create(NewContaInputModel inputModel);
        void Update(UpdateContaInputModel inputModel);
        void Delete(int id);
        void Quitar(int id);
        void Aberta(int id);
    }
}
