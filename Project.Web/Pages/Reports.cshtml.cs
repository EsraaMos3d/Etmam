using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Core;

namespace Project.Web.Pages
{
    public class ReportsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportsModel( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int AllTicketCount { get; set; }
        public int CreatedTicketCount { get; set; }
        public int ApprovedTicketCount { get; set; }
        public int RejectedTicketCount { get; set; }
        public int DeletedTicketCount { get; set; }
        public void OnGet()
        {
             AllTicketCount = _unitOfWork.Ticket.GetAll().Where(a => a.IsDeleted == false).Count();
             CreatedTicketCount = _unitOfWork.Ticket.GetAll().Where(a => a.IsDeleted == false && a.FK_TicketStatus_Id == 1).Count();
             ApprovedTicketCount = _unitOfWork.Ticket.GetAll().Where(a => a.IsDeleted == false && a.FK_TicketStatus_Id == 2).Count();
             RejectedTicketCount = _unitOfWork.Ticket.GetAll().Where(a => a.IsDeleted == false && a.FK_TicketStatus_Id == 3).Count();
             DeletedTicketCount = _unitOfWork.Ticket.GetAll().Where(a => a.IsDeleted == false && a.FK_TicketStatus_Id == 4).Count();
        }
    }
}
