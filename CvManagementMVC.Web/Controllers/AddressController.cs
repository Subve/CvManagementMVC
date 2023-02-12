using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Address;
using Microsoft.AspNetCore.Mvc;

namespace CvManagementMVC.Web.Controllers
{
    public class AddressController : Controller
    {
        private readonly ICandidateAddressService  _AddressService;
            
        public AddressController(ICandidateAddressService AddressService)
        {
                _AddressService=AddressService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]//AddressController/AddAddress/1
        [Route("Address/AddAddress/{candidateId}")]
        public IActionResult AddAddress(int candidateId)
        {
            var model=new NewAddressVm {CandidateId= candidateId };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddAddress(NewAddressVm model)
        {
            var id=_AddressService.AddAddress(model);
           return View(model);
        }
    }
}
