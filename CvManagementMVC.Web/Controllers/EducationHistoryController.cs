using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.EducationHistory;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class EducationHistoryController : Controller
    {
        private readonly IEducationHistoryService _educationHistoryService;
        public EducationHistoryController(IEducationHistoryService educationHistoryService)
        {
            _educationHistoryService = educationHistoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int cvId)
        {
            var model = _educationHistoryService.GetEducationHistoryDetails(cvId);
            if(model is null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int cvId)
        {
            var educationModel = _educationHistoryService.GetEducationHistoryDetails(cvId);
            return View(educationModel);
        }
        [HttpPost]
        public IActionResult Edit(NewEducationHistoryVm educationModel)
        {
            if(ModelState.IsValid)
            {
                _educationHistoryService.UpdateEducationHistory(educationModel);
                return RedirectToAction("Details",new {cvId=educationModel.Id});
            }
            return View(educationModel);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _educationHistoryService.RemoveEducationHistoryById(id);
            return RedirectToAction("Index", "Candidate");
        }
        [HttpGet]
        public IActionResult Create(int cvId)
        {
            NewEducationHistoryVm educationHistory = new NewEducationHistoryVm()
            {
                CvId = cvId
            };
            return View(educationHistory);
        }
        [HttpPost]
        public IActionResult Create(NewEducationHistoryVm educationHistory)
        {
            if(ModelState.IsValid)
            {
                var id = _educationHistoryService.AddEducationHistory(educationHistory);
                return RedirectToAction("Details",new {cvId=educationHistory.CvId});
            }
            return View(educationHistory) ;
        }
    }
}
