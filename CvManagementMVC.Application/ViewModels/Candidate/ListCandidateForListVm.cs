using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Candidate
{
    public class ListCandidateForListVm
    {
        public List<CandidateForListVm> Candidates { get; set; }
        public int Count { get; set; }
    }
}
