using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModel
{
    class Comment
    {
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public long IdComment { get; set; }
        public long IdUser { get; private set; }
    }
}
