using CvManagementMVC.Application.ViewModels.Cv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface ICvService
    {
        int AddCv(NewCvVm newCv);
        void DeleteCv(int id);
        NewCvVm GetCvForDetails(int id);
        NewCvVm ShowCv (int id);
        void UpdateCv(NewCvVm newCv);
        ListCvsForListVm GetAllCvsForList();
    }
}
