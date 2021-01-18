using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobApplicant.App.Models
{
    public class ListModel
    {
        public List<Applicant> Applicants { get; set; } = new List<Applicant>();
        [Display(Name ="Total Applicants")]
        public int TotalCount { get; set; }
        [Display(Name ="Earliest Start Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EarliestStartDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LatestStartDate { get; set; }
    }
}