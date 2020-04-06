﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.DataModel
{
    public class Ad
    {
        public long AdId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public ICollection<Comment> IdComments { get; private set; }
        public long IdUser { get; set; }
    }
}
