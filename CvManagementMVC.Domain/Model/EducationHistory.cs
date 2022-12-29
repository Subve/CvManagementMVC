using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class EducationHistory
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string NameOfSchool { get; set; }
        public string DegreeEarned { get; set; }
        public DateTime EducationBegin { get; set; }
        public DateTime EducationEnd { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
