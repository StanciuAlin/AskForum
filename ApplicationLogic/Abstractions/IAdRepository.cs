using ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;

namespace ApplicationLogic.Abstractions
{
    public interface IAdRepository: IRepository<Ad>
    {
        Ad GetAdByUserId(Guid userId);
        IEnumerable<Comment> GetAdComments(Ad ad);
        void AddAd(Guid adId, DateTime date, string title, string content, string category, Guid userId);
    }
}
