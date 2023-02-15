using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Address;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        [HttpGet]
        [Route("Address/Details/{candidateId}")]
        public IActionResult Details(int candidateId)
        {
            var model=_AddressService.ShowAddress(candidateId);
            if(model is null)
            {
                return RedirectToAction("AddAddress", "Address", new { candidateId = candidateId });

            }
            return View(model);
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
            if(ModelState.IsValid)
            {
                var id=_AddressService.AddAddress(model);
                return RedirectToAction("Index","Candidate");
            }
           
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteAddress(int id)
        {
            _AddressService.RemoveAddress(id);
            return RedirectToAction("Index", "Candidate");
        }
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var modelAddress = _AddressService.GetAddressForEdit(id);
            return View(modelAddress);
        }
        [HttpPost]
        public IActionResult EditAddress(NewAddressVm model)
        {
            if(ModelState.IsValid)
            {
                _AddressService.UpdateAddress(model);
                return RedirectToAction("Index", "Candidate");
            }
            return View(model);
        }
    }
}
