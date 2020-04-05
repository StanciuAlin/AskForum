using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModel
{
    class Ad
    {
        public long IdAd { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public ICollection<Comment> IdComments { get; private set; }
        public long IdUser { get; set; }
    }
}
