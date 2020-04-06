using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.DataModel
{
    public class Comment
    {
        public long CommentId { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public long IdUser { get; private set; }
    }
}
