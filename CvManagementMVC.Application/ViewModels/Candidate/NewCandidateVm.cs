using AutoMapper;
using CvManagementMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Candidate
{
    public class NewCandidateVm:IMapFrom<CvManagementMVC.Domain.Model.Candidate>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public bool isActive { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCandidateVm, CvManagementMVC.Domain.Model.Candidate>().ReverseMap();

        }
    }
}
