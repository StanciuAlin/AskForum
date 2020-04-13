using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;

namespace ApplicationLogic.Abstractions
{
    public interface IUserRepository: IRepository<User>
    {
        //IEnumerable<Comment> GetComments();
        IEnumerable<Question> GetQuestions(Guid userId);
        IEnumerable<Article> GetArticles(Guid userId);
        IEnumerable<Ad> GetAds(Guid userId);
        User GetUserByUserId(Guid userId);
        void AddAd(string userId, string adTitle, string adContent, string adCategory);
        void AddArticle(string userId, string articleTitle, string articleContent, string articleCategory);
        void AddQuestion(string userId, string questionTitle, string questionContent, string questionCategory);
    }
}
