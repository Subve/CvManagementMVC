using AutoMapper;
using AutoMapper.QueryableExtensions;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.EducationHistory;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class EducationHistoryService:IEducationHistoryService
    { 
        private readonly IEducationHistoryRepository _educationHistoryRepository;
        private readonly IMapper _mapper;
        public EducationHistoryService(IEducationHistoryRepository educationHistoryRepository, IMapper mapper)
        {
            _educationHistoryRepository = educationHistoryRepository;
            _mapper = mapper;
        }

        public int AddEducationHistory(NewEducationHistoryVm educationHistory)
        {
            var educationHistoryModel = _mapper.Map<EducationHistory>(educationHistory);
            var id = _educationHistoryRepository.AddEducationHistory(educationHistoryModel);
            return id;
        }

        public NewEducationHistoryVm GetEducationHistoryDetails(int cvId)
        {
            var educationHistory=_educationHistoryRepository.GetEducationHistoryByCvId(cvId);
            var educationHistoryModel = _mapper.Map<NewEducationHistoryVm>(educationHistory);
            return educationHistoryModel;
        }

        public NewEducationHistoryVm GetEducationHistoryForEdit(int id)
        {
            var educationHistory = _educationHistoryRepository.GetEducationHistoryById(id);
            var educationHistoryModel = _mapper.Map<NewEducationHistoryVm>(educationHistory);
            return educationHistoryModel;
        }

        public void RemoveEducationHistoryById(int id)
        {
            _educationHistoryRepository.RemoveEducationHistoryByEducationHistoryId(id);
        }

        public void UpdateEducationHistory(NewEducationHistoryVm model)
        {
            var educationModel = _mapper.Map<EducationHistory>(model);
            _educationHistoryRepository.UpdateEducationHistory(educationModel);
        }
    }
}
