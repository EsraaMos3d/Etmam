using Project.Core.Interfaces;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<ApplicationUser> ApplicationUser { get; }
        IBaseRepository<Student> Student { get; }
        IBaseRepository<Branch> Branch { get;  }
        IBaseRepository<College> College { get;}
        IBaseRepository<Department> Department { get;}
         IBaseRepository<Ticket> Ticket { get;}
         ITicketRepository TicketRepository { get;}
        IBaseRepository<TicketStatus> TicketStatus {get; }
        IBaseRepository<Notification> Notification { get; }
        IUserRepository UserRepository { get; }
        int Complete();
    }
}
