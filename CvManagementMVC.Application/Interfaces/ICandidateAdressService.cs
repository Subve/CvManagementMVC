using CvManagementMVC.Application.ViewModels.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface ICandidateAdressService
    {
        int AddAdress(NewAdressVm adress);
        void RemoveAdress(int candidateId);
        NewAdressVm GetAdressForEdit(int id);
        void UpdateAdress(NewAdressVm adress);
    }
}
