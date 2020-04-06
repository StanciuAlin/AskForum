using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    interface IArticle: IRepository<Article>
    {
        IEnumerable<Comment> GetArticleComments();
        IEnumerable<Comment> GetArticleComments(User user);
    }
}
