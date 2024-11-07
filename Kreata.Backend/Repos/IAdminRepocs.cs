﻿using Kreata.Backend.Datas.Entities;
using Kreta.Backend.Datas.REsponses;

namespace Kreata.Backend.Repos
{
    public interface IAdminRepo
    {
        Task<List<Admin>> GetAll();
        Task<Admin?> GetBy(Guid Sz1_id);
        Task<ControllerResponse> UpdateAdminAsync(Admin admin);
    }
}
