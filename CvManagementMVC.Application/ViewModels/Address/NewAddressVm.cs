using AutoMapper;
using CvManagementMVC.Application.Mapping;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Address
{
    public class NewAddressVm : IMapFrom<CvManagementMVC.Domain.Model.Address>
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewAddressVm, Domain.Model.Address>();
        }
        
    }
}
