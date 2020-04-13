using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    public interface IContactMeRepository: IRepository<ContactMe>
    {
        void AddRequest(string contactRequestName, string contactRequestEmail, string contactRequestMessageContent);
    }
}
