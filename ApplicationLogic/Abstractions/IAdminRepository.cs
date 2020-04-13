using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    public interface IAdminRepository: IRepository<Admin>
    {
        Admin GetAdminByUserId(Guid adminId);
    }
}
