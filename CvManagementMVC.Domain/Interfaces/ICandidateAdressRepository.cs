using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ICandidateAdressRepository
    {
        int AddCandidateAdress(CandidateAdress candidateAdress);

         void DeleteCandidateAdress(int candidateAdressId);


         CandidateAdress GetCandidateAdressById(int candidateAdressId);


         IQueryable<CandidateAdress> GetAllAdressesByCountry(string country);


         IQueryable<CandidateAdress> GetAllAdressesByCity(string city);
        
    }
}
