using Kreata.Backend.Datas.Entities;
using Kreta.Backend.Datas.REsponses;

namespace Kreata.Backend.Repos
{
    public interface IRendelesRepo
    {
        Task<List<Rendeles>> GetAll();
        Task<Rendeles?> GetBy(Guid Sz1_id);
        Task<ControllerResponse> UpdateRendelesAsync(Rendeles rendeles);
    }
}
