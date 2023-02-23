using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.CandidateContact;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class CandidateContactController : Controller
    {
        private readonly ICandidateContactService _candidateContactService;
        public CandidateContactController(ICandidateContactService candidateContactService)
        {
            _candidateContactService= candidateContactService;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [Route("CandidateContact/CreateContact/{candidateId}")]
        [HttpGet]
        public IActionResult CreateContact(int candidateId)
        {
            NewCandidateContactVm newContactModel = new NewCandidateContactVm()
            {
                CandidateId = candidateId,
            };
            return View(newContactModel);
        }
        [HttpPost]
        public IActionResult CreateContact(NewCandidateContactVm newContactModel)
        {
            if(ModelState.IsValid)
            {
                var id=_candidateContactService.AddContact(newContactModel);
                return RedirectToAction("Index","Candidate");
            }
            return View(newContactModel);
        }
        [HttpGet]
        public IActionResult DetailsOfContact(int id)
        {
            var model=_candidateContactService.ShowContact(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var model = _candidateContactService.GetContactForEdit(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditContact(NewCandidateContactVm model)
        {
            if(ModelState.IsValid)
            {
                _candidateContactService.UpdateContact(model);
                return RedirectToAction("DetailsOfContact", new { id = model.Id });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteContact(int id)
        {
            _candidateContactService.RemoveContact(id);
            return RedirectToAction("Index", "Candidate");
        }
    }
}
