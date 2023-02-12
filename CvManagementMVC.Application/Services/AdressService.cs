using AutoMapper;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Address;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class AddressService : ICandidateAddressService
    {
        private readonly ICandidateAddressRepository _AddressRepository;
        private readonly IMapper _mapper;
        public AddressService(ICandidateAddressRepository AddressService, IMapper mapper)
        {
            _AddressRepository = AddressService;
            _mapper = mapper;
        }

        public int AddAddress(NewAddressVm Address)
        {
            var candidateAddress=_mapper.Map<Address>(Address);
            var id= _AddressRepository.AddCandidateAddress(candidateAddress);
            return id;
        }

        public NewAddressVm GetAddressForEdit(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAddress(int candidateId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(NewAddressVm Address)
        {
            throw new NotImplementedException();
        }
    }
}
