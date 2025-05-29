using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillsViewModel> GetAll();
        SkillDetailsViewModel GetById(int id);
        void Update(UpdateSkillInputModel inputModel);
    }
}
