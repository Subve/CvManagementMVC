using AutoMapper;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Adress;
using CvManagementMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class AdressService : ICandidateAdressService
    {
        private readonly ICandidateAdressRepository _adressRepository;
        private readonly IMapper _mapper;
        public AdressService(ICandidateAdressRepository adressService, IMapper mapper)
        {
            _adressRepository = adressService;
            _mapper = mapper;
        }

        public int AddAdress(NewAdressVm adress)
        {
            throw new NotImplementedException();
        }

        public NewAdressVm GetAdressForEdit(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAdress(int candidateId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdress(NewAdressVm adress)
        {
            throw new NotImplementedException();
        }
    }
}
