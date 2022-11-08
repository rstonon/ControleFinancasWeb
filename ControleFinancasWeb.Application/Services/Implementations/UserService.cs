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
    public class UserService : IUserService
    {
        private readonly ControleFinancasDbContext _dbContext;
        public UserService(ControleFinancasDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Password, inputModel.Email);

            _dbContext.Users.Add(user);

            return user.Id;
        }

        public UserDetailsViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(c => c.Id == id);

            var usersDetailsViewModel = new UserDetailsViewModel(
                user.Id,
                user.FullName
                );

            return usersDetailsViewModel;
        }
    }
}
