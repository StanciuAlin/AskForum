using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.DataModel
{
    public class ContactMe
    {
        public Guid ContactMeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
