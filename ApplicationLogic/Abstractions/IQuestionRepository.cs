using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    public interface IQuestionRepository: IRepository<Question>
    {
        Question GetQuestionByUserId(Guid userId);
        IEnumerable<Comment> GetQuestionComments(Question question);
    }
}
