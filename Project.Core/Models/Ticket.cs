using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//using System.Web.Mvc;

namespace Project.Core.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ticket_Id { get; set; }
        public string TicketNumber { get; set; }
        [ForeignKey("TicketType")]
        public int FK_TicketType_Id { get; set; }
        [ForeignKey("TicketStatus")]
        public int FK_TicketStatus_Id { get; set; }
        public string ApprovedBy { get; set; }
        public string Reason { get; set; }
        public byte[] Data { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        //created date
        public Nullable<System.DateTime> CreatedOn { get; set; }
        //status date
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        [ForeignKey("ApplicationUserCreatedBy")]
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        [ForeignKey("ApplicationUserModifiedBy")]
        public string ModifiedBy { get; set; }
        public virtual TicketStatus TicketStatus { get; set; }
        public virtual TicketType TicketType { get; set; }
        public virtual ApplicationUser ApplicationUserCreatedBy { get; set; }
        public virtual ApplicationUser ApplicationUserModifiedBy { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
