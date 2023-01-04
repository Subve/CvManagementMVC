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
            return View();
        }
        [HttpPost]
        public IActionResult AddCandidate(NewCandidateVm model)
        {
            var id= _candidateService.AddCandidate(model);
            return View();
        }
        public IActionResult ViewCandidate(int candidateId)
        {
            var candidateModel = _candidateService.GetCandidateDetails(candidateId);
            return View(candidateModel);
        }
    }
}
