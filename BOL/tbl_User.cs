using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
   public class tbl_User
 {
       public int UserId { get; set; }
       public string UserName  { get; set; }
       public string Password { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string UserGender { get; set; }
       public string Mobile { get; set; }
        public string IsActive { get; set; }
        public DateTime UserDob { get; set; }
        public string Skillset { get; set; }
        public string Expereience { get; set; }
        public int RoleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
