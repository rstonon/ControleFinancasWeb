using ControleFinancasWeb.Application.InputModels;
using ControleFinancasWeb.Application.Services.Interfaces;
using ControleFinancasWeb.Application.ViewModels;
using ControleFinancasWeb.Core.Entities;
using ControleFinancasWeb.Infrastructure.Persistence;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Application.Services.Implementations
{
    public class CategoriaService : ICategoriaService
    {
        private readonly string _connectionString;
        public CategoriaService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ControleFinancasWeb");

        }
        public int Create(NewCategoriaInputModel inputModel)
        {
            var sql = @"INSERT INTO Categorias (Descricao, CreatedAt, Status) VALUES (@descricao, @createdAt, @status)";

            var param = new
            {
                descricao = inputModel.Descricao,
                createdAt = DateTime.Now,
                status = 3
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Execute(sql, param);
            }
        }

        public void Delete(int id)
        {
            var sql = @"update Categorias set Status = 2 where id = @id";

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

        public List<CategoriaViewModel> GetAll(string query)
        {
            var sql = @"SELECT Id, Descricao from Categorias where Status = 3";

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Query<CategoriaViewModel>(sql).ToList();
            }
        }

        public CategoriaDetailsViewModel GetById(int id)
        {
            var sql = @"SELECT Id, Descricao from Categorias where id = @id";

            var param = new
            {
                id
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.QueryFirstOrDefault<CategoriaDetailsViewModel>(sql, param);
            }
        }

        public void Update(UpdateCategoriaInputModel inputModel)
        {
            var sql = @"update Categorias set Descricao = @descricao where id = @id";

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
