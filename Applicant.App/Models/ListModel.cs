using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobApplicant.App.Models
{
    public class ListModel
    {
        public List<Applicant> Applicants { get; set; }
        public int TotalCount { get; set; }
        public DateTime EarliestStartDate { get; set; }
        public DateTime LatestStartDate { get; set; }
    }
}