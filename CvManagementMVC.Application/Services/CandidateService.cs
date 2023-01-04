using AutoMapper;
using AutoMapper.QueryableExtensions;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Candidate;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;
        /*public CandidateService()
        {

        }*/
        public CandidateService(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public int AddCandidate(NewCandidateVm candidate)
        {
            return 1;
        }

        public ListCandidateForListVm GetAllCandidatesForList()
        {
            var candidates = _candidateRepository.GetAllActiveCandidates().ProjectTo<CandidateForListVm>(_mapper.ConfigurationProvider).ToList();
            var candidatesList = new ListCandidateForListVm()
            {
                Candidates = candidates,
                Count = candidates.Count
            };


            
            return candidatesList;
        }

        public CandidateDetailsVm GetCandidateDetails(int candidateId)
        {
            var candidate = _candidateRepository.GetCandidate(candidateId);
            var candidateVm=_mapper.Map<CandidateDetailsVm>(candidate);
           /* var candidateVm = new CandidateDetailsVm();

            candidateVm.Id= candidate.Id;
            candidateVm.FullName= candidate.FirstName + " "+candidate.LastName;
            candidateVm.Age=candidate.Age;
            candidateVm.Nationality=candidate.Nationality;
            candidateVm.PhoneNumber = candidate.CandidateContact.PhoneNumber;
            candidateVm.Email = candidate.CandidateContact.Email;
            var adress = new AdressForListVm()
            {
                Id = candidate.Id,
                City = candidate.CandidateAdress.City,
                Country = candidate.CandidateAdress.Country,
                PostalCode = candidate.CandidateAdress.PostalCode,
                Region = candidate.CandidateAdress.Region
            };
            candidateVm.Adress= adress;*/
            return candidateVm;
            
        }
    }
}
