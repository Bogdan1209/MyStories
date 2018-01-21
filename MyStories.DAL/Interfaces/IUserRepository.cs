using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStories.DAL.Entities;

namespace MyStories.DAL.Interfaces
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<User> GetUserAsync (string login, string userPassword);
        Task<bool> CheckUserExistingAsync(string login, string email);
    }
}