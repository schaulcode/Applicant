using JobApplicant.Data.DatabaseEntity;
using JobApplicant.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicant.Data.BusinesLogic
{
    public class DataBaseAccess
    {
        ApplicantDB db = new ApplicantDB();
        public void Add(Applicant applicant)
        {
            db.Applicants.Add(applicant);
        }
        public List<Applicant> List()
        {
            return db.Applicants.ToList();
        }
    }
}
