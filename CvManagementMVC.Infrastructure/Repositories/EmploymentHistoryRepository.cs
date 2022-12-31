using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure.Repositories
{
    public class EmploymentHistoryRepository: IEmploymentHistoryRepository
    {
        private readonly Context _context;
        public EmploymentHistoryRepository(Context context)
        {
            _context= context;
        }
        public int AddEmploymentHistory(EmploymentHistory employmentHistory)
        {
            _context.EmploymentHistories.Add(employmentHistory);
            _context.SaveChanges();
            return employmentHistory.Id;
        }
        public void RemoveEmploymentHistory (int employmentHistoryId)
        {
            var employmentHistory=_context.EmploymentHistories.Find(employmentHistoryId);
            if (employmentHistory != null)
            {
                _context.EmploymentHistories.Remove(employmentHistory);
            }
            _context.SaveChanges();
        }
        public IQueryable<EmploymentHistory> GetEmploymentHistoryByCvId(int cvId)
        {
            var employmentHistory=_context.EmploymentHistories.Where(x=>x.CvId==cvId);
            return employmentHistory;
        } 
        public IQueryable<EmploymentHistory> GetEmploymentHistoryByTitle(string title)
        {
            var employmentHistory=_context.EmploymentHistories.Where(x=>x.Title==title);
            return employmentHistory;
        }
        public IQueryable<EmploymentHistory> GetEmploymentHistoryByCompany(string companyName)
        {
            var employmentHistory=_context.EmploymentHistories.Where(x=>x.CompanyName==companyName);
            return employmentHistory;
        }
    }
}
