using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;

namespace ApplicationLogic.Abstractions
{
    public interface IUserRepository: IRepository<User>
    {
        User GetUserByUserId(Guid userId);
     
    }
}
