using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLogic.Services
{
    public class AdService
    {
        private IAdRepository adRepository;
        private IUserRepository userRepository;

        public AdService(IAdRepository adRepository)
        {
            this.adRepository = adRepository;
        }

        public Ad GetAdByUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var ad = adRepository.GetAdByUserId(userIdGuid);
            if (ad == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return ad;
        }

        IEnumerable<Comment> GetAdComments(Ad ad) // get dupa AdId
        {
            //return all comments for that specific question given as parameter
            return ad.Comments.AsEnumerable<Comment>();
        }

        public void AddAd(Guid adId, DateTime date, string title, string content, string category, Guid userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(Convert.ToString(userId), out userIdGuid))
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
                Date = date,
                Title = title,
                Content = content,
                Category = category,
                Rating = 0,
                UserId = userId
            });

        }
    }
}
