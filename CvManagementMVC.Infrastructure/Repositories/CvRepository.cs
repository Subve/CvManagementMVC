using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class CvRepository: ICvRepository
    {
        private readonly Context _context;
        public CvRepository(Context context)
        {
            _context=context;
        }
        public int AddCv(Cv cv)
        {
            _context.Cvs.Add(cv);
            _context.SaveChanges();
            return cv.Id;
        }
        public void RemoveCv(int cvId)
        {
            var cv= _context.Cvs.Find(cvId);
            if (cv != null)
            {
                _context.Cvs.Remove(cv);
            }
            _context.SaveChanges();
        }
        public Cv GetCvByTitle(string title)
        {
            var cv=_context.Cvs.Where(x=>x.Title==title).FirstOrDefault();
            return cv;
        }
        public IQueryable<Cv> GetAllCvs()
        {
            return _context.Cvs;
        }

        public Cv GetCvByCandidateId(int candidateId)
        {
            var cv=_context.Cvs.Where(x=>x.CandidateId==candidateId).FirstOrDefault();
            return cv;
        }

        public Cv GetCvByCvId(int cvId)
        {
            var cv=_context.Cvs.Where(x=>x.Id==cvId).FirstOrDefault();
            return cv;
        }
        
        public void UpdateCv(Cv cv)
        {
            _context.Attach(cv);
            _context.Entry(cv).Property("Title").IsModified = true;
            _context.Entry(cv).Property("Content").IsModified = true;
            _context.SaveChanges();
        }
    }
}
