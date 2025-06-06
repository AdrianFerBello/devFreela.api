using Azure.Core;
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
    public class SkillRepository : ISkillRepository
    {
        private readonly DevFreelaDbContext _dbContext;
        public SkillRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Skill>> GetAllAsync()
        {
            return await _dbContext.Skills.ToListAsync();
        }

        public async Task<Skill> GetByIdAsync(int id)   
        {
            return await _dbContext.Skills.SingleOrDefaultAsync(x => x.Id == id);

        }
    }
}
