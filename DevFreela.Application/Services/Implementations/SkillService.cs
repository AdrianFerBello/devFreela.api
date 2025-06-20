﻿using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillsViewModel> GetAll()
        {
            var skills = _dbContext.Skills;

            var listSkillsViewModel = skills.Select(x => new SkillsViewModel(x.Id, x.Description))
                .ToList();

            return listSkillsViewModel;
        }

        public SkillDetailsViewModel GetById(int id)
        {
            var skill = _dbContext.Skills.FirstOrDefault(x => x.Id == id);

            var detailsViewModel = new SkillDetailsViewModel(skill.Id, skill.Description, skill.CreateAt);

            return detailsViewModel;
        }

        public void Update(UpdateSkillInputModel inputModel)
        {
            var skill = _dbContext.Skills.FirstOrDefault(x => x.Id == inputModel.Id);

            skill.Update(inputModel.Description);
            _dbContext.SaveChanges();

        }
    }
}
