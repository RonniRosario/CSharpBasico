using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Base
{
    public class Company : PersonalInformation
    {
        public string companyname { get; set; }
        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string? fax  { get; set; }
    }
}
