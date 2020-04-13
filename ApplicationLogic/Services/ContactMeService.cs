using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Services
{
    class ContactMeService
    {
        private IContactMeRepository contactMeRepository;
        public ContactMeService(IContactMeRepository contactMeRepository)
        {
            this.contactMeRepository = contactMeRepository;
        }
        public void AddRequest(string contactRequestName, string contactRequestEmail, string contactRequestMessageContent)
        {
            contactMeRepository.Add(new ContactMe()
            {
                ContactMeId = Guid.NewGuid(),
                Name = contactRequestName,
                Email = contactRequestEmail,
                MessageContent = contactRequestMessageContent,
                Date = DateTime.Now
            });
        }
    }
}
