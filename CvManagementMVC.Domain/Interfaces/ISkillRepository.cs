using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ISkillRepository
    {
        int AddSkill(Skill skill);
         void RemoveSkill(int skillId);
         Skill GetSkillById(int skillId);
         IQueryable<Skill> GetSkillsByName(string skillName);
        
    }
}
