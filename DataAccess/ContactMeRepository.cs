using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ContactMeRepository: BaseRepository<ContactMe>, IContactMeRepository
    {
        public ContactMeRepository(AskForumDbContext dbContext) : base(dbContext)
        {
        }

        void IContactMeRepository.AddRequest(string contactRequestName, string contactRequestEmail, string contactRequestMessageContent)
        {
            throw new NotImplementedException();
        }
    }
}
