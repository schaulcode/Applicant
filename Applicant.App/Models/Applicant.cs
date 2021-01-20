using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using JobApplicant.App.HelperLibary;

namespace JobApplicant.App.Models
{
    public class Applicant
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        [Display(Name = "Address Line 3")]
        public string Address3 { get; set; }
        [Required]
        public string Town { get; set; }
        public string County { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})$", ErrorMessage = "This is not a valid UK Postcode format")]
        public string Postcode { get; set; }
        [Required]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^0(\d{10})$", ErrorMessage ="This is not a valid Mobile Number format")]
        public string MobilePhone { get; set; }
        [Display(Name ="Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^0(\d{9,10})$", ErrorMessage = "This is not a valid Home Number format")]
        public string HomePhone { get; set; }
        [Required]
        [DateRange(ErrorMessage = "The Start Date must be between Today and {2:dd/MM/yyyy}")]
        [Display(Name ="Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        [Display(Name ="Address")]
        public string FormatedAddress { get; set; }

        public Applicant()
        {

        }
        public Applicant(Data.Model.Applicant applicant)
        {
            this.ID = applicant.ID;
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
            this.FormatedAddress = applicant.Address1 + "\n" + ((!String.IsNullOrEmpty(applicant.Address2)) ? applicant.Address2 + "\n" : "") + ((!String.IsNullOrEmpty(applicant.Address3)) ? applicant.Address3 + "\n" : "") + applicant.Town + "\n" + applicant.County + "\n" + applicant.Poscode;
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