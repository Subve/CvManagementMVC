using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CvSkillRepository
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

        public void AddCvSkill(CvSkill cvSkill)
        {
            _context.CvSkills.Add(cvSkill);
            _context.SaveChanges();
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


    }
}
