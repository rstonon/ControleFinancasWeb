using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Application.ViewModels;
using ControleFinancasWeb.Core.Entities;
using ControleFinancasWeb.Infrastructure.Persistence;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Drawing;

namespace ControleFinancasWeb.Application.Services.Implementations
{
    public class ContaService : IContaService
    {
        private readonly string _connectionString;
        public ContaService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ControleFinancasWeb");
        }

        public void Aberta(int id)
        {
            var sql = @"update Contas set Status = @status where id = @id";

            var param = new
            {
                id,
                status = 0
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                db.Execute(sql, param);
            }
        }

        public int Create(NewContaInputModel inputModel)
        {

            var sql = @"INSERT INTO Contas (Descricao, Valor, IdTipo, IdDetalhamento, DataVencimento, NumeroParcela, QuantidadeParcela, CreatedAt, DataQuitacao, Status) VALUES (@Descricao, @Valor, @IdTipo, @IdDetalhamento, @DataVencimento, @NumeroParcela, @QuantidadeParcela, @CreatedAt, @DataQuitacao, @Status)";

            var param = new
            {
                Descricao = inputModel.Descricao,
                Valor = inputModel.Valor,
                IdTipo = inputModel.IdTipo,
                IdDetalhamento = inputModel.IdDetalhamento,
                DataVencimento = inputModel.DataVencimento,
                NumeroParcela = inputModel.NumeroParcela,
                QuantidadeParcela = inputModel.QuantidadeParcelas,
                CreatedAt = DateTime.Now,
                Status = 0
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Execute(sql, param);
            }
        }

        public void Delete(int id)
        {
            var sql = @"update Contas set Status = 2 where id = @id";

            var param = new
            {
                id
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                db.Execute(sql, param);
            }
        }

        public List<ContaViewModel> GetAll(string query)
        {
            //descricao, decimal valor, DateTime dataVencimento, string tipo, string detalhamento

            var sql = @"SELECT c.Id, c.Descricao, c.valor, c.dataVencimento, t.Descricao, d.Descricao from Contas c inner join Tipos t ON (c.IdTipo = t.Id) inner join Detalhamentos d ON (c.IdDetalhamento = d.Id) where c.Status = 3";

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Query<ContaViewModel>(sql).ToList();
            }
        }

        public ContaDetailsViewModel GetById(int id)
        {
            var sql = @"SELECT c.Id, c.Descricao, c.valor, c.IdTipo, c.IdDetalhamento, c.dataVencimento, c.NumeroParcela, c.QuantidadeParcelas, c.CreatedAt, c.DataQuitacao, c.Status, t.Descricao, d.Descricao from Contas c inner join Tipos t ON (c.IdTipo = t.Id) inner join Detalhamentos d ON (c.IdDetalhamento = d.Id) where c.id = @id";

            var param = new
            {
                id
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.QueryFirstOrDefault<ContaDetailsViewModel>(sql, param);
            }
        }

        public void Quitar(int id)
        {
            var sql = @"update Contas set Status = @status where id = @id";

            var param = new
            {
                id,
                status = 1
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                db.Execute(sql, param);
            }
        }

        public void Update(UpdateContaInputModel inputModel)
        {

        var sql = @"update Contas set Descricao = @descricao, Valor = @valor, IdTipo = @idTipo, IdDetalhamento = @idDetalhamento, DataVencimento = @vencimento, NumeroParcela = @parcela, QuantidadeParcelas = @qntParcelas where id = @id";

            var param = new
            {
                id = inputModel.Id,
                descricao = inputModel.Descricao,
                valor = inputModel.Valor,
                idTipo = inputModel.IdTipo,
                idDetalhamento = inputModel.IdDetalhamento,
                vencimento = inputModel.DataVencimento,
                parcela = inputModel.NumeroParcela,
                qntParcelas = inputModel.QuantidadeParcelas,
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                db.Execute(sql, param);
            }

        }
    }
}
