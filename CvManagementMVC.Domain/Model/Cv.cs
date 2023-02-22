using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class Cv
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<EmploymentHistory> EmploymentHistory { get; set;}
        public virtual ICollection<EducationHistory> EducationHistory { get; set;}

    }
}
