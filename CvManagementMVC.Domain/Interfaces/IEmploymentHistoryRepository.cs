using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface IEmploymentHistoryRepository
    {
        int AddEmploymentHistory(EmploymentHistory employmentHistory);
         void RemoveEmploymentHistory(int employmentHistoryId);
         IQueryable<EmploymentHistory> GetEmploymentHistoryByCvId(int cvId);
         IQueryable<EmploymentHistory> GetEmploymentHistoryByTitle(string title);
         IQueryable<EmploymentHistory> GetEmploymentHistoryByCompany(string companyName);
        
    }
}
