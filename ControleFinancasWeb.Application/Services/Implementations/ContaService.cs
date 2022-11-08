using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Application.ViewModels;
using ControleFinancasWeb.Core.Entities;
using ControleFinancasWeb.Infrastructure.Persistence;

namespace ControleFinancasWeb.Application.Services.Implementations
{
    public class ContaService : IContaService
    {
        private readonly ControleFinancasDbContext _dbContext;
        public ContaService(ControleFinancasDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Aberta(int id)
        {
            var conta = _dbContext.Contas.SingleOrDefault(c => c.Id == id);

            conta.Aberta();
        }

        public int Create(NewContaInputModel inputModel)
        {
            var conta = new Conta(inputModel.Descricao, inputModel.Valor, inputModel.IdTipo, inputModel.IdDetalhamento, inputModel.DataVencimento, inputModel.NumeroParcela, inputModel.QuantidadeParcelas);

            _dbContext.Contas.Add(conta);

            return conta.Id;
        }

        public void Delete(int id)
        {
            var conta = _dbContext.Contas.SingleOrDefault(c => c.Id == id);

            conta.Excluir();
        }

        public List<ContaViewModel> GetAll(string query)
        {
            var contas = _dbContext.Contas;

            var contasViewModel = contas.Select(c => new ContaViewModel(c.Id, c.Descricao, c.Valor, c.DataVencimento)).ToList();

            return contasViewModel;
        }

        public ContaDetailsViewModel GetById(int id)
        {
            var conta = _dbContext.Contas.SingleOrDefault(c => c.Id == id);

            if (conta == null)
            {
                return null;
            }
            var contasDetailsViewModel = new ContaDetailsViewModel(
                conta.Id,
                conta.Descricao,
                conta.Valor,
                conta.IdTipo,
                conta.IdDetalhamento,
                conta.DataVencimento,
                conta.NumeroParcela,
                conta.QuantidadeParcelas,
                conta.CreatedAt,
                conta.DataQuitacao,
                conta.Status
                );

            return contasDetailsViewModel;
        }

        public void Quitar(int id)
        {
            var conta = _dbContext.Contas.SingleOrDefault(c => c.Id == id);

            conta.Quitar();
        }

        public void Update(UpdateContaInputModel inputModel)
        {
            var conta = _dbContext.Contas.SingleOrDefault(c => c.Id == inputModel.Id);

            conta.Update(inputModel.Descricao, inputModel.Valor,inputModel.IdTipo, inputModel.IdDetalhamento, inputModel.DataVencimento,inputModel.NumeroParcela,inputModel.QuantidadeParcelas);

        }
    }
}
