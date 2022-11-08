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
    public class TipoService : ITipoService
    {
        private readonly string _connectionString;
        public TipoService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ControleFinancasWeb");

        }
        public int Create(NewTipoInputModel inputModel)
        {
            var sql = @"INSERT INTO Tipos (Descricao, CreatedAt, Status) VALUES (@descricao, @createdAt, @status)";

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
            var sql = @"update Tipos set Status = 2 where id = @id";

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

        public List<TipoViewModel> GetAll(string query)
        {
            var sql = @"SELECT Id, Descricao from Tipos where Status = 3";

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Query<TipoViewModel>(sql).ToList();
            }
        }

        public TipoDetailsViewModel GetById(int id)
        {
            var sql = @"SELECT Id, Descricao from Tipos where id = @id";

            var param = new
            {
                id
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.QueryFirstOrDefault<TipoDetailsViewModel>(sql, param);
            }
        }

        public void Update(UpdateTipoInputModel inputModel)
        {
            var sql = @"update Tipos set Descricao = @descricao where id = @id";

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
