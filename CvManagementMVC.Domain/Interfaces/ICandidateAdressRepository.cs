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
        int AddCandidateAdress(Adress candidateAdress);

         void DeleteCandidateAdress(int candidateAdressId);


         Adress GetCandidateAdressById(int candidateAdressId);


         IQueryable<Adress> GetAllAdressesByCountry(string country);


         IQueryable<Adress> GetAllAdressesByCity(string city);
        
    }
}
