﻿using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(ProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);

            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();

            return project.Id;
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);

            _dbContext.SaveChanges();

            project.Cancel();   

        }

        public void Finish(int id)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);

            _dbContext.SaveChanges();

            project.Finish();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;

            var listProjectViewModel = projects
                .Select(x => new ProjectViewModel(x.Id, x.Title, x.CreateAt))
                .ToList();
                
            return listProjectViewModel;
            
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.Projects
                .Include(x => x.Cliente)
                .Include(x => x.Freelancer)
                .FirstOrDefault(x => x.Id == id);

            var projectDetails = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.TotalCost,
                project.CreateAt,
                project.Status,
                project.Cliente.Name,
                project.Freelancer.Name);

            return projectDetails;
        }

        public void PostComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdUser, inputModel.IdFreelancer);

            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
        }

        public void Start(int id)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);

            project.Start();
            _dbContext.SaveChanges();

        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.Id == inputModel.Id);

            project.Update(inputModel.Title, inputModel.Description, inputModel.TotalCost);

            _dbContext.SaveChanges();

        }
    }
}
