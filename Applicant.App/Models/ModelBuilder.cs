using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobApplicant.Data.BusinesLogic;

namespace JobApplicant.App.Models
{
    public static class ModelBuilder
    {
        static DataBaseAccess DbAccess = new DataBaseAccess();
        public static List<Applicant> List()
        {
            return DbAccess.List().Select(e => new Applicant(e)).ToList();
        }
        public static void Add(Applicant applicant)
        {
            DbAccess.Add(Applicant.Reverse(applicant));
        }
    }
}