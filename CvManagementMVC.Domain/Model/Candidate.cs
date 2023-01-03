using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public bool isActive { get; set; }
        public virtual CandidateAdress CandidateAdress { get; set; }
        public virtual CandidateContact CandidateContact { get; set; }
        public virtual Cv Cv { get; set; }

    }


    
}
