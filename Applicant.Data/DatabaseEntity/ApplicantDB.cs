using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JobApplicant.Data.Model;

namespace JobApplicant.Data.DatabaseEntity
{
    class ApplicantDB : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
    }
}
