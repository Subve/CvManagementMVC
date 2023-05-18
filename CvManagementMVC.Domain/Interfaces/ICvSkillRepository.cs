using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ICvSkillRepository
    {
        int AddCvSkill(CvSkill cvSkill);

        void RemoveCvSkill(int cvSkillId);
        void RemoveCvSkill(int cvId, int skillId);
        void UpdateCvSkill(CvSkill cvSkill);
        IQueryable<CvSkill> GetAllCvSkills();

    }
}
