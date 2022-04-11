using Project.Core.Models;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Core.Interfaces
{
    public interface IUserRepository: IBaseRepository<ApplicationUser>
    {
        IQueryable <VM_User> GetAllUser();
    }
}
