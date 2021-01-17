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
            if(applicants.Count > 0)
            {
                return new ListModel
                {
                    Applicants = applicants,
                    TotalCount = applicants.Count,
                    EarliestStartDate = applicants.OrderBy(e => e.StartDate).FirstOrDefault().StartDate,
                    LatestStartDate = applicants.OrderBy(e => e.StartDate).LastOrDefault().StartDate
                };
            }
            else
            {
                return new ListModel();
            }
            
        }
        public static void Add(Applicant applicant)
        {
            DbAccess.Add(Applicant.Reverse(applicant));
        }

        public static void Delete(int id)
        {
            DbAccess.Delete(id);
        }
    }
}