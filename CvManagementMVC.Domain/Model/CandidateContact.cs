using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class CandidateContact
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public  Candidate Candidate { get; set; }
    }
}
