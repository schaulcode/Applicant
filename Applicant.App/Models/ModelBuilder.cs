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
        public static ListModel List()
        {
            var applicants = DbAccess.List().Select(e => new Applicant(e)).ToList();
            return new ListModel
            {
                Applicants = applicants,
                TotalCount = applicants.Count,
                EarliestStartDate = applicants.OrderBy(e => e.StartDate).First().StartDate,
                LatestStartDate = applicants.OrderBy(e => e.StartDate).Last().StartDate
            };
        }
        public static void Add(Applicant applicant)
        {
            DbAccess.Add(Applicant.Reverse(applicant));
        }
    }
}