using AutoMapper;
using CvManagementMVC.Application.Mapping;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Cv
{
    public class NewCvVm : IMapFrom<CvManagementMVC.Domain.Model.Cv>
    {
        
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<EmploymentHistory> EmploymentHistory { get; set;}
        public virtual ICollection<EducationHistory> EducationHistory { get; set;}
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCvVm, CvManagementMVC.Domain.Model.Cv>().ReverseMap()
                .ForMember(s => s.Skill, opt => opt.Ignore())
                .ForMember(s => s.EducationHistory, opt => opt.Ignore())
                .ForMember(s => s.EmploymentHistory, opt => opt.Ignore());
        }
    }
}
