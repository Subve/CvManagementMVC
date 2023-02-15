using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ICandidateAddressRepository
    {
        int AddCandidateAddress(Address candidateAdress);

         void DeleteCandidateAddress(int candidateAdressId);


         Address GetCandidateAddressById(int candidateAdressId);


         IQueryable<Address> GetAllAddressesByCountry(string country);

        Address GetCandidateAddressByCandidateId(int candidateId);
         IQueryable<Address> GetAllAddressesByCity(string city);
        void UpdateAddress(Address candidateAddress);
    }
}
