using Kreata.Backend.Datas.Entities;
using Kreta.Backend.Datas.REsponses;

namespace Kreata.Backend.Repos
{
    public interface IDolgozoRepo
    {
        Task<List<Dolgozo>> GetAll();
        Task<Dolgozo?> GetBy(Guid Sz1_id);
        Task<ControllerResponse> UpdateDolgozoAsync(Dolgozo dolgozo);
    }
}
