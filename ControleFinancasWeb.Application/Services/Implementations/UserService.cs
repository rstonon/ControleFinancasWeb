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
    public class UserService : IUserService
    {
        private readonly string _connectionString;
        public UserService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ControleFinancasWeb");
        }
        public int Create(NewUserInputModel inputModel)
        {
            var sql = @"INSERT INTO Users (FullName, Email, Ativo, CreatedAt) VALUES (@FullName, @Email, @Ativo, @CreatedAt)";

            var param = new
            {
                FullName = inputModel.FullName,
                Email = inputModel.Email,
                CreatedAt = DateTime.Now,
                Ativo = true
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.Execute(sql, param);
            }
        }

        public UserDetailsViewModel GetById(int id)
        {
            var sql = @"SELECT Id, FullName from Users where id = @id";

            var param = new
            {
                id
            };

            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                return db.QueryFirstOrDefault<UserDetailsViewModel>(sql, param);
            }
        }
    }
}
