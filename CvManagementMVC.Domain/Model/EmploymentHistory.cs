using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Domain.Model
{
    public class EmploymentHistory
    {
        public int Id { get; set; }
        public int CvId { get; set; }
        public string CompanyName { get; set; }
        public DateTime EmploymentBegin { get; set; }
        public DateTime EmplotmentEnd { get; set; }
        public string Title { get; set; }
        public string DescriptionOfTasks { get; set; }
        public virtual Cv Cv { get; set; }
    }
}
