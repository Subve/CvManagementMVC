using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CandidateAdressRepository: ICandidateAdressRepository
    {
        private readonly Context _context;
        public CandidateAdressRepository(Context context)
        {
            _context= context;
        }
        public int AddCandidateAdress(Adress candidateAdress)
        {
            _context.CandidateAdresses.Add(candidateAdress);
            _context.SaveChanges();
            return candidateAdress.Id;

        }
        public void DeleteCandidateAdress(int candidateAdressId)
        {
            var adress = _context.CandidateAdresses.Find(candidateAdressId);
            if (adress != null)
            {
                _context.CandidateAdresses.Remove(adress);
            }
            _context.SaveChanges();
        }
        public Adress GetCandidateAdressById(int candidateAdressId)
        {
            var adress = _context.CandidateAdresses.Find(candidateAdressId);
            return adress;
        }
        public IQueryable<Adress> GetAllAdressesByCountry(string country)
        {
            var adresses = _context.CandidateAdresses.Where(x => x.Country == country);
            return adresses;
        }
        public IQueryable<Adress> GetAllAdressesByCity(string city) 
        { 
            var adresses=_context.CandidateAdresses.Where(x => x.City == city);
            return adresses;
        }
    }
}
