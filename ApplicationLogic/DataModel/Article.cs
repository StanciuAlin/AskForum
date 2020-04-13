using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.DataModel
{
    public class Article
    {
        public Guid ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Comment> Comments { get; private set; }
    }
}
