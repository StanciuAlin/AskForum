using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLogic.Services
{
    class AdService
    {
        private IAdRepository adRepository;

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

        IEnumerable<Comment> GetAdComments(Ad ad)
        {
            //return all comments for that specific question given as parameter
            return ad.Comments.AsEnumerable<Comment>();
        }
    }
}
