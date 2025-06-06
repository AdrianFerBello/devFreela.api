using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repository
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Task<Project> GetDetailsById(int id);
        Task CreateAsync(Project project);
        Task StartAsync(Project project);
        Task PostCommentAsync(ProjectComment comment);
    }
}
