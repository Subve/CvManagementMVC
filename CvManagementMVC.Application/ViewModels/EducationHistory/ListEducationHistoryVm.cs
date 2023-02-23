using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.EducationHistory
{
    public class ListEducationHistoryVm
    {
        public List<NewEducationHistoryVm> listEducation=new List<NewEducationHistoryVm>();
        public int Count { get; set; }
    }
}
