using AutoMapper;
using AutoMapper.QueryableExtensions;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.ViewModels.Cv;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Domain.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.Services
{
    public class CvService : ICvService
    {
        private readonly ICvRepository _cvRepository;
        private readonly IMapper _mapper;
        public CvService(ICvRepository cvRepository, IMapper mapper)
        {
            _cvRepository = cvRepository;
            _mapper = mapper;
        }

        public int AddCv(NewCvVm newCv)
        {
            var cvModel = _mapper.Map<Cv>(newCv);
            var id = _cvRepository.AddCv(cvModel);
            return id;
        }

        public void DeleteCv(int id)
        {
            _cvRepository.RemoveCv(id);
        }

        public ListCvsForListVm GetAllCvsForList()
        {
            var cvs = _cvRepository.GetAllCvs().ProjectTo<NewCvVm>(_mapper.ConfigurationProvider).ToList();
            var cvsList = new ListCvsForListVm()
            {
                CvList = cvs,
                Count = cvs.Count
            };
            return cvsList;
        }

        public NewCvVm GetCvForDetails(int id)
        {
            var cv=_cvRepository.GetCvByCvId(id);
            var cvModel=_mapper.Map<NewCvVm>(cv);
            return cvModel;
        }

        public NewCvVm ShowCv(int id)
        {
            var cv = _cvRepository.GetCvByCvId(id);
            var cvModel = _mapper.Map<NewCvVm>(cv);
            return cvModel;
        }

        public void UpdateCv(NewCvVm newCv)
        {
            var newCvModel = _mapper.Map<Cv>(newCv);
            _cvRepository.UpdateCv(newCvModel);

        }
    }
}
