using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.CvSkill;
using CvManagementMVC.Application.ViewModels.EducationHistory;
using CvManagementMVC.Application.ViewModels.Skill;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using SkillManagementMVC.Application.Interfaces;

namespace CvManagementMVC.Web.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;
        private readonly ICvSkillService _cvSkillService;
        public SkillController(ISkillService skillService, ICvSkillService cvSkillService)
        {
            _skillService = skillService;
            _cvSkillService = cvSkillService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create(int cvId)
        {
            NewSkillVm newSkillVm = new NewSkillVm()
            {
                CvId = cvId
            };
            return View(newSkillVm);
        }
        [HttpPost]
        public IActionResult Create(NewSkillVm newSkillVm)
        {
            if (ModelState.IsValid)
            {
                var skillId = _skillService.AddSkill(newSkillVm);
                NewCvSkillVm newCvSkillVm = new NewCvSkillVm()
                    {
                    CvId = newSkillVm.CvId,
                    SkillId = skillId
                };
                var cvSkillId = _cvSkillService.AddCvSkill(newCvSkillVm);
                return RedirectToAction("Details", new { cvId = newSkillVm.CvId });
            }
            return View(newSkillVm);
        }
    }
}
