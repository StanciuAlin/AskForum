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

        ApplicationLogic.DataModel.User IUserRepository.GetUserByUserId(Guid userId)
        {
            return dbContext.Users
                            .Where(user => user.UserId == userId)
                            .SingleOrDefault();
        }
    }
}
