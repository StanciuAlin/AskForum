using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess
{
    public class UserRepository: BaseRepository<ApplicationLogic.DataModel.User>, IUserRepository
    {
        public UserRepository(AskForumDbContext dbContext) : base(dbContext)
        {
        }

        void IUserRepository.AddAd(string userId, string adTitle, string adContent, string adCategory)
        {
        }

        void IUserRepository.AddArticle(string userId, string articleTitle, string articleContent, string articleCategory)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.AddQuestion(string userId, string questionTitle, string questionContent, string questionCategory)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Ad> IUserRepository.GetAds(Guid userId)
        {
            return dbContext.Ads.Where(ad => ad.UserId == userId);
        }

        IEnumerable<Article> IUserRepository.GetArticles(Guid userId)
        {
            return dbContext.Articles.Where(article => article.UserId == userId);
        }

        IEnumerable<Question> IUserRepository.GetQuestions(Guid userId)
        {
            return dbContext.Questions.Where(user => user.UserId == userId);
        }

        ApplicationLogic.DataModel.User IUserRepository.GetUserByUserId(Guid userId)
        {
            return dbContext.Users
                            .Where(user => user.UserId == userId)
                            .SingleOrDefault();
        }
    }
}
