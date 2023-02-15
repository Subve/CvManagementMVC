using CvManagementMVC.Application.ViewModels.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface ICandidateAddressService
    {
        int AddAddress(NewAddressVm Address);
        NewAddressVm GetAddressForEdit(int id);
        void RemoveAddress(int addressId);
        NewAddressVm ShowAddress(int id);
        void UpdateAddress(NewAddressVm address);
    }
}
