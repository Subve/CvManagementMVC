using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CandidateAddressRepository: ICandidateAddressRepository
    {
        private readonly Context _context;
        public CandidateAddressRepository(Context context)
        {
            _context= context;
        }
        public int AddCandidateAddress(Address candidateAddress)
        {
            _context.CandidateAddresses.Add(candidateAddress);
            _context.SaveChanges();
            return candidateAddress.Id;

        }
        public void DeleteCandidateAddress(int candidateAddressId)
        {
            var Address = _context.CandidateAddresses.Find(candidateAddressId);
            if (Address != null)
            {
                _context.CandidateAddresses.Remove(Address);
            }
            _context.SaveChanges();
        }
        public Address GetCandidateAddressById(int candidateAddressId)
        {
            var Address = _context.CandidateAddresses.Find(candidateAddressId);
            return Address;
        }
        public IQueryable<Address> GetAllAddressesByCountry(string country)
        {
            var Addresses = _context.CandidateAddresses.Where(x => x.Country == country);
            return Addresses;
        }
        public IQueryable<Address> GetAllAddressesByCity(string city) 
        { 
            var Addresses=_context.CandidateAddresses.Where(x => x.City == city);
            return Addresses;
        }

        public Address GetCandidateAddressByCandidateId(int candidateId)
        {
            var address = _context.CandidateAddresses.FirstOrDefault<Address>(x => x.CandidateId == candidateId);
            return address;
        }

        public void UpdateAddress(Address candidateAddress)
        {
            _context.Attach(candidateAddress);
            _context.Entry(candidateAddress).Property("City").IsModified= true;
            _context.Entry(candidateAddress).Property("Region").IsModified = true;
            _context.Entry(candidateAddress).Property("PostalCode").IsModified = true;
            _context.Entry(candidateAddress).Property("Country").IsModified = true;
            _context.SaveChanges();

        }
    }
}
