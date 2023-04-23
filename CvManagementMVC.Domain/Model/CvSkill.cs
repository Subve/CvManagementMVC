using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class CvSkill
    {   
        public int Id { get; set; }
        public int CvId { get; set; }
        public virtual Cv Cv { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
