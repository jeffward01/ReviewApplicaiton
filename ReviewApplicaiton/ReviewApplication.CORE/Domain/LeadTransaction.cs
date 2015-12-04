using ReviewApplication.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
   public class LeadPurchase
    {
        public DateTime PurchaseDate { get; set; }
        public int LeadPurchaseID { get; set; }
        public int CompanyProfileID { get; set; }
        public int LeadProductID { get; set; }
        public int InsuranceAgentProfileID { get; set; }
        public int PurchasePrice { get; set; }
        public string PurchaseNotes { get; set; }
       
        public virtual InsuranceAgentProfile Agent { get; set; }
        public virtual CompanyProfile Company { get; set; }
        public virtual LeadProduct LeadProduct { get; set; }
             
        public void Update(LeadPurchaseModel leadPurchaseModel)
        {
            //If purchase is new, set purchase date to now
            if(leadPurchaseModel.LeadPurchaseID == 0)
            {
                PurchaseDate = DateTime.Now;
            }

            LeadProductID = leadPurchaseModel.LeadProductID;
            CompanyProfileID = leadPurchaseModel.CompanyProfileID;
            LeadProductID = leadPurchaseModel.LeadProductID;
            InsuranceAgentProfileID = leadPurchaseModel.InsuranceAgentProfileID;
            PurchasePrice = leadPurchaseModel.PurchasePrice;
            PurchaseNotes = leadPurchaseModel.PurchaseNotes;
        }

    }
}
