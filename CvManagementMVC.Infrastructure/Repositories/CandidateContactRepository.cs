using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CandidateContactRepository: ICandidateContactRepository
    {
        private readonly Context _context;
        public CandidateContactRepository(Context context)
        {
            _context= context;
        }
        public int AddCandidateContact(CandidateContact candidateContact)
        {
            _context.CandidateContacts.Add(candidateContact);
            _context.SaveChanges();
            return candidateContact.Id;
        }
        public void DeleteCandidateContact(int candidateContactId) 
        {
            var candidateContact=_context.CandidateContacts.Find(candidateContactId);
            if (candidateContact != null)
            {
                _context.CandidateContacts.Remove(candidateContact);
            }
            _context.SaveChanges();
        }
        public CandidateContact GetCandidateContactById(int candidateContantid) 
        {
            var contact = _context.CandidateContacts.Find(candidateContantid);
            return contact;
        }
        public IQueryable<CandidateContact> GetAllCandidateContact()
        {
            return _context.CandidateContacts;
        }
    }
}
