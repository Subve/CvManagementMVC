using AutoMapper;
using CvManagementMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Candidate
{
    public class CandidateForListVm : IMapFrom<CvManagementMVC.Domain.Model.Candidate>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CvManagementMVC.Domain.Model.Candidate, CandidateForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.isActive, opt => opt.MapFrom(s => s.isActive));
        }

    }
}
