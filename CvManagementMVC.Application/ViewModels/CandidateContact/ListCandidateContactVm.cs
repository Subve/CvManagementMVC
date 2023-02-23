using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.CandidateContact
{
    public class ListCandidateContactVm
    {
        public List<NewCandidateContactVm> ListCandidateContact { get; set;}
        public int Count { get; set; }
    }
}
