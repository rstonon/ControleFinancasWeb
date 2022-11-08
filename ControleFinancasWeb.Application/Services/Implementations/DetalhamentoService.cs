using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Application.ViewModels;
using ControleFinancasWeb.Core.Entities;
using ControleFinancasWeb.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ControleFinancasWeb.Application.Services.Implementations
{
    public class DetalhamentoService : IDetalhamentoService
    {
        private readonly ControleFinancasDbContext _dbContext;
        public DetalhamentoService(ControleFinancasDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewDetalhamentoInputModel inputModel)
        {
            var detalhamento = new Detalhamento(inputModel.Descricao, inputModel.IdTipo);

            _dbContext.Detalhamentos.Add(detalhamento);

            _dbContext.SaveChanges();

            return detalhamento.Id;
        }

        public void Delete(int id)
        {
            var detalhamento = _dbContext.Detalhamentos.SingleOrDefault(c => c.Id == id);

            detalhamento.Excluir();

            _dbContext.SaveChanges();
        }

        public List<DetalhamentoViewModel> GetAll(string query)
        {
            var detalhamentos = _dbContext.Detalhamentos.Include(c => c.Tipo);

            var detalhamentosViewModel = detalhamentos.Select(t => new DetalhamentoViewModel(t.Id, t.Descricao, t.Tipo.Descricao)).ToList();

            return detalhamentosViewModel;
        }

        public DetalhamentoDetailsViewModel GetById(int id)
        {
            var detalhamento = _dbContext.Detalhamentos
                .Include(c => c.Tipo)
                .SingleOrDefault(c => c.Id == id);

            var detalhamentosDetailsViewModel = new DetalhamentoDetailsViewModel(
                detalhamento.Id,
                detalhamento.Descricao,
                detalhamento.Tipo.Descricao
                );

            return detalhamentosDetailsViewModel;
        }

        public void Update(UpdateDetalhamentoInputModel inputModel)
        {
            var detalhamento = _dbContext.Detalhamentos.SingleOrDefault(c => c.Id == inputModel.Id);

            detalhamento.Update(inputModel.Descricao);
        }
    }
}
