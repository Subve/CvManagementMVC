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
            _cvService= cvService;
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
            if(ModelState.IsValid)
            {
                var id = _cvService.AddCv(model);
                return RedirectToAction("Index", "Candidate");
            }
            return View(model);
        }
        
        
    }
}
