using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.ViewModels
{
    public class VM_Ticket
    {
        public int Ticket_Id { get; set; }
        public string TicketNumber { get; set; }
        public int FK_TicketType_Id { get; set; }
        public int FK_TicketStatus_Id { get; set; }
        public string ApprovedBy { get; set; }
        public string TicketTypeName_Ar { get; set; }
        public string TicketTypeName_En { get; set; }
        public string TicketStatusName_Ar { get; set; }
        public string TicketStatusName_En { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Reason { get; set; }
        public byte[] Data { get; set; }
        public string DataURL { get; set; }
        
    }
}
