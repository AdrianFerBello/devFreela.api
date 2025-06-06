using DevFreela.Core.Entities;
using DevFreela.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infraestructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbContext.Users
                .ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
