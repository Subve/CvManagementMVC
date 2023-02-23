using CvManagementMVC.Application.ViewModels.Address;
using CvManagementMVC.Application.ViewModels.CandidateContact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface ICandidateContactService
    { 
        int AddContact(NewCandidateContactVm contact);
        NewCandidateContactVm GetContactForEdit(int id);
        void RemoveContact(int contactId);
        NewCandidateContactVm ShowContact(int id);
        void UpdateContact(NewCandidateContactVm contact);

    }
}
