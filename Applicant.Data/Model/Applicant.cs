using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicant.Data.Model
{
    public class Applicant
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Poscode { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime StartDate { get; set; }
    }
}
