using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
   public class UserProfile
    {
        public int UserID { get; set; } // Primary Key

        public string  Email { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; }

        //Add Vitrual Varibles

        //Add methods if any (update)

        
        
    }
}
