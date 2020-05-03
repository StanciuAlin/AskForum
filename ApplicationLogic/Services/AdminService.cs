using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Services
{
    public class AdminService
    {
        IAdminRepository adminRepository;
        IAdRepository adRepository;

        public AdminService(IAdminRepository adminRepository, IAdRepository adRepository)
        {
            this.adminRepository = adminRepository;
            this.adRepository = adRepository;
        }

        public Admin GetAdminByUserId(string adminId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(adminId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var admin = adminRepository.GetAdminByUserId(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return admin;
        }

        public void RemoveAd(Guid userId, Guid adId)
        {
            //validari pentru admin si apoi daca exista ad ul

            Ad ad = adRepository.Get(adId);
            
            if (ad == null)
            {
                throw new EntityNotFoundException(adId);
            }
            adRepository.Delete(ad);

        }
    }
}
