using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class AdRepository : BaseRepository<Ad>, IAdRepository
    {
        public AdRepository(AskForumDbContext dbContext) : base(dbContext)
        {
        }
        Ad IAdRepository.GetAdByUserId(Guid userId)
        {
            return dbContext.Ads
                            .Where(ad => ad.UserId == userId)
                            .SingleOrDefault();
        }

        IEnumerable<Comment> IAdRepository.GetAdComments(Ad ad)
        {
            throw new NotImplementedException();
        }
    }
}
