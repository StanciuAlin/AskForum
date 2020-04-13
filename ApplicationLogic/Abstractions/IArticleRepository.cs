using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    public interface IArticleRepository: IRepository<Article>
    {
        Article GetArticleByUserId(Guid user);
        IEnumerable<Comment> GetArticleComments(Article article);
    }
}
