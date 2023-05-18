using AutoMapper;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.CvSkill;
using CvManagementMVC.Application.ViewModels.Skill;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class CvSkillServicecs : ICvSkillService
    {
        private readonly ICvSkillRepository _cvSkillRepository;
        private readonly IMapper _mapper;
        public CvSkillServicecs(ICvSkillRepository cvSkillRepository,IMapper mapper)
        {
            _cvSkillRepository = cvSkillRepository;
            _mapper = mapper;
        }

        public int AddCvSkill(NewCvSkillVm newCvSkillVm)
        {   
            var cvSkillVm = _mapper.Map<CvSkill>(newCvSkillVm);
            var id = _cvSkillRepository.AddCvSkill(cvSkillVm);
            return id;
        }

        public void DeleteCvSkill(int cvSkillId)
        {
            _cvSkillRepository.RemoveCvSkill(cvSkillId);
        }

        public void UpdateCvSkill(NewCvSkillVm newCvSkillVm)
        {
            var cvSkillVm = _mapper.Map<CvSkill>(newCvSkillVm);
            _cvSkillRepository.UpdateCvSkill(cvSkillVm);
        }
    }
}
