using CvManagementMVC.Application.ViewModels.EducationHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Skill
{
    public class ListSkillsForListVm
    {
        public List<NewSkillVm> listSkills = new List<NewSkillVm>();
        public int Count { get; set; }
    }
}
