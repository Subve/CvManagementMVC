using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CvSkillRepository : ICvSkillRepository
    {

        private readonly Context _context;

        public CvSkillRepository(Context context) 
        {
            _context = context;
        }

        public IQueryable<CvSkill> GetCvSkillsByCvId(int cvId)
        {
            return _context.CvSkills
                .Where(cs => cs.CvId == cvId);
        }

        public int AddCvSkill(CvSkill cvSkill)
        {
            _context.CvSkills.Add(cvSkill);
            _context.SaveChanges();
            return cvSkill.Id;
        }

        public void RemoveCvSkill(int cvId, int skillId)
        {
            var cvSkill = _context.CvSkills.FirstOrDefault(cs => cs.CvId == cvId && cs.SkillId == skillId);

            if (cvSkill != null)
            {
                _context.CvSkills.Remove(cvSkill);
                _context.SaveChanges();
            }
        }


        public void RemoveCvSkill(int cvSkillId)
        {
            var cvSkill = _context.CvSkills.FirstOrDefault(cs => cs.Id == cvSkillId);

            if (cvSkill != null)
            {
                _context.CvSkills.Remove(cvSkill);
                _context.SaveChanges();
            }
        }

        public void UpdateCvSkill(CvSkill cvSkill)
        {
            _context.Attach(cvSkill);
            _context.Entry(cvSkill).Property("SkillId").IsModified = true;
            _context.SaveChanges();
        }

        public IQueryable<CvSkill> GetAllCvSkills()
        {
            return _context.CvSkills;
        }
    }
}
