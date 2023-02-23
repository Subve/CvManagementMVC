using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.EducationHistory
{
    public class NewEducationHistoryVm
    {
        public int Id { get; set; }
        public int CvId { get; set; }
        public string SchoolName { get; set; }
        public string DegreeEarned { get; set; }
        public DateTime EducationBegin { get; set; }
        public DateTime EducationEnd { get; set; }
    }
}
