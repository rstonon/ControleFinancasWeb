using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Application.ViewModels;
using ControleFinancasWeb.Core.Entities;
using ControleFinancasWeb.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.Services.Implementations
{
    public class TipoService : ITipoService
    {
        private readonly ControleFinancasDbContext _dbContext;
        public TipoService(ControleFinancasDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewTipoInputModel inputModel)
        {
            var tipo = new Tipo(inputModel.Descricao);

            _dbContext.Tipos.Add(tipo);
            _dbContext.SaveChanges();

            return tipo.Id;
        }

        public void Delete(int id)
        {
            var tipo = _dbContext.Tipos.SingleOrDefault(c => c.Id == id);

            tipo.Excluir();
            _dbContext.SaveChanges();
        }

        public List<TipoViewModel> GetAll(string query)
        {
            var tipos = _dbContext.Tipos;

            var tiposViewModel = tipos.Select(t => new TipoViewModel(t.Id, t.Descricao)).ToList();

            return tiposViewModel;
        }

        public TipoDetailsViewModel GetById(int id)
        {
            var tipo = _dbContext.Tipos.SingleOrDefault(c => c.Id == id);

            var tiposDetailsViewModel = new TipoDetailsViewModel(
                tipo.Id,
                tipo.Descricao
                );

            return tiposDetailsViewModel;
        }

        public void Update(UpdateTipoInputModel inputModel)
        {
            var tipo = _dbContext.Tipos.SingleOrDefault(c => c.Id == inputModel.Id);

            tipo.Update(inputModel.Descricao);
        }
    }
}
