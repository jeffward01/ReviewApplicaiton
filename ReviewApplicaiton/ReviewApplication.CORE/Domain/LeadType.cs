using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    class LeadType
    {
        public int LeadTypeTableID { get; set; }
        public bool TelemarketerLeads { get; set; }
        public string TelemarketingLeadNotes { get; set; }
        
        public bool MailLeads { get; set; }
        public string MailLeadLeadNotes { get; set; }

        public bool Press1Leads { get; set; }
        public string Press1LeadNotes { get; set; }

        public bool InternetLeads { get; set; }
        public string InternetLeadNotes { get; set; }

        public bool ColdCallPhoneNumberLists { get; set; }
        public string ColdCallPhoneNumberListLeadNotes { get; set; }



        //Add Vitrual Varibles

        //Add methods if any (update)


    }
}
