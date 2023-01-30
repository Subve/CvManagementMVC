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
            profile.CreateMap<CvManagementMVC.Domain.Model.Candidate, CandidateForListVm>().ReverseMap();
                
        }

    }
}
