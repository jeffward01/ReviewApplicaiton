using ReviewApplication.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class LeadProduct
    {
        public int LeadProductID { get; set; } //Primary Key
        public int CompanyID { get; set; } //Forign Key

        public string LeadType { get; set; }
        public string Price { get; set; }
        public string ProductNotes { get; set; }
        public string OrderLink { get; set; }


        //Add Virtual Varibles
        public virtual CompanyProfile CompanyProfile { get; set; }

        //Add methods if any (update)
        public void Update(LeadProductModel leadProduct)
        {
            LeadProductID = leadProduct.LeadProductID;
            CompanyID = leadProduct.CompanyID;
            LeadType = leadProduct.LeadType;
            Price = leadProduct.Price;
            ProductNotes = leadProduct.ProductNotes;
            OrderLink = leadProduct.OrderLink;
        }
    }
}
