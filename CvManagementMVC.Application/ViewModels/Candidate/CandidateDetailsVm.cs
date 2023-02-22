using AutoMapper;
using CvManagementMVC.Application.Mapping;
using CvManagementMVC.Application.ViewModels.Address;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Candidate
{
    public class CandidateDetailsVm:IMapFrom<CvManagementMVC.Domain.Model.Candidate>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public ListAddressForListVm Address { get; set; }
        public ContactDetailListVm Email { get; set; }
        public ContactDetailListVm PhoneNumber { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CvManagementMVC.Domain.Model.Candidate, CandidateDetailsVm>()
                .ForMember(s => s.FullName, opt => opt.MapFrom(d => d.FirstName + " " + d.LastName))
                .ForMember(s => s.Address, opt => opt.Ignore())
                .ForMember(s => s.Email, opt => opt.Ignore())
                .ForMember(s=>s.PhoneNumber, opt => opt.Ignore());

        }

    }
}
