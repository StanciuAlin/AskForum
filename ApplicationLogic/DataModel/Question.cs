using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModel
{
    class Question
    {
        public long IdQuestion { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public long IdUser { get; set; }
        public ICollection<Comment> IdComments { get; private set; }
    }
}
