using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Address
{
    public class ListAddressForListVm
    {
        public List<NewAddressVm> addressesList { get; set; }
        public int Count { get; set; }
    }
}
