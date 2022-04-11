using Project.Core.Interfaces;
using Project.Core.Models;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.EF.Repositories
{
    public class TicketRepository:BaseRepository<Ticket>,ITicketRepository
    {
        private readonly ApplicationDbContext _context;
        public TicketRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
       
        public IQueryable<VM_Ticket> GetAllTicket()
        {
            var Ticket = (from T in _context.Ticket
             join TS in _context.TicketStatus
             on T.FK_TicketStatus_Id equals TS.TicketStatus_ID
             join TT in _context.TicketType
             on T.FK_TicketType_Id equals TT.TicketType_ID 
             where T.IsDeleted == false 
             select (new VM_Ticket()
             {
                Ticket_Id=T.Ticket_Id,
                TicketNumber=T.TicketNumber,
                FK_TicketStatus_Id=T.FK_TicketStatus_Id,
                FK_TicketType_Id=T.FK_TicketType_Id,
                ApprovedBy=T.ApprovedBy,
                CreatedOn=T.CreatedOn,
                ModifiedOn=T.ModifiedOn,
                TicketStatusName_Ar=TS.Name_Ar,
                TicketStatusName_En=TS.Name_En,
                TicketTypeName_Ar=TT.Name_Ar,
                TicketTypeName_En=TT.Name_En,
                CreatedBy=T.CreatedBy,
                ModifiedBy=T.ModifiedBy,
                Reason=T.Reason,
                Data=T.Data,
                DataURL= (T.Data !=null ?string.Format("data:image/png;base64,{0}", Convert.ToBase64String(T.Data)):"")
        }));
            return Ticket;
        }
    }
}
