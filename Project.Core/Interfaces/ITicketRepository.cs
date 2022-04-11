using Project.Core.Models;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Core.Interfaces
{
    public interface ITicketRepository :IBaseRepository<Ticket>
    {
        IQueryable<VM_Ticket> GetAllTicket();
    }
}
