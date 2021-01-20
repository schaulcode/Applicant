using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobApplicant.App.HelperLibary
{
    public class DateRangeAttribute: RangeAttribute
    {
        public DateRangeAttribute() : base(typeof(DateTime), DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.AddYears(1).ToString("dd/MM/yyyy"))
        {

        }
    }
}