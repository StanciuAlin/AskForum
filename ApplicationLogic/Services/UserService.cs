using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ApplicationLogic.Services
{
    class UserService
    {
        private readonly IUserRepository userRepository;
        private readonly IQuestionRepository questionRepository;
        private readonly IArticleRepository articleRepository;
        private readonly IAdRepository adRepository;

        public UserService(IUserRepository userRepository, IQuestionRepository questionRepository,
            IArticleRepository articleRepository, IAdRepository adRepository)
        {
            this.userRepository = userRepository;
            this.questionRepository = questionRepository;
            this.articleRepository = articleRepository;
            this.adRepository = adRepository;
        }

        public User GetUserByUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var user = userRepository.GetUserByUserId(userIdGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return user;
        }

        #region Get ads, articles or questions
        public IEnumerable<Question> GetQuestions(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return questionRepository.GetAll()
                            .Where(question => question != null && question.UserId == userIdGuid)
                            .AsEnumerable();
        }

        public IEnumerable<Article> GetArticles(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return articleRepository.GetAll()
                            .Where(article => article != null && article.UserId == userIdGuid)
                            .AsEnumerable();
        }

        public IEnumerable<Ad> GetAds(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return adRepository.GetAll()
                            .Where(ad => ad != null && ad.UserId == userIdGuid)
                            .AsEnumerable();
        }
        #endregion

        #region Add new ad, article or question
        public void AddAd(string userId, string adTitle, string adContent, string adCategory)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserByUserId(userIdGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            adRepository.Add(new Ad()
            {
                AdId = Guid.NewGuid(),
                UserId = user.UserId,
                Title = adTitle,
                Content = adContent,
                Category = adCategory,
                Date = DateTime.Now,
                Rating = 0
            });
        }

        public void AddArticle(string userId, string articleTitle, string articleContent, string articleCategory)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserByUserId(userIdGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            articleRepository.Add(new Article()
            {
                ArticleId = Guid.NewGuid(),
                UserId = user.UserId,
                Title = articleTitle,
                Content = articleContent,
                Category = articleCategory,
                Date = DateTime.Now,
                Rating = 0
            });
        }

        public void AddQuestion(string userId, string questionTitle, string questionContent, string questionCategory)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserByUserId(userIdGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            questionRepository.Add(new Question()
            {
                QuestionId = Guid.NewGuid(),
                UserId = user.UserId,
                Title = questionTitle,
                Content = questionContent,
                Category = questionCategory,
                Date = DateTime.Now,
                Rating = 0
            });
        }
        #endregion

    }
}
