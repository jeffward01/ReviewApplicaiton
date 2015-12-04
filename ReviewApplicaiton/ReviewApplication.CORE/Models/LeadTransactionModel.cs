using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Models
{
    public class LeadPurchaseModel
    {
        public DateTime PurchaseDate { get; set; }
        public int LeadPurchaseID { get; set; }
        public int CompanyProfileID { get; set; }
        public int LeadProductID { get; set; }
        public int InsuranceAgentProfileID { get; set; }
        public int PurchasePrice { get; set; }
        public string PurchaseNotes { get; set; }

        public CompanyProfileModel Company { get; set; }
        public LeadProductModel LeadProduct {get;set;}
        public InsuranceProfileAgentModel InsuranceAgent { get; set; }
    }
}
