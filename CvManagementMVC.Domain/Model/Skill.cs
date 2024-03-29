﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set;}
        public virtual ICollection<CvSkill> CvSkills { get; set; }
    }
}
