using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLogic.Services
{
    public class ArticleService
    {
        private IArticleRepository articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public Article GetArticleByUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var article = articleRepository.GetArticleByUserId(userIdGuid);
            if (article == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return article;
        }

        IEnumerable<Comment> GetArticleComments(Article article) //get dupa ArticleId
        {
            //return all comments for that specific article given as parameter
            return article.Comments.AsEnumerable<Comment>();
        }
    }
}
