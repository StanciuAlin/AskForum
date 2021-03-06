﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.DataModel
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public ICollection<Article> Articles { get; private set; }
        public ICollection<Question> Questions { get; private set; }
        public ICollection<Ad> Ads { get; private set; }
    }
}
