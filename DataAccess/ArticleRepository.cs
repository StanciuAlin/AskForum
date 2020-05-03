using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(AskForumDbContext dbContext) : base(dbContext)
        {
        }

        Article GetArticleByUserId(Guid user)
        {
            return dbContext.Articles.Include(a => a.Comments).ThenInclude(c => c.User)
                            .Where(article => article.UserId == user)
                            .SingleOrDefault();
        }

        Article IArticleRepository.GetArticleByUserId(Guid user)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Comment> GetArticleComments(Guid articleId)
        {
            var article = dbContext.Articles.Include(a => a.Comments).ThenInclude(c => c.User).Where(a => a.ArticleId == articleId).FirstOrDefault();

            return article.Comments;
        }

        IEnumerable<Comment> IArticleRepository.GetArticleComments(Guid articleId)
        {
            throw new NotImplementedException();
        }
    }
}
