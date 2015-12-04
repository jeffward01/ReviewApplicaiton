using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class CompanyProfile
    {
        public int CompanyID { get; set; } //Primary Key
        public int UserID { get; set; }  // Foreign Key

        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string TelephoneNumber { get; set; }
        public string OtherTelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string SkypeHandle { get; set; }
        public string WebsiteURL { get; set; }
        public string PictureLogoURL { get; set; }
        public string Bio { get; set; }
        public string LeadNotes { get; set; }
        public string PaymentNotes { get; set; }
        
        //Payment Area  || Stripe?
        public bool AcceptsCredit { get; set; }
        public string CreditComments { get; set; }
        public bool AcceptsDebit { get; set; }
        public string DebitComments { get; set; }
        public bool AcceceptsAmericanExpress { get; set; }
        public string AmericanExpressComments { get; set; }
        public bool AcceptsPaypal { get; set; }
        public string PaypalEmailAddress { get; set; }
        public string PaypalComments { get; set; }
        public bool AcceptsMoneyOrder { get; set; }
        public string MoneyOrderComments { get; set; }
        public bool AcceptsVenmo { get; set; }
        public string VenmoComments { get; set; }
        public string VenmoHandle { get; set; }

        public int CompanyRating
        {
            get
            {
                return (int)Math.Round(ReviewPosts.Average(rp => rp.CompanyRating), 0);
            }
        }

        //Add ProductInformation (Leads Offered)

        //Add Virtual Properties
        public virtual ICollection<ReviewPost> ReviewPosts { get; set; }

        //Add methods (update)


     

    }
}
