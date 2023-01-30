using AutoMapper;
using CvManagementMVC.Application.ViewModels.Candidate;
using CvManagementMVC.Domain.Model;
using CvManagementMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Interfaces
{
    public interface ICandidateService
    {
        
        ListCandidateForListVm GetAllCandidatesForList();
        int AddCandidate(NewCandidateVm candidate);
        CandidateDetailsVm GetCandidateDetails(int candidateId);
        void RemoveCandidate(int candidateId);
        NewCandidateVm GetCandidateForEdit(int id);
        void UpdateCandidate(NewCandidateVm model);
    }
}
