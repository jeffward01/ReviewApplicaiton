using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Models
{
    public class LeadProductModel
    {
        public int LeadProductID { get; set; } //Primary Key
        public int CompanyID { get; set; } //Forign Key

        public string LeadType { get; set; }
        public string Price { get; set; }
        public string ProductNotes { get; set; }


        //Add Vitrual Varibles

        //Add methods if any (update)
    }
}
