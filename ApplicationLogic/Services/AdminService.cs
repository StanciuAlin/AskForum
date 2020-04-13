using ApplicationLogic.Abstractions;
using ApplicationLogic.DataModel;
using ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Services
{
    class AdminService
    {
        IAdminRepository adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
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
    }
}
