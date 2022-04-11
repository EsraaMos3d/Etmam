using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Project.Core.Models
{
    public class ApplicationUser: IdentityUser
    {
        public int FK_Branch_Id { get; set; }
        public int FK_College_Id { get; set; }
        public int FK_Department_Id { get; set; }
        public string UserNumber { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string NID { get; set; }
        public string Address { get; set; }
        public string Full_Name_Ar { get; set; }
        public string Full_Name_En { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
