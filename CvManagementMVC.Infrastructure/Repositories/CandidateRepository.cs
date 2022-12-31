using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CandidateRepository: ICandidateRepository
    {
        private readonly Context _context;
        public CandidateRepository(Context context)
        {
            _context=context;
        }
        public int AddCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
            return candidate.Id;
        }
        public void DeleteCandidate(int candidateId)
        {
            var candidate=_context.Candidates.Find(candidateId);
            if (candidate != null)
            {
                _context.Candidates.Remove(candidate);
                _context.SaveChanges();
            }
        }
        public Candidate GetCandidate(int candidateId)
        {
            var candidate = _context.Candidates.FirstOrDefault(c => c.Id == candidateId);
            return candidate;
        }
        public IQueryable<Candidate> GetAllCandidates()
        {
            return _context.Candidates;
        }
    }
}
