using AutoMapper;
using CvManagementMVC.Application.Mapping;
using CvManagementMVC.Application.ViewModels.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.CvSkill
{
    public class NewCvSkillVm : IMapFrom<CvManagementMVC.Domain.Model.CvSkill>
    {
        public int Id { get; set; }
        public int CvId { get; set; }
        public int SkillId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCvSkillVm, CvManagementMVC.Domain.Model.CvSkill>().ReverseMap();

        }
    }
}
