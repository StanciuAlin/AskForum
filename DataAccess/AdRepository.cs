using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
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

        public void AddAd(Guid adId, DateTime date, string title, string content, string category, Guid userId)
        {
            //throw new NotImplementedException();
            Ad ad = new Ad()
            {
                AdId = adId
                //
            };
            Add(ad);

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
