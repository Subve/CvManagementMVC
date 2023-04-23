using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class SkillRepository:ISkillRepository
    {
        private readonly Context _context;
        public SkillRepository(Context context)
        {
            _context= context;
        }
        public int AddSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return skill.Id;
        }
        public void RemoveSkill(int skillId)
        {
            var skill= _context.Skills.Find(skillId);
            if (skill != null)
            {
                _context.Skills.Remove(skill);
            }
            _context.SaveChanges();
        }
        public Skill GetSkillById(int skillId)
        {
            var skill=_context.Skills.Where(x=>x.Id==skillId).FirstOrDefault();
            return skill;
        }
        public IQueryable<Skill> GetSkillsByName(string skillName)
        {
            var skills=_context.Skills.Where(x=>x.SkillName==skillName);
            return skills;
        }

        public IQueryable<Skill> GetAllSkills()
        {
            return _context.Skills;
        }
    }
}
