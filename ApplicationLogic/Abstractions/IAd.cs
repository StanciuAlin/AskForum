using DataAccess.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    interface IAd: IRepository<Ad>
    {
        IEnumerable<Comment> GetAdComments();
        IEnumerable<Comment> GetAdComments(User user);

    }
}
