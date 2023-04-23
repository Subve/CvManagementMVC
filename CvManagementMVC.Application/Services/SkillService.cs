using AutoMapper;
using AutoMapper.QueryableExtensions;
using CvManagementMVC.Application.ViewModels.Skill;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using SkillManagementMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        private readonly IMapper _mapper;
        public SkillService(ISkillRepository skillRepository, IMapper mapper) 
        {
            _mapper = mapper;
            _skillRepository = skillRepository;
        }
        public int AddSkill(NewSkillVm newSkill)
        {
            var skill = _mapper.Map<Skill>(newSkill);
            var id = _skillRepository.AddSkill(skill);
            return id;
        }

        public void DeleteSkill(int id)
        {
            _skillRepository.RemoveSkill(id);
        }

        public ListSkillsForListVm GetAllSkillsForList()
        {
            var skills = _skillRepository.GetAllSkills().ProjectTo<NewSkillVm>(_mapper.ConfigurationProvider).ToList();
            var skillList = new ListSkillsForListVm()
            {
                listSkills = skills,
                Count = skills.Count

            };
            return skillList;
        }

        public NewSkillVm GetSkillForDetails(int id)
        {
            throw new NotImplementedException();
        }

        public NewSkillVm ShowSkill(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkill(NewSkillVm newSkill)
        {
            throw new NotImplementedException();
        }
    }
}
