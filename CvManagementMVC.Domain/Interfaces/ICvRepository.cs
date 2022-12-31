using CvManagementMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Interfaces
{
    public interface ICvRepository
    {
        int AddCv(Cv cv);


         void RemoveCv(int cvId);


         Cv GetCvByTitle(string title);


         IQueryable<Cv> GetAllCvs();
        
    }
}
