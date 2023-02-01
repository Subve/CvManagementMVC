using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.Services;
using CvManagementMVC.Application.ViewModels.Candidate;
using CvManagementMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService= candidateService;
        }
        public IActionResult Index()
        {
            //utworzyc widok dla tej akcji
            //tabela z kandydatami
            //filtrowanie
            //przygotowanie danych
            //przekazanie filtrow do serwisu
            //serwis musi przygotowac
            //serwis musi zwrocic dane
            var model = _candidateService.GetAllCandidatesForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCandidate()
        {
            return View(new NewCandidateVm());
        }
        [HttpPost]
        public IActionResult AddCandidate(NewCandidateVm model)
        {
            if (ModelState.IsValid)
            { var id = _candidateService.AddCandidate(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        //[Route("Candidate/ViewCandidate/{candidateId}")]
        public IActionResult ViewCandidate(int id)
        {
            var candidateModel = _candidateService.GetCandidateDetails(id);
            return View(candidateModel);
        }
        [HttpGet]
        //[Route("Candidate/Delete/{candidateId}")]
        public IActionResult Delete(int id)
        {
            _candidateService.RemoveCandidate(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCandidate(int id)
        {
            var candidate=_candidateService.GetCandidateForEdit(id);
            return View(candidate);
        }
        [HttpPost]
        public IActionResult EditCandidate(NewCandidateVm model)
        {
            if (ModelState.IsValid)
            {
                _candidateService.UpdateCandidate(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
