using AutoMapper;
using CvManagementMVC.Application.Mapping;
using CvManagementMVC.Application.ViewModels.CandidateContact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Skill
{
    public class NewSkillVm : IMapFrom<CvManagementMVC.Domain.Model.Skill>
    {

        public int Id { get; set; }
        public int CvId { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewSkillVm, CvManagementMVC.Domain.Model.Skill>().ReverseMap()
                .ForMember(s => s.CvId, opt => opt.Ignore());
        }
    }
}
