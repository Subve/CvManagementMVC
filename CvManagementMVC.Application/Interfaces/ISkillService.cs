using CvManagementMVC.Application.ViewModels.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillManagementMVC.Application.Interfaces
{
    public interface ISkillService
    {
        int AddSkill(NewSkillVm newSkill);
        void DeleteSkill(int id);
        NewSkillVm GetSkillForDetails(int id);
        NewSkillVm ShowSkill(int id);
        void UpdateSkill(NewSkillVm newSkill);
        ListSkillsForListVm GetAllSkillsForList();
    }
}
