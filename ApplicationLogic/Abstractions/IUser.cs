using ApplicationLogic.DataModel;
using System.Collections.Generic;

namespace ApplicationLogic.Abstractions
{
    interface IUser: IRepository<User>
    {
        IEnumerable<Comment> GetCommentss();
        IEnumerable<Question> GetQuestions();
        IEnumerable<Article> GetArticles();
        IEnumerable<Ad> GetAds();
    }
}
