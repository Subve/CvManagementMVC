using AutoMapper;
using CvManagementMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.CandidateContact
{
    public class NewCandidateContactVm:IMapFrom<CvManagementMVC.Domain.Model.CandidateContact>
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCandidateContactVm, CvManagementMVC.Domain.Model.CandidateContact>().ReverseMap();
        }
    }
}
