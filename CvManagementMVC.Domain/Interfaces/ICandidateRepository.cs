using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ICandidateRepository
    {
        int AddCandidate(Candidate candidate);


         void DeleteCandidate(int candidateId);
            

         Candidate GetCandidate(int candidateId);


         IQueryable<Candidate> GetAllCandidates();
        
    }
}
