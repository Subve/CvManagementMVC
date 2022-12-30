using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CandidateRepository
    {
        private readonly Context _context;
        public CandidateRepository(Context context)
        {
            _context=context;
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
    }
}
