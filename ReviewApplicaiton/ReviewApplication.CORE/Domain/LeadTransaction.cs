﻿using ReviewApplication.CORE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
   public class LeadTransaction
    {

        [Key, ForeignKey("CompanyProfile")]
        public int CompanyID { get; set; } //Forign Key

        public DateTime TransactionDate { get; set; }
        public int LeadTransactionID { get; set; } // Primary Key
        public int LeadProductID { get; set; }
        public int InsuranceAgentProfileID { get; set; }
        public int TransactionPrice { get; set; }
        public string TransactionNotes { get; set; }
       
        public virtual InsuranceAgentProfile Agent { get; set; }
        public virtual CompanyProfile Company { get; set; }
        public virtual LeadProduct LeadProduct { get; set; }
             
        public void Update(LeadTransactionModel leadTransactionModel)
        {
            //If Transaction is new, set Transaction date to now
            if(leadTransactionModel.LeadTransactionID == 0)
            {
                TransactionDate = DateTime.Now;
            }

            LeadProductID = leadTransactionModel.LeadProductID;
            CompanyID = leadTransactionModel.CompanyID;
            LeadProductID = leadTransactionModel.LeadProductID;
            InsuranceAgentProfileID = leadTransactionModel.InsuranceAgentProfileID;
            TransactionPrice = leadTransactionModel.TransactionPrice;
            TransactionNotes = leadTransactionModel.TransactionNotes;
        }

    }
}
