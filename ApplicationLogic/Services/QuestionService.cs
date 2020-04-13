using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLogic.Services
{
    class QuestionService
    {
        private IQuestionRepository questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public Question GetQuestionByUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var question = questionRepository.GetQuestionByUserId(userIdGuid);
            if (question == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return question;
        }

        IEnumerable<Comment> GetQuestionComments(Question question)
        {
            //return all comments for that specific question given as parameter
            return question.Comments.AsEnumerable<Comment>();
        }
    }
}
