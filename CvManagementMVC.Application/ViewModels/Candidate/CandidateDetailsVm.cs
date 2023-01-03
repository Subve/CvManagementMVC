using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application.ViewModels.Candidate
{
    public class CandidateDetailsVm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public AdressForListVm Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
