using Project.Core;
using Project.Core.Interfaces;
using Project.Core.Models;
using Project.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<ApplicationUser> ApplicationUser { get; private set; }
        public IBaseRepository<Student> Student { get; private set; }
        public IBaseRepository<Branch> Branch { get; private set; }
        public IBaseRepository<College> College { get; private set; }
        public IBaseRepository<Department> Department { get; private set; }
        public IBaseRepository<Ticket> Ticket { get; private set; }
        public ITicketRepository TicketRepository { get; private set; }
        public IBaseRepository<TicketStatus> TicketStatus { get; private set; }
        public IBaseRepository<Notification> Notification { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ApplicationUser = new BaseRepository<ApplicationUser>(_context);
            Student = new BaseRepository<Student>(_context);
            Branch = new BaseRepository<Branch>(_context);
            College = new BaseRepository<College>(_context);
            Department = new BaseRepository<Department>(_context);
            Ticket = new BaseRepository<Ticket>(_context);
            TicketStatus = new BaseRepository<TicketStatus>(_context);
            TicketRepository = new TicketRepository(_context);
            Notification = new BaseRepository<Notification>(_context);
            UserRepository = new UserRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
