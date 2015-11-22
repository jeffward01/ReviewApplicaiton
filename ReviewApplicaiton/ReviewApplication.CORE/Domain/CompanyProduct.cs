using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class CompanyProduct
    {
        public int CompanyID { get; set; }
        public int ProductID { get; set; }

        public string LeadType { get; set; }
        public string Price { get; set; }
        public string ProductNotes { get; set; }


        //Add Vitrual Varibles

        //Add methods if any (update)
    }
}
