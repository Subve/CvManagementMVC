using CvManagementMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            //utworzyc widok dla tej akcji
            //tabela z kandydatami
            //filtrowanie
            //przygotowanie danych
            //przekazanie filtrow do serwisu
            //serwis musi przygotowac
            //serwis musi zwrocic dane
            var model = candidateService.GetAllCandidatesForList();
            return View();
        }
        [HttpGet]
        public IActionResult AddCandidate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCandidate(Candidate model)
        {
            var id=customerService.AddCandidate(model);
            return View();
        }
        public IActionResult ViewCandidate(int candidateId)
        {
            var candidateModel = candidateModel.GetCandidate(candidateId);
            return View(candidateModel);
        }
    }
}
