using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Cv
{
    public class ListCvsForListVm
    {
        public List<NewCvVm> CvList { get; set; }
        public int Count { get; set; }
    }
}
