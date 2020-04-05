using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModel
{
    class User
    {
        public long IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public ICollection<Comment> IdComments { get; private set; }
        public ICollection<Article> IdArticles { get; private set; }
        public ICollection<Question> IdQuestions { get; private set; }
        public ICollection<Ad> IdAds { get; private set; }
    }
}
