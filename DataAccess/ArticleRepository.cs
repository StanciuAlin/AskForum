using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
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

        Article IArticleRepository.GetArticleByUserId(Guid user)
        {
            return dbContext.Articles
                            .Where(article => article.UserId == user)
                            .SingleOrDefault();
        }

        IEnumerable<Comment> IArticleRepository.GetArticleComments(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
