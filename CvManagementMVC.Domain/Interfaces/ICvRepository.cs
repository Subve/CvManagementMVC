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
        Cv GetCvByCandidateId(int candidateId);
        Cv GetCvByCvId(int cvId);
        void RemoveCv(int cvId);
        void UpdateCv(Cv cv);

        Cv GetCvByTitle(string title);
        IQueryable<Cv> GetAllCvs();

    }
}
