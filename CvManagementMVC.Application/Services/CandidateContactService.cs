using AutoMapper;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.CandidateContact;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class CandidateContactService : ICandidateContactService
    {
        private readonly ICandidateContactRepository _candidateContactRepository;
        private readonly IMapper _mapper;
        public CandidateContactService(ICandidateContactRepository candidateContactRepository, IMapper mapper)
        {
            _candidateContactRepository = candidateContactRepository;
            _mapper = mapper;
        }

        public int AddContact(NewCandidateContactVm contact)
        {
            var model = _mapper.Map<CandidateContact>(contact);
            var id = _candidateContactRepository.AddCandidateContact(model);
            return id;
        }

        public NewCandidateContactVm GetContactForEdit(int id)
        {
            var contactModel = _candidateContactRepository.GetCandidateContactById(id);
            var modelForEdit = _mapper.Map<NewCandidateContactVm>(contactModel);
            return modelForEdit;
        }

        public void RemoveContact(int contactId)
        {
            _candidateContactRepository.DeleteCandidateContact(contactId);
        }

        public NewCandidateContactVm ShowContact(int id)
        {
            var model = _candidateContactRepository.GetCandidateContactById(id);
            var modelForShow = _mapper.Map<NewCandidateContactVm>(model);
            return modelForShow;
        }

        public void UpdateContact(NewCandidateContactVm contact)
        {
            var modelForUpdate = _mapper.Map<CandidateContact>(contact);
            _candidateContactRepository.UpdateContact(modelForUpdate);
        }
    }
}
