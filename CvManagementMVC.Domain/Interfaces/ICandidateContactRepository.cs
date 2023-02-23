using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ICandidateContactRepository
    {
        int AddCandidateContact(CandidateContact candidateContact);
        void DeleteCandidateContact(int candidateContactId);
        CandidateContact GetCandidateContactById(int candidateContantid);
        IQueryable<CandidateContact> GetAllCandidateContact();
        void UpdateContact(CandidateContact candidateContact);

    }
}
