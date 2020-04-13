using ApplicationLogic.DataModel;
using ApplicationLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess
{
    public class QuestionRepository: BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AskForumDbContext dbContext) : base(dbContext)
        {
        }

        Question IQuestionRepository.GetQuestionByUserId(Guid userId)
        {
            return dbContext.Questions
                            .Where(question => question.UserId == userId)
                            .SingleOrDefault();
        }

        IEnumerable<Comment> IQuestionRepository.GetQuestionComments(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
