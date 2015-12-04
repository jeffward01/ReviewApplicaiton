﻿using ReviewApplication.CORE.Models;
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
        public virtual ICollection<LeadProduct> LeadProducts { get; set; }
        public virtual ICollection<ReviewPost> ReviewPosts { get; set; }

        //Add methods (update)
        public void Update(CompanyProfileModel companyProfile)
        {
            CompanyID = companyProfile.CompanyID;
            UserID = companyProfile.UserID;
            CompanyName = companyProfile.CompanyName;
            Address1 = companyProfile.Address1;
            Address2 = companyProfile.Address2;
            State = companyProfile.State;
            City = companyProfile.State;
            Zip = companyProfile.Zip;
            TelephoneNumber = companyProfile.TelephoneNumber;
            OtherTelephoneNumber = companyProfile.OtherTelephoneNumber;
            EmailAddress = companyProfile.EmailAddress;
            SkypeHandle = companyProfile.SkypeHandle;
            WebsiteURL = companyProfile.WebsiteURL;
            PictureLogoURL = companyProfile.PictureLogoURL;
            Bio = companyProfile.Bio;
            LeadNotes = companyProfile.LeadNotes;
            PaymentNotes = companyProfile.PaymentNotes;

            //Payment Area  || Stripe?
            AcceptsCredit = companyProfile.AcceptsCredit;
            CreditComments = companyProfile.CreditComments;
            AcceptsDebit = companyProfile.AcceptsDebit;
            DebitComments = companyProfile.DebitComments;
            AcceceptsAmericanExpress = companyProfile.AcceceptsAmericanExpress;
            AmericanExpressComments = companyProfile.AmericanExpressComments;
            AcceptsPaypal = companyProfile.AcceptsPaypal;
            PaypalEmailAddress = companyProfile.PaypalEmailAddress;
            PaypalComments = companyProfile.PaypalComments;
            AcceptsMoneyOrder = companyProfile.AcceptsMoneyOrder;
            MoneyOrderComments = companyProfile.MoneyOrderComments;
            AcceptsVenmo = companyProfile.AcceptsVenmo;
            VenmoComments = companyProfile.VenmoComments;
            VenmoHandle = companyProfile.VenmoHandle;

            
        }
        

     

    }
}
