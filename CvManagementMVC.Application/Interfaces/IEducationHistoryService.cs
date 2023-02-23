using CvManagementMVC.Application.ViewModels.EducationHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface IEducationHistoryService
    {
        
        int AddEducationHistory(NewEducationHistoryVm educationHistory);
        NewEducationHistoryVm GetEducationHistoryDetails(int cvId);
        void RemoveEducationHistoryById(int id);
        NewEducationHistoryVm GetEducationHistoryForEdit(int id);
        void UpdateEducationHistory(NewEducationHistoryVm model);
    }
}
