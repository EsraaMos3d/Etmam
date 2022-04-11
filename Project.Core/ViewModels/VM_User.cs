using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.ViewModels
{
    public class VM_User
    {

        public string UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
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
        public string RoleName { get; set; }
        public string RoleId { get; set; }
       
    }
}
