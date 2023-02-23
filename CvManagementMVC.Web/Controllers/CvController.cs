using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Cv;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class CvController : Controller
    {
        private readonly ICvService _cvService;
        public CvController(ICvService cvService)
        {
            _cvService = cvService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _cvService.GetAllCvsForList();
            return View(model);
        }
        [Route("Cv/CreateCv/{candidateId}")]
        [HttpGet]
        public IActionResult CreateCv(int candidateId)
        {
            NewCvVm model = new NewCvVm()
            {
                CandidateId = candidateId,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateCv(NewCvVm model)
        {
            if (ModelState.IsValid)
            {
                var id = _cvService.AddCv(model);
                return RedirectToAction("Index", "Candidate");
            }
            return View(model);
        }
        [Route("Cv/ShowCv/{candidateId}")]
        [HttpGet]
        public IActionResult ShowCv(int candidateId)
        {
            var model = _cvService.GetCvForDetails(candidateId);
            if (model is null)
            {
                return RedirectToAction("CreateCv", new { candidateId = candidateId });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteCv(int id)
        {
            _cvService.DeleteCv(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCv(int id)
        {
            var model=_cvService.GetCvForDetails(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCv(NewCvVm model)
        {
            if(ModelState.IsValid)
            {
                _cvService.UpdateCv(model);
                return RedirectToAction("ShowCv",new {id = model.Id });
            }
            return View(model);
        }
    }
}
