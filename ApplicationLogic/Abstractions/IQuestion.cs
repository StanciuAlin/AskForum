using DataAccess.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Abstractions
{
    interface IQuestion: IRepository<Question>
    {
        IEnumerable<Comment> GetQuestionComments();
        IEnumerable<Comment> GetQuestionComments(User user);
    }
}
