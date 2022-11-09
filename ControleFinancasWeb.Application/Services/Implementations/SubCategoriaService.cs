using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Application.ViewModels;
using ControleFinancasWeb.Core.Entities;
using ControleFinancasWeb.Infrastructure.Persistence;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ControleFinancasWeb.Application.Services.Implementations
{
    public class SubCategoriaService : ISubCategoriaService
    {
        private readonly string _connectionString;
        public SubCategoriaService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ControleFinancasWeb");
        }
        public int Create(NewSubCategoriaInputModel inputModel)
        {
            var sql = @"INSERT INTO SubCategorias (Descricao, CreatedAt, Status, IdTipo) VALUES (@descricao, @createdAt, @status, @idTipo)";

            var param = new
            {
                descricao = inputModel.Descricao,
                createdAt = DateTime.Now,
                status = 3,
                idTipo = inputModel.IdTipo
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Execute(sql, param);
            }
        }

        public void Delete(int id)
        {
            var sql = @"update SubCategorias set Status = 2 where id = @id";

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

        public List<SubCategoriaViewModel> GetAll(string query)
        {
            var sql = @"SELECT d.Id, d.Descricao, t.Descricao as Tipo from SubCategorias d inner join Tipos t ON (d.IdTipo = t.Id) where d.Status = 3";

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Query<SubCategoriaViewModel>(sql).ToList();
            }
        }

        public SubCategoriaDetailsViewModel GetById(int id)
        {
            var sql = @"SELECT d.Id, d.Descricao, t.Descricao as Tipo from SubCategorias d inner join Tipos t ON (d.IdTipo = t.Id) where d.id = @id";

            var param = new
            {
                id
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.QueryFirstOrDefault<SubCategoriaDetailsViewModel>(sql, param);
            }
        }

        public void Update(UpdateSubCategoriaInputModel inputModel)
        {
            var sql = @"update SubCategorias set Descricao = @descricao where id = @id";

            var param = new
            {
                id = inputModel.Id,
                descricao = inputModel.Descricao
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                db.Execute(sql, param);
            }
        }
    }
}
