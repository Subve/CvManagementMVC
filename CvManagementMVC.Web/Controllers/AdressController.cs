using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Adress;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class AdressController : Controller
    {
        private readonly ICandidateAdressService  _adressService;
            
        public AdressController(ICandidateAdressService adressService)
        {
                _adressService=adressService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]//AdressController/AddAdress/1
        //[Route("Adress/AddAdress/{candidateId}")]
        public IActionResult AddAdress(int id)
        {
            var model=new NewAdressVm {CandidateId=id};
            return View(model);
        }
        [HttpPost]
        public IActionResult AddAdress(NewAdressVm model)
        {
            var id=_adressService.AddAdress(model);
           return View(model);
        }
    }
}
