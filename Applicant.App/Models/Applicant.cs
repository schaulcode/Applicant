using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobApplicant.App.Models
{
    public class Applicant
    {
        [Display(Name ="First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name ="Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name ="Address Line 2")]
        public string Address2 { get; set; }
        [Display(Name ="Address Line 3")]
        public string Address3 { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        [Display(Name ="Moblie Phone")]
        public string MobilePhone { get; set; }
        [Required]
        [Display(Name ="Home Phone")]
        public string HomePhone { get; set; }
        [Required]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        public Applicant()
        {

        }
        public Applicant(Data.Model.Applicant applicant)
        {
            this.FirstName = applicant.FirstName;
            this.LastName = applicant.LastName;
            this.Email = applicant.Email;
            this.Address1 = applicant.Address1;
            this.Address2 = applicant.Address2;
            this.Address3 = applicant.Address3;
            this.Town = applicant.Town;
            this.County = applicant.County;
            this.Postcode = applicant.Poscode;
            this.MobilePhone = applicant.MobilePhone;
            this.HomePhone = applicant.HomePhone;
            this.StartDate = applicant.StartDate;
        }

        public static Data.Model.Applicant Reverse(Applicant applicant)
        {
            return new Data.Model.Applicant
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = applicant.Email,
                Address1 = applicant.Address1,
                Address2 = applicant.Address2,
                Address3 = applicant.Address3,
                Town = applicant.Town,
                County = applicant.County,
                Poscode = applicant.Postcode,
                MobilePhone = applicant.MobilePhone,
                HomePhone = applicant.HomePhone,
                StartDate = applicant.StartDate
            };
        }
    }
    
}