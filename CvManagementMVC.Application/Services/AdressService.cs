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
        private readonly ICandidateAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(ICandidateAddressRepository AddressService, IMapper mapper)
        {
            _addressRepository = AddressService;
            _mapper = mapper;
        }

        public int AddAddress(NewAddressVm Address)
        {
            var candidateAddress=_mapper.Map<Address>(Address);
            var id= _addressRepository.AddCandidateAddress(candidateAddress);
            return id;
        }

        public NewAddressVm ShowAddress(int candidateId)
        {
            var candidateAddress= _addressRepository.GetCandidateAddressByCandidateId(candidateId);
            var modelCandidateAddress=_mapper.Map<NewAddressVm>(candidateAddress);
            return modelCandidateAddress;
        }

        public void RemoveAddress(int addressId)
        {
            _addressRepository.DeleteCandidateAddress(addressId);
        }

        public void UpdateAddress(NewAddressVm address)
        {
            var candidateAddress = _mapper.Map<Address>(address);
            _addressRepository.UpdateAddress(candidateAddress);
        }

        public NewAddressVm GetAddressForEdit(int id)
        {
            var candidateAddress=_addressRepository.GetCandidateAddressById(id);
            var modelAddress = _mapper.Map<NewAddressVm>(candidateAddress);
            return modelAddress;
        }
    }
}
