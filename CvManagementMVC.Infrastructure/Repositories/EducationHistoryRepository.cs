using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class EducationHistoryRepository: IEducationHistoryRepository
    {
        private readonly Context _context;
        public EducationHistoryRepository(Context context)
        {
            _context = context;
        }
        public int AddEducationHistory(EducationHistory educationHistory)
        {
            _context.EducationHistories.Add(educationHistory);
            _context.SaveChanges();
            return educationHistory.Id;
        }
        public void RemoveEducationHistory(int educationHistoryId)
        {
            var educationHistory = _context.EducationHistories.Find(educationHistoryId);
            if (educationHistory != null)
            {
                _context.EducationHistories.Remove(educationHistory);
            }
            _context.SaveChanges();
        }
        public IQueryable<EducationHistory> GetEducationHistoryByCvId(int cvId)
        {
            var educationHistory = _context.EducationHistories.Where(x => x.CvId == cvId);
            return educationHistory;
        }
        public IQueryable<EducationHistory> GetEducationHistoryByDegree(string degreeEarned)
        {
            var educationHistory = _context.EducationHistories.Where(x => x.DegreeEarned == degreeEarned);
            return educationHistory;
        }
        public IQueryable<EducationHistory> GetEducationHistoryBySchoolName(string schoolName)
        {
            var educationHistory = _context.EducationHistories.Where(x => x.SchoolName == schoolName);
            return educationHistory;
        }
    }
}
