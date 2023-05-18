using CvManagementMVC.Application.ViewModels.CvSkill;
using CvManagementMVC.Application.ViewModels.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface ICvSkillService
    {
        int AddCvSkill(NewCvSkillVm newCvSkillVm);
        void DeleteCvSkill(int cvSkillId);
        void UpdateCvSkill(NewCvSkillVm newCvSkillVm);
    }
}
