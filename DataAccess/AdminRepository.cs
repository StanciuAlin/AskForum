using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class AdminRepository: BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(AskForumDbContext dbContext) : base(dbContext)
        {
        }

        Admin IAdminRepository.GetAdminByUserId(Guid adminId)
        {
            return dbContext.Admins
                            .Where(admin => admin.AdminId == adminId)
                            .SingleOrDefault();
        }
    }
}
