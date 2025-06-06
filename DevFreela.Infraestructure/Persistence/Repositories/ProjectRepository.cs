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
    public class ProjectRepository : IProjectRepository
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Project project)
        {
            await _dbContext.Projects.AddAsync(project);    

            await _dbContext.SaveChangesAsync();
        }


        public async Task<List<Project>> GetAllAsync()
        {
            return await  _dbContext.Projects.ToListAsync();
        }

        public async Task<Project> GetByIdAsync(int id)
        {
            return await _dbContext.Projects.SingleOrDefaultAsync(p => p.Id == id);

        }

        public async Task<Project> GetDetailsById(int id)
        {
            return await _dbContext.Projects
                .Include(p => p.Comments)
                .Include(p => p.Cliente)
                .Include(p => p.Freelancer)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task PostCommentAsync(ProjectComment comment)
        {
            await _dbContext.Comments.AddAsync(comment);

            await _dbContext.SaveChangesAsync();
        }

        public async Task StartAsync(Project project)
        {
            project.Start();

            await _dbContext.SaveChangesAsync();
        }

    }
}
