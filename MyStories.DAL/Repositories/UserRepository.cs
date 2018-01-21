using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MyStories.DAL.Interfaces;
using System.Threading.Tasks;
using MyStories.DAL.Entities;

namespace MyStories.DAL.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        AppContext _context;
        public UserRepository(AppContext context):base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(string login, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(t => 
                t.Login == login || 
                t.Email == login && 
                t.Password == password);
        }

        public async Task<bool> CheckUserExistingAsync(string login, string Email)
        {
            return await _context.Users.AnyAsync(t => 
                t.Login == login || 
                t.Email == Email );
        }
    }
}