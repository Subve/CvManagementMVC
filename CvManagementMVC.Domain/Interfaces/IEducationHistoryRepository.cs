using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface IEducationHistoryRepository
    {
        int AddEducationHistory(EducationHistory educationHistory);
        void RemoveEducationHistoryByEducationHistoryId(int educationHistoryId);
        EducationHistory GetEducationHistoryByCvId(int cvId);
        EducationHistory GetEducationHistoryById(int id);
        IQueryable<EducationHistory> GetEducationHistoryByDegree(string degreeEarned);
        IQueryable<EducationHistory> GetEducationHistoryBySchoolName(string schoolName);
        void UpdateEducationHistory(EducationHistory educationHistory);

    }
}
